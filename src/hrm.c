#include "app_main.h"
#include "hrm.h"

#include "g_inc_uib.h"
#include "uib_views.h"
#include "app_main.h"
#include "uib_app_manager.h"
#include "uib_view1_view.h"
#include <sensor.h>
#include <bits/time.h>
#include <time.h>

#define SENSOR_UPDATE_MS 1000

static int lastHrm = -1;
static sensor_h sensor;
static sensor_listener_h sensor_listener;

#define HRM_SIZE 4
static char* hrmText;

int get_last_hr() {
	return lastHrm;
}

void get_hb(char* chs, float val) {
	int index = 4;
	chs[index--] = 0;
	int i = (int)(val + 0.5);
	chs[index--] = '0' + (i % 10);
	i /= 10;

	while (i >= 1 && index >= 0) {
		chs[index--] = '0' + (i % 10);
		i /= 10;
	}
	while (index >= 0) {
		chs[index--] = ' ';
	}
}

void hrm_update(){
	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");


	get_hb(hrmText, lastHrm);

	elm_object_text_set(vc->hrv,hrmText);

	uib_views_get_instance()->uib_views_current_view_redraw();
}

static void __update_sensor(sensor_h s, sensor_event_s *event, void *data) {
	dlog_print(DLOG_DEBUG, LOG_TAG, "Heart: %f, %f, %f, %f", event->values[0], event->values[1], event->values[2], event->values[3]);
	if (event->value_count > 0 && event->values[0] > 0.5
			&& lastHrm >= 0) {
		dlog_print(DLOG_DEBUG, LOG_TAG, "Heart: %f", event->values[0]);
		int hrm = (int)(event->values[0] + 0.5);
		if (hrm != lastHrm) {
			lastHrm = hrm;
			hrm_update();
		}
	}
}

void __update_sensor_accuracy(sensor_h sensor, unsigned long long timestamp, sensor_data_accuracy_e accuracy, void *data) {
	if (accuracy == SENSOR_DATA_ACCURACY_UNDEFINED || accuracy == SENSOR_DATA_ACCURACY_BAD) {
		lastHrm = -1;
	} else {
		lastHrm = 0;
	}
}

bool hrm_init(){

	hrmText = malloc(HRM_SIZE);

	if (sensor_get_default_sensor(SENSOR_HRM, &sensor) != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to get hrm sensor");
		return false;
	}
	if (sensor_create_listener(sensor, &sensor_listener) != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create hrm listener");
		return false;
	}

	sensor_listener_set_option(sensor_listener, SENSOR_OPTION_ALWAYS_ON);

	sensor_listener_set_accuracy_cb(sensor_listener, __update_sensor_accuracy, NULL);

	if (sensor_listener_set_event_cb(sensor_listener, SENSOR_UPDATE_MS, __update_sensor, NULL) != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set hrm listener callback");
		return false;
	}
	if (sensor_listener_start(sensor_listener) != SENSOR_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to start hrm sensor");
		return false;
	}


	dlog_print(DLOG_DEBUG, LOG_TAG, "Started hrm");

	return true;
}

void hrm_alive() {
}

void hrm_destroy() {
	sensor_listener_stop(sensor_listener);
	sensor_listener_unset_event_cb(sensor_listener);
	sensor_listener_unset_accuracy_cb(sensor_listener);
	sensor_destroy_listener(sensor_listener);
}
