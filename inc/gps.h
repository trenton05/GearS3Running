#ifndef __GPS_H__
#define __GPS_H__

#include <app.h>

bool gps_init();
void gps_destroy();
void gps_update();
void gps_toggle_running();
bool gps_is_running();
bool gps_get_metric();
void gps_set_metric(bool val);
bool gps_get_pace();
void gps_set_pace(bool val);
bool gps_has_signal();

bool gps_get_haptic();

void gps_set_haptic(bool val);

int gps_get_speech();

void gps_set_speech(int val);

void gps_update_speech();

#endif /* __GPS_H__ */

