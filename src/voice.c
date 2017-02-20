#include "voice.h"
#include <tts.h>

bool voice_init() {
	return true;
}

void voice_destroy() {

}

void voice_listen(voice_cb cb) {
	cb("Haha you thought this did something");
}
