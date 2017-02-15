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

#define OAUTH_REDIRECT_URL "http://localhost"
#define OAUTH_AUTH_URL "https://www.strava.com/oauth/authorize"
#define OAUTH_DEAUTH_URL "https://www.strava.com/oauth/deauthorize"
#define OAUTH_TOKEN_URL "https://www.strava.com/oauth/token"
#define OAUTH_CLIENT_ID "16159"
#define OAUTH_CLIENT_SECRET "7d36940f3381a84e207cf86af35b3c42ac47aadb"
#define OAUTH_FILE "strava.token"

typedef enum {
	OAUTH_ERROR_NONE,
	OAUTH_ERROR_USER_CANCELED,
	OAUTH_ERROR_SERVER,
	OAUTH_ERROR_SYSTEM,
	OAUTH_ERROR_NETWORK
} oauth_error_e;

void oauth_login();
char* oauth_access_token();
void oauth_init();

#endif /* OAUTH_HANDLER_H_ */
