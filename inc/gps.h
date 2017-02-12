#ifndef __GPS_H__
#define __GPS_H__

#include <app.h>

bool gps_init();
void gps_destroy();

typedef struct {
	double latitude;
	double longitude;
	double altitude;
	int heart_rate;
	double time;

	double meters;
	double seconds;
	void* prev;
	void* next;
} location_inc;

#endif /* __GPS_H__ */

