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

#define SAFE_DELETE(x) do { \
		if (x != NULL) {\
			free(x);\
			x = NULL;\
		} \
} while (0)

static CURL *__curl = NULL;

typedef struct _oauth_provider_data_full {
	oauth_provider_data_s *provider_info;
	char *token_temp;
	char *verifier_temp;
	oauth_provider_token_s *token;
	void *user_data;
	on_access_token_received_cb cb;

	Evas_Object *login_win;
	Evas_Object *content_box;
	Evas_Object *loading_popup;
	Evas_Object *ewk_view;
} oauth_provider_data_full_s;

typedef struct _oauth_data_internal {
	oauth_provider_data_s *provider_data;
	on_access_token_received_cb cb;
	void *user_data;
} oauth_data_internal_s;

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

	if (pro_full->provider_info != NULL) {
		SAFE_DELETE(pro_full->provider_info->provider_name);
		SAFE_DELETE(pro_full->provider_info->token_url);
		SAFE_DELETE(pro_full->provider_info->auth_url);
		SAFE_DELETE(pro_full->provider_info->acc_tok_url);

		if (pro_full->provider_info->app_info != NULL) {
			SAFE_DELETE(pro_full->provider_info->app_info->cons_key);
			SAFE_DELETE(pro_full->provider_info->app_info->cons_secret);
		}

		SAFE_DELETE(pro_full->provider_info);
	}

	SAFE_DELETE(pro_full->token_temp);
	SAFE_DELETE(pro_full->verifier_temp);

	if (pro_full->token != NULL) {
		SAFE_DELETE(pro_full->token->acc_tok_key);
		SAFE_DELETE(pro_full->token->acc_tok_secret);
		SAFE_DELETE(pro_full->token);
	}

	SAFE_DELETE(pro_full);
}

static void
__send_response(oauth_error_e err, oauth_provider_data_full_s *provider_full)
{
	__hide_web_view(provider_full);

	if (provider_full != NULL)
		(provider_full->cb)(err, provider_full->token, provider_full->user_data);
	else
		(provider_full->cb)(OAUTH_ERROR_SYSTEM, NULL, NULL);

	__destroy_oauth_provider_full(provider_full);
}

static char*
__get_oauth_header(const char *url, const char *key, const char *sec, const char *token, const char *token_sec)
{
	const char *request_token_uri = url;
	const char *req_c_key = key;
	const char *req_c_secret = sec;

	char *req_url = NULL;
	char *req_hdr = NULL;

	int argc;
	char **argv = NULL;

	argc = oauth_split_url_parameters(request_token_uri, &argv);

	oauth_sign_array2_process(&argc, &argv,
		NULL,
		OA_HMAC,
		NULL,
		req_c_key, req_c_secret, token, token_sec);

	req_hdr = oauth_serialize_url_sep(argc, 1, argv, ", ", 6);

	req_url = oauth_serialize_url_sep(argc, 0, argv, "&", 1);

	oauth_free_array(&argc, &argv);

	char http_header_full[MAX_URL_LEN] = {0, };
	snprintf(http_header_full, MAX_URL_LEN - 1, "Authorization: OAuth %s", req_hdr);

	if (req_url)
		free(req_url);

	if (req_hdr)
		free(req_hdr);

	return strdup(http_header_full);
}


static int
__parse_reply(const char *reply, char **token, char **secret)
{
	gchar **full_list = g_strsplit(reply, "&", 5);

	char *token_full = full_list[0];
	char *sec_full = full_list[1];

	gchar **token_list = g_strsplit(token_full, "=", 3);
	*token = strdup(token_list[1]);

	gchar **sec_list = g_strsplit(sec_full, "=", 3);
	*secret = strdup(sec_list[1]);

	return 0;
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

static char*
__curl_post_request(const char *url, const char *http_header,
		const char *post_body, int *curl_err, long *http_code)
{
	curl_easy_setopt(__curl, CURLOPT_URL, strdup(url));

	if (post_body != NULL)
		curl_easy_setopt(__curl, CURLOPT_POSTFIELDS, strdup(post_body));

	char *data = NULL;
	curl_easy_setopt(__curl, CURLOPT_WRITEDATA, &data);
	curl_easy_setopt(__curl, CURLOPT_WRITEFUNCTION, __store_curl_response);
	curl_easy_setopt(__curl, CURLOPT_SSL_VERIFYPEER, FALSE);

	if (http_header != NULL) {
		struct curl_slist *chunk = NULL;
		chunk = curl_slist_append(chunk, strdup(http_header));
		curl_easy_setopt(__curl, CURLOPT_HTTPHEADER, chunk);
	}

	*curl_err = curl_easy_perform(__curl);

	if (*curl_err != CURLE_OK) {
		curl_easy_cleanup(__curl);
		__curl = NULL;
		return NULL;
	}

	*http_code = 0;
	curl_easy_getinfo(__curl, CURLINFO_RESPONSE_CODE, http_code);

	curl_easy_cleanup(__curl);
	__curl = NULL;

	if (*http_code != 200)
		return NULL;

	return data;
}

static void
__on_web_url_load_error(void *data, Evas_Object *obj, void *event_info)
{
//	const Ewk_Error *error = (const Ewk_Error *)event_info;
//	dlog_print(DLOG_INFO, "liboauthsample", "Web Error = [%d]", ewk_error_code_get(error));
//
//	if (ewk_error_code_get(error) != EWK_ERROR_CODE_CANCELED) {
//		oauth_provider_data_full_s *oauth_full = data;
//		oauth_full->token = NULL;
//
//		__send_response(OAUTH_ERROR_NETWORK, oauth_full->user_data);
//	}
	oauth_provider_data_full_s *oauth_full = data;
	oauth_full->token = NULL;
	__send_response(OAUTH_ERROR_NETWORK, oauth_full->user_data);
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

static void
__parse_acc_token_response(const char *resp, char **token, char **sec)
{
	gchar **full_list = g_strsplit(resp, "&", 5);

	int i = 0;

	while (full_list[i] != NULL) {
		char *str_full = full_list[i];
		gchar **str_full_list = g_strsplit(str_full, "=", 3);

		char *str_key = str_full_list[0];
		if ((str_key != NULL) && (strcmp(str_key, "oauth_token") == 0)) {
			char *str_val = str_full_list[1];
			*token = strdup(str_val);
		} else if ((str_key != NULL) && (strcmp(str_key, "oauth_token_secret") == 0)) {
			char *str_val = str_full_list[1];
			*sec = strdup(str_val);
		}

		i++;
	}
}

static void
__start_access_token_request(oauth_provider_data_full_s *oauth_full)
{
	if (strcmp(oauth_full->provider_info->provider_name, "tumblr") == 0) {
		/*Tumblr includes _#_ in oauth_verifier, we need to filter that out*/
		gchar **verf_list = g_strsplit(oauth_full->verifier_temp, "#", 5);
		oauth_full->verifier_temp = verf_list[0];
	}

	char acc_tok_url[MAX_URL_LEN] = {0, };
	snprintf(acc_tok_url, MAX_URL_LEN - 1, "%s?oauth_verifier=%s", oauth_full->provider_info->acc_tok_url, oauth_full->verifier_temp);

	char *http_header = __get_oauth_header(acc_tok_url, oauth_full->provider_info->app_info->cons_key, oauth_full->provider_info->app_info->cons_secret,
			oauth_full->token_temp, oauth_full->token->acc_tok_secret);

	int curl_err = CURLE_OK;
	long http_err = 200;

	if (__curl == NULL)
		__curl = curl_easy_init();

	char *final_resp = __curl_post_request(oauth_full->provider_info->acc_tok_url, http_header, NULL, &curl_err, &http_err);

	if (final_resp == NULL) {
		if (curl_err == CURLE_OK) {
			oauth_full->token = NULL;
			__send_response(OAUTH_ERROR_SERVER, oauth_full);
		} else {
			oauth_full->token = NULL;
			__send_response(OAUTH_ERROR_NETWORK, oauth_full);
		}

		return;
	}

	dlog_print(DLOG_INFO, "liboauthsample", "Final response =[%s]", final_resp);

	char *acc_tok = NULL;
	char *acc_tok_sec = NULL;

	__parse_acc_token_response(final_resp, &acc_tok, &acc_tok_sec);

	SAFE_DELETE(final_resp);
	oauth_full->token->acc_tok_key = acc_tok;
	oauth_full->token->acc_tok_secret = acc_tok_sec;

	__send_response(OAUTH_ERROR_NONE, oauth_full);
}

/*Step 3 : Get Access Token*/
static void
_on_auth_grant_received(oauth_provider_data_full_s *oauth_full, const char *reply)
{
	if (reply == NULL) {
		SAFE_DELETE(oauth_full->token);
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	gchar **full_list = g_strsplit(reply, "&", 5);

	char *token_full = full_list[0];
	if (token_full == NULL) {
		SAFE_DELETE(oauth_full->token);
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	if (full_list[1] == NULL) {
		SAFE_DELETE(oauth_full->token);
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	char *verf_full = full_list[1];
	if (verf_full == NULL) {
		SAFE_DELETE(oauth_full->token);
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	gchar **token_list = g_strsplit(token_full, "=", 3);

	if (oauth_full->token_temp != NULL) {
		free(oauth_full->token_temp);
		oauth_full->token_temp = NULL;
	}

	oauth_full->token_temp = strdup(token_list[1]);

	gchar **verf_list = g_strsplit(verf_full, "=", 3);
	if (verf_list == NULL) {
		SAFE_DELETE(oauth_full->token);
		__send_response(OAUTH_ERROR_SERVER, oauth_full);
		return;
	}

	oauth_full->verifier_temp = strdup(verf_list[1]);

	__start_access_token_request(oauth_full);
}

static void
__on_web_url_change(void *data, Evas_Object *obj, void *event_info)
{
	const char *uri = event_info;

	oauth_provider_data_full_s *oauth_full = data;

	if (g_str_has_prefix(uri, OAUTH_REDIRECT_URL) == TRUE) {
		__hide_web_view(oauth_full);
		char *oauth_response = strdup(uri);
		_on_auth_grant_received(oauth_full, oauth_response);

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
		SAFE_DELETE(oauth_full->token);
		__send_response(OAUTH_ERROR_USER_CANCELED, oauth_full);
	}
}

/*Step 2 : Get Authorization (User enters his/her credentials, and allows access to this app)*/
static int
__show_web_view(oauth_provider_data_full_s *oauth_full, const char *url)
{
	int w = 400;
	int h = 400;

	system_info_get_platform_int("tizen.org/feature/screen.width", &w);
	system_info_get_platform_int("tizen.org/feature/screen.height", &h);

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
int
get_access_token(oauth_provider_data_s *provider_data, on_access_token_received_cb cb, void *user_data)
{

	if (__curl == NULL)
		__curl = curl_easy_init();

	oauth_provider_data_full_s *oauth_full = calloc(1, sizeof(oauth_provider_data_full_s));
	oauth_full->provider_info = provider_data;
	oauth_full->cb = cb;
	oauth_full->user_data = user_data;

	char *oauth_header = __get_oauth_header(provider_data->token_url, provider_data->app_info->cons_key, provider_data->app_info->cons_secret, NULL, NULL);
	int curl_err = 0;
	long http_code = 0;
	char *resp = __curl_post_request(provider_data->token_url, oauth_header, NULL, &curl_err, &http_code);
	if (resp == NULL) {
		if (curl_err == CURLE_OK)
			return OAUTH_ERROR_SERVER;
		else
			return OAUTH_ERROR_NETWORK;
	}

	char *token = NULL;
	char *token_sec = NULL;

	__parse_reply(resp, &token, &token_sec);
	if ((token == NULL) || (token_sec == NULL)) {
		SAFE_DELETE(token);
		SAFE_DELETE(token_sec);

		return OAUTH_ERROR_SERVER;
	}

	SAFE_DELETE(resp);
	oauth_full->token_temp = token;

	oauth_full->token = calloc(1, sizeof(oauth_provider_token_s));
	oauth_full->token->acc_tok_secret = token_sec;

	char url[MAX_URL_LEN] = {0, };
	snprintf(url, MAX_URL_LEN - 1, "%s?oauth_token=%s", oauth_full->provider_info->auth_url, oauth_full->token_temp);
	__show_web_view(oauth_full, url);

	oauth_full->loading_popup = elm_popup_add(oauth_full->login_win);
	elm_popup_content_text_wrap_type_set(oauth_full->loading_popup, ELM_WRAP_MIXED);
	elm_object_text_set(oauth_full->loading_popup, "Loading...");
	elm_popup_orient_set(oauth_full->loading_popup, ELM_POPUP_ORIENT_BOTTOM);

	evas_object_show(oauth_full->loading_popup);

	return OAUTH_ERROR_NONE;
}
