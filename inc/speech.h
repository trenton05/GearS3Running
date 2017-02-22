#ifndef __SPEECH_H__
#define __SPEECH_H__

#include <app.h>

bool speech_init();
void speech_destroy();
bool speech_text(char* text);

#endif /* __SPEECH_H__ */

