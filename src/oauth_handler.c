/*
 * Copyright (c) 2014 - 2015 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

#include "stdio.h"
#include <stddef.h>
#include <glib.h>
#include <curl/curl.h>
#include <EWebKit.h>
#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <oauth.h>
#include <system_info.h>

#include "oauth_handler.h"

#include "g_inc_uib.h"
#include "uib_views.h"
#include "app_main.h"
#include "uib_app_manager.h"
#include "uib_view1_view.h"

typedef struct _oauth_provider_data_full {
	Evas_Object *login_win;
	Evas_Object *content_box;
	Evas_Object *loading_popup;
	Evas_Object *ewk_view;
} oauth_provider_data_full_s;

static char* token = NULL;
static oauth_provider_data_full_s* oauth_full = NULL;

static void
__hide_web_view()
{
	if (oauth_full == NULL)
		return;

	if (oauth_full->ewk_view != NULL) {
		ewk_view_stop(oauth_full->ewk_view);
		evas_object_hide(oauth_full->ewk_view);
		evas_object_hide(oauth_full->login_win);
	}
	if (oauth_full->loading_popup != NULL) {
		evas_object_hide(oauth_full->loading_popup);
		oauth_full->loading_popup = NULL;
	}

	oauth_full->login_win = NULL;
	oauth_full->ewk_view = NULL;
	oauth_full->loading_popup = NULL;
	oauth_full->content_box = NULL;
}

static void
__send_response(oauth_error_e err)
{
	if (oauth_full == NULL) return;

	__hide_web_view();

	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	if (err != 0) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Oauth err: %d", err);
		if (err == OAUTH_ERROR_USER_CANCELED) {
			elm_object_text_set(vc->v6,"Login");
		} else {
			elm_object_text_set(vc->v6,"Error");
		}
	} else {
		elm_object_text_set(vc->v6,"Logout");
		dlog_print(DLOG_DEBUG, LOG_TAG, "Storing oauth token: %s", token);

		char file[255];
		char* directory = get_directory();
		strcpy(file, directory);
		strcat(file, OAUTH_FILE);

		dlog_print(DLOG_DEBUG, LOG_TAG, "Storing oauth file: %s", file);
		FILE* fp = fopen(file, "w");
		fputs(token, fp);
		fclose(fp);
	}

	uib_views_get_instance()->uib_views_current_view_redraw();

	free(oauth_full);
	oauth_full = NULL;
}


static size_t
__store_curl_response(void *ptr, size_t size, size_t nmemb, void *data)
{
	char **result = (char **)data;

	if (NULL == *result) {
		*result = calloc(size * nmemb + 1, sizeof(char));
		memcpy(*result, ptr, size * nmemb);
	} else {
		size_t len = strlen(*result);
		*result = realloc(*result, len + size * nmemb + 1);
		memcpy(*result + len, ptr, size * nmemb);
		(*result)[len+size*nmemb] = '\0';
	}
	return size * nmemb;
}

static void
__on_web_url_load_error(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "oauth url load err");
}

static void
__on_web_url_load_finished(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "oauth url load done");
	if (oauth_full && oauth_full->loading_popup) {
		evas_object_hide(oauth_full->loading_popup);
		oauth_full->loading_popup = NULL;
	}
}


/*Step 3 : Get Access Token*/
static void
_on_auth_grant_received(const char *reply)
{
	if (reply == NULL || oauth_full == NULL) {
		__send_response(OAUTH_ERROR_SERVER);
		return;
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth code url: %s", reply);

	char* code = strchr(reply, '?');
	if (!code) {
		__send_response(OAUTH_ERROR_SERVER);
		return;
	}

	CURL* __curl = curl_easy_init();
	curl_easy_setopt(__curl, CURLOPT_URL, OAUTH_TOKEN_URL);

	char post[MAX_STR_LEN] = {0, };
	snprintf(post, MAX_STR_LEN - 1, "client_id=%s&client_secret=%s&%s",
			OAUTH_CLIENT_ID, OAUTH_CLIENT_SECRET, code);
	curl_easy_setopt(__curl, CURLOPT_POSTFIELDS, strdup(post));

	char *data = malloc(1);
	*data = 0;
	curl_easy_setopt(__curl, CURLOPT_WRITEDATA, &data);
	curl_easy_setopt(__curl, CURLOPT_WRITEFUNCTION, __store_curl_response);
	
	curl_easy_setopt(__curl, CURLOPT_TIMEOUT, 60L);
	curl_easy_setopt(__curl, CURLOPT_FAILONERROR, true);

	CURLcode resp = curl_easy_perform(__curl);
	dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth token response: %s", data);

	curl_easy_cleanup(__curl);

	if (resp != CURLE_OK) {
		free(data);
		__send_response(OAUTH_ERROR_SERVER);
		return;
	}

	char* access = strstr(data, "\"access_token\"");
	char* start = access ? strchr(access + 14, '\"') : NULL;
	char* end = start ? strchr(start + 1, '\"') : NULL;
	if (!end) {
		free(data);
		__send_response(OAUTH_ERROR_SERVER);
		return;
	}

	token = strndup(start + 1, end - start - 1);
	free(data);

	__send_response(0);
}

static void
__on_web_url_change(void *data, Evas_Object *obj, void *event_info)
{
	const char *uri = event_info;

	if (g_str_has_prefix(uri, OAUTH_REDIRECT_URL) == TRUE) {

		if (oauth_full->loading_popup != NULL) {
			evas_object_hide(oauth_full->loading_popup);
			oauth_full->loading_popup = NULL;
		}

		oauth_full->loading_popup = elm_popup_add(oauth_full->login_win);
		elm_popup_content_text_wrap_type_set(oauth_full->loading_popup, ELM_WRAP_MIXED);
		elm_object_text_set(oauth_full->loading_popup, "Retrieving Token...");
		elm_popup_orient_set(oauth_full->loading_popup, ELM_POPUP_ORIENT_CENTER);

		evas_object_show(oauth_full->loading_popup);

		_on_auth_grant_received(uri);
	}
}

static void
__handle_back_key(void *data, Evas_Object *p, void *info)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "oauth back key");
	__send_response(OAUTH_ERROR_USER_CANCELED);
}

/*Step 2 : Get Authorization (User enters his/her credentials, and allows access to this app)*/
static int
__show_web_view(const char *url)
{
	int w = 360;
	int h = 360;

	oauth_full->login_win = elm_win_util_standard_add("Login", "");
	eext_object_event_callback_add(oauth_full->login_win, EEXT_CALLBACK_BACK, __handle_back_key, oauth_full);

	ewk_init();

	Evas *canvas = NULL;

	oauth_full->content_box = elm_box_add(oauth_full->login_win);
	elm_box_padding_set(oauth_full->content_box, 0, 3);
	evas_object_size_hint_weight_set(oauth_full->content_box,
		EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(oauth_full->content_box, 0.0, 0.0);
	evas_object_show(oauth_full->content_box);

	canvas = evas_object_evas_get(oauth_full->login_win);

	oauth_full->ewk_view = ewk_view_add(canvas);
	if (oauth_full->ewk_view == NULL)
		return OAUTH_ERROR_SYSTEM;

	ewk_view_url_set(oauth_full->ewk_view, url);
	evas_object_size_hint_min_set(oauth_full->ewk_view, w, h);
	evas_object_size_hint_align_set(oauth_full->ewk_view, 0.0, 0.0);

	evas_object_size_hint_weight_set(oauth_full->ewk_view,
		EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(oauth_full->ewk_view,
		EVAS_HINT_FILL, EVAS_HINT_FILL);

	evas_object_smart_callback_add(oauth_full->ewk_view, "url,changed",
		__on_web_url_change, oauth_full);
	evas_object_smart_callback_add(oauth_full->ewk_view, "load,error",
		__on_web_url_load_error, oauth_full);
	evas_object_smart_callback_add(oauth_full->ewk_view, "load,finished",
		__on_web_url_load_finished, oauth_full);

	elm_box_pack_end(oauth_full->content_box, oauth_full->ewk_view);
	evas_object_show(oauth_full->ewk_view);

	evas_object_show(oauth_full->login_win);

	return 0;
}

static bool deauthorize() {

	  CURL *curl;

	  CURLcode res;

	  struct curl_slist *headerlist=NULL;
	  char buf[256];
	  strcpy(buf, "Authorization: Bearer ");
	  strcat(buf, token);

	  curl = curl_easy_init();
	  /* initialize custom header list (stating that Expect: 100-continue is not
	     wanted */
	  headerlist = curl_slist_append(headerlist, buf);
	/* what URL that receives this POST */
	curl_easy_setopt(curl, CURLOPT_URL, OAUTH_DEAUTH_URL);

	char *data = malloc(1);
	*data = 0;
	curl_easy_setopt(curl, CURLOPT_WRITEDATA, &data);
	curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, __store_curl_response);

	/* only disable 100-continue header if explicitly requested */
	curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headerlist);
	curl_easy_setopt(curl, CURLOPT_HTTPPOST, NULL);
	curl_easy_setopt(curl, CURLOPT_TIMEOUT, 60L);
	curl_easy_setopt(curl, CURLOPT_FAILONERROR, true);

	dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth logout");
	/* Perform the request, res will get the return code */
	res = curl_easy_perform(curl);
	/* Check for errors */
	/* Check for errors */
	if(res != CURLE_OK) {
	  dlog_print(DLOG_ERROR, LOG_TAG, "curl_easy_perform() failed: %s\n",
			  curl_easy_strerror(res));
	} else if (data) {
		dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth logged out: %s", data);
	}

	/* always cleanup */
	curl_easy_cleanup(curl);

	/* free slist */
	curl_slist_free_all(headerlist);
	free(data);
	return res == CURLE_OK;

}

/*Step 1 : Get Request Token*/
void oauth_login()
{

	if (token) {
		deauthorize();

		char file[255];
		char* directory = get_directory();
		strcpy(file, directory);
		strcat(file, OAUTH_FILE);

		FILE* fp = fopen(file, "w");
		fclose(fp);
		token = NULL;

		uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
		uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

		elm_object_text_set(vc->bottomLabel,"Login");

		uib_views_get_instance()->uib_views_current_view_redraw();
	} else {

		oauth_full = calloc(1, sizeof(oauth_provider_data_full_s));

		char url[MAX_URL_LEN] = {0, };
		snprintf(url, MAX_URL_LEN - 1, "%s?response_type=code&scope=write&redirect_uri=%s&client_id=%s",
				OAUTH_AUTH_URL, OAUTH_REDIRECT_URL, OAUTH_CLIENT_ID);
		dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth auth url: %s", url);
		__show_web_view(url);

		oauth_full->loading_popup = elm_popup_add(oauth_full->login_win);
		elm_popup_content_text_wrap_type_set(oauth_full->loading_popup, ELM_WRAP_MIXED);
		elm_object_text_set(oauth_full->loading_popup, "Loading...");
		elm_popup_orient_set(oauth_full->loading_popup, ELM_POPUP_ORIENT_BOTTOM);

		evas_object_show(oauth_full->loading_popup);
	}
}


char* oauth_access_token() {
	return token;
}

void oauth_init() {

	char file[255];
	char* directory = get_directory();
	strcpy(file, directory);
	strcat(file, OAUTH_FILE);

	FILE* fp = fopen(file, "r");
	if (fp) {
		char buf[255];
		char* read = fgets(buf, 255, fp);
		if (read) {
			token = strdup(buf);
			dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth found token");
		}
		fclose(fp);
	}

	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	if (token) {
		elm_object_text_set(vc->bottomLabel,"Logout");
	} else {
		elm_object_text_set(vc->bottomLabel,"Login");
	}

	uib_views_get_instance()->uib_views_current_view_redraw();
}
