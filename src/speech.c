#include "speech.h"
#include <tts.h>
#include "app_main.h"


static tts_h tts;
static char* language;
static int voice_type;
static tts_state_e state;

static void __tts_state_changed_cb(tts_h tts, tts_state_e previous, tts_state_e current, void* user_data) {
	state = current;
}

static void __tts_utterance_completed_cb(tts_h tts, int utt_id, void *user_data) {

}

bool speech_init() {
	if (0 != tts_create(&tts)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create tts");
		return false;
	}

	if (0 != tts_set_state_changed_cb(tts, __tts_state_changed_cb, NULL)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set state change tts");
		return false;
	}

	if (0 != tts_set_utterance_completed_cb(tts, __tts_utterance_completed_cb, NULL)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set state change tts");
		return false;
	}

	if (0 != tts_get_default_voice(tts, &language, &voice_type)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to get tts default voice");
		return false;
	}

	if (0 != tts_prepare(tts)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to prepare tts");
		return false;
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "Speech initialized");

	return true;
}

void speech_destroy() {
	tts_stop(tts);
	tts_unprepare(tts);
	tts_destroy(tts);
}

bool speech_text(char* text) {
	if (state == TTS_STATE_READY || state == TTS_STATE_PAUSED || state == TTS_STATE_PLAYING) {
		dlog_print(DLOG_DEBUG, LOG_TAG, "Playing text: %s", text);
		int utt_id;
		if (0 != tts_add_text(tts, text, language, voice_type, TTS_SPEED_AUTO, &utt_id)) {
			dlog_print(DLOG_ERROR, LOG_TAG, "Failed to add to tts queue");
			return false;
		}
		if (state != TTS_STATE_PLAYING && 0 != tts_play(tts)) {
			dlog_print(DLOG_ERROR, LOG_TAG, "Failed to play tts");
			return false;
		}
		return true;
	} else {
		dlog_print(DLOG_WARN, LOG_TAG, "Not playing tts because state is not ready");
		return false;
	}
}
