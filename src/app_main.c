#include "app_main.h"
#include "gps.h"
#include "hrm.h"
#include "uib_app_manager.h"
#include "uib_view1_view.h"
#include "oauth_handler.h"
#include "encode.h"
#include "upload.h"
#include "speech.h"
#include "voice.h"

#include <Ecore.h>
#include <dirent.h>
#include <device/power.h>
#include <device/battery.h>
#include <device/display.h>
#include <device/callback.h>
#include <storage.h>

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
static bool started = false;
static int storage_id = 0;
static char* directory = NULL;
static Evas_Object *popup = NULL;

char* get_directory() {
	if (!directory) {
		char* d;
		storage_get_directory(storage_id, STORAGE_DIRECTORY_DOCUMENTS, &d);
		directory = malloc(strlen(d) + 2);
		strcpy(directory, d);
		strcat(directory, "/");
		free(d);
	}
	return directory;
}

void
nf_hw_back_cb(void* param, Evas_Object * evas_obj, void* event_info) {
	//TODO : user define code

	if (!started || !gps_is_running()) {
		clean_exit();
	} else {
		gps_toggle_running();
	}

	//evas_obj = uib_views_get_instance()->get_window_obj()->app_naviframe;
	//elm_naviframe_item_pop(evas_obj);
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

bool storage_cb(int sid, storage_type_e type, storage_state_e state, const char *path, void *user_data) {
	if (type == STORAGE_TYPE_INTERNAL) {
		storage_id = sid;
		return false;
	}
	return true;
}

int uib_app_run(app_data *user_data, int argc, char **argv)
{
	storage_foreach_device_supported(storage_cb, NULL);

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

static void _hide_popup() {
	if (popup) {
		evas_object_hide(popup);
		popup = NULL;
	}
}

static void _show_popup(const char* text) {
	_hide_popup();

	if (!popup) {
		uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
		uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

		popup = elm_popup_add(vc->root_container);
		elm_popup_content_text_wrap_type_set(popup, ELM_WRAP_MIXED);
		elm_object_text_set(popup, text);
		elm_popup_orient_set(popup, ELM_POPUP_ORIENT_CENTER);
		evas_object_show(popup);
	} else {
		elm_object_text_set(popup, text);
	}
}

static bool upload_failed = false;
static char* activity_name = NULL;
static void _upload_files(void* user_data, Ecore_Thread *thread) {

	char* token = oauth_access_token();

	if (token) {

		dlog_print(DLOG_DEBUG, LOG_TAG, "Uploading files");
		DIR* d;
		char* directory = get_directory();

		struct dirent* dir;
		d = opendir(directory);

		if (d) {
			while ((dir = readdir(d)) != NULL) {
				if (strncmp(dir->d_name, FILE_PREFIX, strlen(FILE_PREFIX)) == 0) {
					char file[255];
					strcpy(file, directory);
					strcat(file, dir->d_name);
					bool pace = gps_get_pace();
					if (!upload_fit(file, token, activity_name, pace)) {
						char buf[80];
						sprintf(buf, "Upload %s Failed!", dir->d_name);
						_show_popup(buf);

						upload_failed = true;
						break;
					} else {
						remove(file);
					}

				}
			}
			closedir(d);
		}
	}
}

static void thread_exit(void *user_data, Ecore_Thread *thread) {
	if (upload_failed) {
		upload_failed = false;
	} else {
		ui_app_exit();
	}
}

static bool listening = false;
void _voice_cb(const char* name) {
	if (!listening) return;

	listening = false;

	activity_name = name ? strdup(name) : NULL;

	char buf[80];
	sprintf(buf, "Uploading %s...", name ? name : "Data");
	_show_popup(buf);

	ecore_thread_run(_upload_files, thread_exit, thread_exit, NULL);
}

static bool exiting = false;
void clean_exit() {
	if (!exiting) {
		exiting = true;
		bool written = stop_fit();
		if (written && oauth_access_token()) {

			char buf[80];
			sprintf(buf, "Listening for activity name...");
			_show_popup(buf);

			listening = true;
			voice_listen(_voice_cb);
		} else {
			listening = true;
			_voice_cb(NULL);
		}
	} else {
		if (listening) {
			_voice_cb(NULL);
		} else {
			thread_exit(NULL, NULL);
		}
	}
}


static void _on_display_changed(device_callback_e type, void *value, void *user_data) {
	display_state_e state;
	device_display_get_state(&state);

	if (state == DISPLAY_STATE_NORMAL) {
	    app_control_h app_control = NULL;
		app_control_create(&app_control);
		app_control_set_app_id(app_control, "org.tralbrecht.GearS3Running");

		if(app_control_send_launch_request(app_control, NULL, NULL) == APP_CONTROL_ERROR_NONE)
		{
			// app launched successfully
		}

		app_control_destroy(app_control);
	}
}

static void update_battery() {
	int percent;

	if (device_battery_get_percent(&percent) == DEVICE_ERROR_NONE) {
		if (percent >= 100) percent = 99;

		uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
		uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

		char buf[64];
		sprintf(buf, "%02d%%", percent);
		elm_object_text_set(vc->btv, buf);

		uib_views_get_instance()->uib_views_current_view_redraw();
	}
}

static void _on_battery_changed(device_callback_e type, void *value, void *user_data) {
	update_battery();
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

	device_add_callback(DEVICE_CALLBACK_DISPLAY_STATE, _on_display_changed, NULL);
	device_add_callback(DEVICE_CALLBACK_BATTERY_CAPACITY, _on_battery_changed, NULL);

	dlog_print(DLOG_DEBUG, LOG_TAG, "Loading oauth");

	oauth_init();


	time_t t;
	time(&t);

	char* file = malloc(128);
	char* directory = get_directory();
	strcpy(file, directory);

	sprintf(file + strlen(file), FILE_FORMAT, (int) t);
	dlog_print(DLOG_DEBUG, LOG_TAG, "Starting fit track in %s", file);
	start_fit(file);

	dlog_print(DLOG_DEBUG, LOG_TAG, "Starting gps");

	speech_init();
	voice_init();
	gps_init();
	hrm_init();

	update_battery();
	update_settings();
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
	speech_destroy();
	voice_destroy();
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

void top_toggle() {
	if (!started) {
		started = true;
	}

	gps_toggle_running();
}

void bottom_toggle() {
	if (!started || !gps_is_running()) {
		clean_exit();
	}
}

void l1_toggle() {
	if (started) {
		gps_update_speech();
		return;
	}
}

void l2_toggle() {
	if (started) {
		gps_update_speech();
		return;
	}
	gps_set_metric(!gps_get_metric());
	update_settings();
}

void l3_toggle() {
	if (started) {
		gps_update_speech();
		return;
	}
	gps_set_pace(!gps_get_pace());
	update_settings();
}

void l4_toggle() {
	if (started) {
		gps_update_speech();
		return;
	}

	int current = gps_get_haptic();
	switch (current) {
	case 0:
		current = 1;
		break;
	case 1:
		current = 2;
		break;
	case 2:
		current = 5;
		break;
	case 5:
		current = 10;
		break;
	case 10:
		current = 0;
		break;
	}
	gps_set_haptic(current);
	update_settings();
}

void l5_toggle() {
	if (started) {
		gps_update_speech();
		return;
	}
	int current = gps_get_speech();
	switch (current) {
	case 0:
		current = 5;
		break;
	case 5:
		current = 10;
		break;
	case 10:
		current = 20;
		break;
	case 20:
		current = 0;
		break;
	}
	gps_set_speech(current);
	update_settings();
}

void l6_toggle() {
	if (started) {
		gps_update_speech();
		return;
	}
	oauth_login();
}

void update_settings() {
	if (started) {
		return;
	}

	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	elm_object_text_set(vc->topLabel,"<align=center>Start</align>");
	elm_object_text_set(vc->bottomLabel,"<align=center>Exit</align>");

	bool metric = gps_get_metric();
	elm_object_text_set(vc->l1,"GPS");
	elm_object_text_set(vc->v1, gps_has_signal() ? "Found" : "...");
	elm_object_text_set(vc->l2,"Unit");
	elm_object_text_set(vc->v2, metric ? "Metric" : "Imperial");
	elm_object_text_set(vc->l3,"Type");
	elm_object_text_set(vc->v3, gps_get_pace() ? "Pace" : "Speed");
	elm_object_text_set(vc->l4,"Vibr");

	int haptic = gps_get_haptic();
	elm_object_text_set(vc->v4, haptic == 0 ? "No" :
			metric ?
					haptic == 1 ? "0.1 km" : haptic == 2 ? "0.2 km" : haptic == 5 ? "0.5 km" : haptic == 10 ? "1.0 km" : ""
				:
					haptic == 1 ? "0.1 mi" : haptic == 2 ? "0.2 mi" : haptic == 5 ? "0.5 mi" : haptic == 10 ? "1.0 mi" : "");

	elm_object_text_set(vc->l5,"Voic");

	int speech = gps_get_speech();
	elm_object_text_set(vc->v5, speech == 0 ? "No" :
			metric ?
					speech == 5 ? "0.5 km" : speech == 10 ? "1.0 km" : speech == 20 ? "2.0 km" : ""
				:
					speech == 5 ? "0.5 mi" : speech == 10 ? "1.0 mi" : speech == 20 ? "2.0 mi" : ""
	);
	elm_object_text_set(vc->l6,"Strv");
	elm_object_text_set(vc->v6, oauth_access_token() ? "Logout" : "Login");

	uib_views_get_instance()->uib_views_current_view_redraw();
}
