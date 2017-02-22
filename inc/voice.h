#ifndef __VOICE_H__
#define __VOICE_H__

#include <app.h>

bool voice_init();
void voice_destroy();

typedef void (*voice_cb)(const char* text);
void voice_listen(voice_cb cb);

#endif /* __VOICE_H__ */

