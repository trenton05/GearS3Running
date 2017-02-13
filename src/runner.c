#include "app_main.h"
#include <tizen.h>
#include <curl/curl.h>

int main(int argc, char **argv)
{
	int result = 0;

	curl_global_init(CURL_GLOBAL_ALL);
	app_data *app = uib_app_create();
	if (app)
	{
		result = uib_app_run(app, argc, argv);
		uib_app_destroy(app);
	}

	curl_global_cleanup();

	return result;
}

