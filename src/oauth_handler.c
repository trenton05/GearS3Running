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

#define SAFE_DELETE(x) do { \
		if (x != NULL) {\
			free(x);\
			x = NULL;\
		} \
} while (0)

static CURL *__curl = NULL;

typedef struct _oauth_provider_data_full {
	Evas_Object *login_win;
	Evas_Object *content_box;
	Evas_Object *loading_popup;
	Evas_Object *ewk_view;
} oauth_provider_data_full_s;

static char* token = NULL;

static void
__hide_web_view(oauth_provider_data_full_s *oauth_full)
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
__destroy_oauth_provider_full(oauth_provider_data_full_s *pro_full)
{
	if (pro_full == NULL)
		return;

	pro_full->login_win = NULL;
	pro_full->ewk_view = NULL;
	pro_full->loading_popup = NULL;
	pro_full->content_box = NULL;

	SAFE_DELETE(pro_full);
}

static void
__send_response(oauth_error_e err, oauth_provider_data_full_s *provider_full)
{
	__hide_web_view(provider_full);

	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	if (err != 0) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Oauth err: %d", err);
		if (err == OAUTH_ERROR_USER_CANCELED) {
			elm_object_text_set(vc->bottomLabel,"Login");
		} else {
			elm_object_text_set(vc->bottomLabel,"Error");
		}
	} else {
		elm_object_text_set(vc->bottomLabel,"Logout");

		FILE* fp = fopen(OAUTH_FILE, "w");
		fputs(token, fp);
		fclose(fp);
	}

	uib_views_get_instance()->uib_views_current_view_redraw();

	__destroy_oauth_provider_full(provider_full);
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
	oauth_provider_data_full_s *oauth_full = data;
	__send_response(OAUTH_ERROR_NETWORK, oauth_full);
}

static void
__on_web_url_load_finished(void *data, Evas_Object *obj, void *event_info)
{
	oauth_provider_data_full_s *oauth_full = data;
	if (oauth_full->loading_popup) {
		evas_object_hide(oauth_full->loading_popup);
		oauth_full->loading_popup = NULL;
	}
}


/*Step 3 : Get Access Token*/
static void
_on_auth_grant_received(oauth_provider_data_full_s *oauth_full, const char *reply)
{
	if (reply == NULL) {
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth code url: %s", reply);

	char* code = strchr(reply, '?');
	if (!code) {
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	__curl = curl_easy_init();
	curl_easy_setopt(__curl, CURLOPT_URL, OAUTH_TOKEN_URL);

	char post[MAX_STR_LEN] = {0, };
	snprintf(post, MAX_STR_LEN - 1, "client_id=%s&client_secret=%s&%s",
			OAUTH_CLIENT_ID, OAUTH_CLIENT_SECRET, code);
	curl_easy_setopt(__curl, CURLOPT_POSTFIELDS, strdup(post));

	char *data = NULL;
	curl_easy_setopt(__curl, CURLOPT_WRITEDATA, &data);
	curl_easy_setopt(__curl, CURLOPT_WRITEFUNCTION, __store_curl_response);

	CURLcode resp = curl_easy_perform(__curl);
	dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth token response: %s", data);

	if (resp != CURLE_OK) {
		curl_easy_cleanup(__curl);
		__curl = NULL;
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	curl_easy_cleanup(__curl);

	char* access = strstr(data, "\"access_token\"");
	char* start = access ? strchr(access + 14, '\"') : NULL;
	char* end = start ? strchr(start + 1, '\"') : NULL;
	if (!end) {
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	token = strndup(start + 1, end - start - 1);

	__send_response(0, oauth_full);
}

static void
__on_web_url_change(void *data, Evas_Object *obj, void *event_info)
{
	const char *uri = event_info;

	oauth_provider_data_full_s *oauth_full = data;

	if (g_str_has_prefix(uri, OAUTH_REDIRECT_URL) == TRUE) {
		__hide_web_view(oauth_full);
		_on_auth_grant_received(oauth_full, uri);

		if (oauth_full->loading_popup == NULL) {
			oauth_full->loading_popup = elm_popup_add(oauth_full->login_win);
			elm_popup_content_text_wrap_type_set(oauth_full->loading_popup, ELM_WRAP_MIXED);
			elm_object_text_set(oauth_full->loading_popup, "Loading...");
			elm_popup_orient_set(oauth_full->loading_popup, ELM_POPUP_ORIENT_BOTTOM);
			evas_object_show(oauth_full->loading_popup);
		}
	}
}

static void
__handle_back_key(void *data, Evas_Object *p, void *info)
{
	if (data) {
		oauth_provider_data_full_s *oauth_full = data;
		__send_response(OAUTH_ERROR_USER_CANCELED, oauth_full);
	}
}

/*Step 2 : Get Authorization (User enters his/her credentials, and allows access to this app)*/
static int
__show_web_view(oauth_provider_data_full_s *oauth_full, const char *url)
{
	int w = 240;
	int h = 240;

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

/*Step 1 : Get Request Token*/
void oauth_login()
{
	FILE* fp = fopen(OAUTH_FILE, "w");
	fclose(fp);
	token = NULL;

	oauth_provider_data_full_s *oauth_full = calloc(1, sizeof(oauth_provider_data_full_s));

	char url[MAX_URL_LEN] = {0, };
	snprintf(url, MAX_URL_LEN - 1, "%s?response_type=code&scope=write&redirect_uri=%s&client_id=%s",
			OAUTH_AUTH_URL, OAUTH_REDIRECT_URL, OAUTH_CLIENT_ID);
	dlog_print(DLOG_DEBUG, LOG_TAG, "Oauth auth url: %s", url);
	__show_web_view(oauth_full, url);

	oauth_full->loading_popup = elm_popup_add(oauth_full->login_win);
	elm_popup_content_text_wrap_type_set(oauth_full->loading_popup, ELM_WRAP_MIXED);
	elm_object_text_set(oauth_full->loading_popup, "Loading...");
	elm_popup_orient_set(oauth_full->loading_popup, ELM_POPUP_ORIENT_BOTTOM);

	evas_object_show(oauth_full->loading_popup);

}


char* oauth_access_token() {
	return token;
}

void oauth_init() {

	FILE* fp = fopen(OAUTH_FILE, "r");
	if (fp) {
		char buf[255];
		char* read = fgets(buf, 255, fp);
		if (read) {
			token = strdup(buf);
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
