#include "app_main.h"
#include "gps.h"
#include "hrm.h"
#include "uib_app_manager.h"
#include "uib_view1_view.h"
#include "oauth_handler.h"
#include "encode.h"
#include "upload.h"
#include <device/power.h>
#include <device/display.h>
#include <device/callback.h>

/* app event callbacks */
static bool _on_create_cb(void *user_data);
static void _on_terminate_cb(void *user_data);
static void _on_app_control_cb(app_control_h app_control, void *user_data);
static void _on_resume_cb(void *user_data);
static void _on_pause_cb(void *user_data);
static void _on_low_memory_cb(app_event_info_h event_info, void *user_data);
static void _on_low_battery_cb(app_event_info_h event_info, void *user_data);
static void _on_device_orientation_cb(app_event_info_h event_info, void *user_data);
static void _on_language_changed_cb(app_event_info_h event_info, void *user_data);
static void _on_region_format_changed_cb(app_event_info_h event_info, void *user_data);

void
nf_hw_back_cb(void* param, Evas_Object * evas_obj, void* event_info) {
	//TODO : user define code
	evas_obj = uib_views_get_instance()->get_window_obj()->app_naviframe;
	elm_naviframe_item_pop(evas_obj);
}

void
win_del_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

Eina_Bool
nf_root_it_pop_cb(void* elm_win, Elm_Object_Item *it) {
	elm_win_lower(elm_win);
	return EINA_FALSE;
}

app_data *uib_app_create()
{
	return calloc(1, sizeof(app_data));
}

void uib_app_destroy(app_data *user_data)
{
	uib_app_manager_get_instance()->free_all_view_context();
	free(user_data);
}

int uib_app_run(app_data *user_data, int argc, char **argv)
{
	ui_app_lifecycle_callback_s cbs =
	{
		.create = _on_create_cb,
		.terminate = _on_terminate_cb,
		.pause = _on_pause_cb,
		.resume = _on_resume_cb,
		.app_control = _on_app_control_cb,
	};

	app_event_handler_h handlers[5] =
	{NULL, };

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, _on_low_battery_cb, user_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, _on_low_memory_cb, user_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, _on_device_orientation_cb, user_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, _on_language_changed_cb, user_data);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, _on_region_format_changed_cb, user_data);

	dlog_print(DLOG_DEBUG, LOG_TAG, "App running");

	return ui_app_main(argc, argv, &cbs, user_data);
}

void
app_get_resource(const char *res_file_in, char *res_path_out, int res_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
		free(res_path);
	}
}

static oauth_provider_data_s* provider;
static oauth_provider_app_info_s* app_info;

void _access_token_received_cb(oauth_error_e error, const oauth_provider_token_s* token, void* user_data) {
	if (error != OAUTH_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Unable to get access token for upload");
	} else {
		upload_fit(get_fit(), token->acc_tok_key);
	}
	ui_app_exit();
}

static int label_type = PACE_LABEL;
void toggle_label_type() {
	label_type = (label_type + 1) % 2;
	gps_update();
}

int get_label_type() {
	return label_type;
}

void clean_exit() {

	stop_fit();

	provider = malloc(sizeof(oauth_provider_data_s));
	provider->provider_name = "Strava";
	provider->token_url = OAUTH_TOKEN_URL;
	provider->auth_url = OAUTH_AUTH_URL;
	provider->acc_tok_url = OAUTH_TOKEN_URL;

	app_info = malloc(sizeof(oauth_provider_app_info_s));
	app_info->cons_key = OAUTH_CLIENT_ID;
	app_info->cons_secret = OAUTH_CLIENT_SECRET;

	upload_fit(get_fit(), "1b63bb1bbeb322635b9bafc31601b69ea5938aaf");
	ui_app_exit();
//	if (get_access_token(provider, _access_token_received_cb, NULL) != OAUTH_ERROR_NONE) {
//		dlog_print(DLOG_ERROR, LOG_TAG, "Unable to get access token for upload");
//		ui_app_exit();
//		return;
//	}
}

static void _on_display_changed(device_callback_e type, void *value, void *user_data) {
	display_state_e state;
	device_display_get_state(&state);

	if (state == DISPLAY_STATE_NORMAL) {
	    app_control_h app_control = NULL;
		app_control_create(&app_control);
		app_control_set_app_id(app_control, "org.example.Running");

		if(app_control_send_launch_request(app_control, NULL, NULL) == APP_CONTROL_ERROR_NONE)
		{
			// app launched successfully
		}

		app_control_destroy(app_control);
	}
}

static bool _on_create_cb(void *user_data)
{
	/*
	 * This area will be auto-generated when you add or delete user_view
	 * Please do not hand edit this area. The code may be lost.
	 */
	uib_app_manager_st* app_manager = uib_app_manager_get_instance();

	app_manager->initialize();
	dlog_print(DLOG_DEBUG, LOG_TAG, "Initializing");

	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	elm_object_text_set(vc->v1,"...");
	elm_object_text_set(vc->v2,"...");
	elm_object_text_set(vc->v3,"...");
	elm_object_text_set(vc->v4,"...");
	elm_object_text_set(vc->v5,"...");
	elm_object_text_set(vc->v6,"...");
	elm_object_text_set(vc->hrv,"...");

	uib_views_get_instance()->uib_views_current_view_redraw();

	device_add_callback(DEVICE_CALLBACK_DISPLAY_STATE, _on_display_changed, NULL);
	gps_init();
	hrm_init();
	/*
	 * End of area
	 */
	return true;
}

static void _on_terminate_cb(void *user_data)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "terminating");

	device_remove_callback(DEVICE_CALLBACK_DISPLAY_STATE, _on_display_changed);
	gps_destroy();
	hrm_destroy();
	uib_views_get_instance()->destroy_window_obj();
}

static void _on_resume_cb(void *user_data)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "resuming");
}

static void _on_pause_cb(void *user_data)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "pausing");
	//device_display_change_state(DISPLAY_STATE_NORMAL);
}

static void _on_app_control_cb(app_control_h app_control, void *user_data)
{
	/* Handle the launch request. */
}

static void _on_low_memory_cb(app_event_info_h event_info, void *user_data)
{
	/* Take necessary actions when the system runs low on memory. */
}

static void _on_low_battery_cb(app_event_info_h event_info, void *user_data)
{
	/* Take necessary actions when the battery is low. */
}

static void _on_device_orientation_cb(app_event_info_h event_info, void *user_data)
{
	/* deprecated APIs */
}

static void _on_language_changed_cb(app_event_info_h event_info, void *user_data)
{
	/* Take necessary actions is called when language setting changes. */
	uib_views_get_instance()->uib_views_current_view_redraw();
}

static void _on_region_format_changed_cb(app_event_info_h event_info, void *user_data)
{
	/* Take necessary actions when region format setting changes. */
}

