#ifndef __ENCODE_H__
#define __ENCODE_H__

#include "gps.h"

FILE* start_fit(char* file);
void encode_fit(FILE* fp, location_inc* inc);
void stop_fit(FILE* fp);

#endif /* __ENCODE_H__ */

