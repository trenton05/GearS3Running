#include "voice.h"
#include <stt.h>
#include "app_main.h"

static stt_h stt;
static voice_cb callback;
static stt_state_e state;
static char* language;

void _state_changed_cb(stt_h stt, stt_state_e previous, stt_state_e current, void* user_data) {
	state = current;
}

void _recognition_result_cb(stt_h stt, stt_result_event_e event, const char** data, int data_count,
		  const char* msg, void *user_data) {
	if (data_count > 0) {
		dlog_print(DLOG_DEBUG, LOG_TAG, "Got speech %d, %s", data_count, data[0]);
		if (callback) {
			callback(data[0]);
		}
	} else {
		callback(NULL);
	}
}

void _error_cb(stt_h stt, stt_error_e reason, void *user_data) {
	dlog_print(DLOG_ERROR, LOG_TAG, "Failed to recognize speech %d", reason);
	if (callback) {
		callback(NULL);
	}
}

bool voice_init() {
	if (0 != stt_create(&stt)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create stt");
		return false;
	}
	if (0 != stt_set_state_changed_cb(stt, _state_changed_cb, NULL)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set stt state change cb");
		return false;
	}
	if (0 != stt_set_error_cb(stt, _error_cb, NULL)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set stt state change cb");
		return false;
	}
	if (0 != stt_set_recognition_result_cb(stt, _recognition_result_cb, NULL)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set stt state change cb");
		return false;
	}
	if (0 != stt_prepare(stt)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to prepare stt");
		return false;
	}
	if (0 != stt_set_silence_detection(stt, STT_OPTION_SILENCE_DETECTION_TRUE)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set stt silence detection");
	}
	if (0 != stt_get_default_language(stt, &language)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to get default language");
		return false;
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "Voice initialized");
	return true;
}

void voice_destroy() {
	stt_stop(stt);
	stt_unprepare(stt);
	stt_destroy(stt);
}

void voice_listen(voice_cb cb) {
	callback = cb;
	int resp = stt_start(stt, language, STT_RECOGNITION_TYPE_FREE);
	dlog_print(DLOG_DEBUG, LOG_TAG, "Voice started: %s, %d", language, resp);
}
