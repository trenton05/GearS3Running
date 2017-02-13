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

#include <tizen.h>

#ifndef OAUTH_HANDLER_H_
#define OAUTH_HANDLER_H_

#define MAX_URL_LEN 1000
#define MAX_STR_LEN 5000

#define OAUTH_REDIRECT_URL "http://albrec.ht"
#define OAUTH_AUTH_URL "https://www.strava.com/oauth/authorize"
#define OAUTH_TOKEN_URL "https://www.strava.com/oauth/token"
#define OAUTH_CLIENT_ID "16159"
#define OAUTH_CLIENT_SECRET "7d36940f3381a84e207cf86af35b3c42ac47aadb"
/*
 * ?client_id=16159&redirect_uri=http://albrec.ht&response_type=code&scope=write
 * secret: 7d36940f3381a84e207cf86af35b3c42ac47aadb
 * access token: 1b63bb1bbeb322635b9bafc31601b69ea5938aaf
 */

typedef enum {
	OAUTH_ERROR_NONE,
	OAUTH_ERROR_USER_CANCELED,
	OAUTH_ERROR_SERVER,
	OAUTH_ERROR_SYSTEM,
	OAUTH_ERROR_NETWORK
} oauth_error_e;

/*Application Info*/
typedef struct _oauth_provider_app_info {
	char *cons_key;
	char *cons_secret;
} oauth_provider_app_info_s;

/*Service Provider Info*/
typedef struct _oauth_provider_data {
	char *provider_name;
	char *token_url;
	char *auth_url;
	char *acc_tok_url;
	oauth_provider_app_info_s *app_info;
} oauth_provider_data_s;

/*Service Provider specific token for the user*/
typedef struct _oauth_provider_token {
	char *acc_tok_key;
	char *acc_tok_secret;
} oauth_provider_token_s;

/*Callback for Access Token request calls : get_access_token(), get_access_token_twitter(), get_access_token_tumblr */
typedef void (*on_access_token_received_cb)(oauth_error_e error, const oauth_provider_token_s *token, void *user_data);

/*Gets Access Token from Any OAuth 1.0a supported service provider*/
int get_access_token(oauth_provider_data_s *provider_data, on_access_token_received_cb cb, void *user_data);

#endif /* OAUTH_HANDLER_H_ */
