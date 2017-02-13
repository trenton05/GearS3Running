#ifndef __ENCODE_H__
#define __ENCODE_H__

#include "gps.h"

char* get_fit();
void start_fit(char* file);
void encode_fit(double latitude, double longitude, double altitude, int heart_rate, double time);
void stop_fit();

#endif /* __ENCODE_H__ */

