#ifndef __GPS_H__
#define __GPS_H__

#include <app.h>

bool gps_init();
void gps_destroy();
void gps_update();
void gps_toggle_label();
void gps_toggle_running();

#endif /* __GPS_H__ */

