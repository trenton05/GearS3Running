#include "app_main.h"
#include "gps.h"
#include "hrm.h"
#include "encode.h"
#include "upload.h"

#include "g_inc_uib.h"
#include "uib_views.h"
#include "app_main.h"
#include "uib_app_manager.h"
#include "uib_view1_view.h"
#include <locations.h>
#include <bits/time.h>
#include <time.h>

#define POSITION_UPDATE_INTERVAL 1
#define UPDATE_TOL 10.0
#define ERROR_TOL 5.0
#define MIN_UPDATE 3
#define MAX_UPDATE 10

typedef struct {
	double meters;
	double seconds;
	void* prev;
	void* next;
} location_inc;

typedef struct {
	double latitude;
	double longitude;
	double altitude;
	int heart_rate;
	double time;
	double err;
	void* prev;
	void* next;
} location_time;

typedef struct {
	double meters;
	double seconds;
	location_inc* location;
} location_summary;

static location_summary* all_summary = NULL;
static location_summary* dkm_summary = NULL;
static location_summary* km_summary = NULL;
static location_summary* dm_summary = NULL;
static location_summary* m_summary = NULL;

#define TIME_SIZE 10
#define DIST_SIZE 10
static char* akmText = NULL;
static char* amText = NULL;
static char* dkmText = NULL;
static char* kmText = NULL;
static char* dmText = NULL;
static char* mText = NULL;

static int locCount = 0;
static int incCount = 0;
static location_time* firstLoc = NULL;
static location_time* lastLoc = NULL;
static location_inc* firstInc = NULL;
static location_inc* lastInc = NULL;
static location_manager_h manager = NULL;

static double distance_raw(double lat1, double long1, double lat2, double long2);
static double distance(location_time* l1, location_time* l2);
static void __position_updated_cb(double latitude, double longitude, double altitude, time_t timestamp, void *data);

location_summary* init_summary() {
	location_summary* l = malloc(sizeof(location_summary));
	l->meters = 0.0;
	l->seconds = 0.0;
	l->location = NULL;
	return l;
}

void update_summary(location_summary* summary, location_inc* location, double meterTarget, double secondTarget) {
	if (summary->location == NULL) {
		summary->location = location;
	}
	summary->meters += location->meters;
	summary->seconds += location->seconds;

	while (summary->location != NULL &&
			((meterTarget >= 0.0 && summary->meters > meterTarget)
			|| (secondTarget >= 0.0 && summary->seconds > secondTarget))) {
		summary->meters -= summary->location->meters;
		summary->seconds -= summary->location->seconds;
		summary->location = summary->location->next;
	}
}

void get_meters(char* chs, double meters, double seconds, double target) {
	int index = 8;
	chs[index--] = 0;
	chs[index--] = 'm';
	int i = seconds >= 1.0 && target >= 1.0 ? (int)(meters * target / seconds + 0.5) : (int)(meters + 0.5);
	chs[index--] = '0' + (i % 10);
	i /= 10;

	while (i >= 1 && index >= 0) {
		chs[index--] = '0' + (i % 10);
		i /= 10;
	}
	while (index >= 0) {
		chs[index--] = ' ';
	}
}

void get_time(char* chs, double seconds, double meters, double target) {
	int i = meters >= 1.0 && target >= 1.0 ? (int)(seconds * target / meters + 0.5) : (int)(seconds + 0.5);
	int s = i % 60;
	int m = (i / 60) % 60;
	int h = i / 3600;
	int index = 9;
	chs[index--] = 0;
	chs[index--] = '0' + (s % 10);
	chs[index--] = '0' + (s / 10);
	chs[index--] = ':';
	chs[index--] = '0' + (m % 10);
	chs[index--] = '0' + (m / 10);
	chs[index--] = ':';
	chs[index--] = '0' + (h % 10);
	h /= 10;

	while (h >= 1 && index >= 0) {
		chs[index--] = '0' + (h % 10);
		h /= 10;
	}
	while (index >= 0) {
		chs[index--] = ' ';
	}
}

void gps_update(){
	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");


	get_time(akmText, all_summary->seconds, -1.0, -1.0);
	get_time(dkmText, dkm_summary->seconds, dkm_summary->meters, 100.0);
	get_time(kmText, km_summary->seconds, km_summary->meters, 1000.0);
	get_meters(amText, all_summary->meters, -1.0, -1.0);
	get_meters(dmText, dm_summary->meters, dm_summary->seconds, 600.0);
	get_meters(mText, m_summary->meters, m_summary->seconds, 60.0);


	elm_object_text_set(vc->akml,akmText);
	elm_object_text_set(vc->dkml,dkmText);
	elm_object_text_set(vc->kml,kmText);
	elm_object_text_set(vc->aml,amText);
	elm_object_text_set(vc->dml,dmText);
	elm_object_text_set(vc->ml,mText);

	uib_views_get_instance()->uib_views_current_view_redraw();
}

bool gps_init(){

	time_t t;
	time(&t);

	char* file = malloc(64);
	sprintf(file, "/tmp/data%d.gpx", (int) t);
	start_fit(file);

	akmText = malloc(DIST_SIZE);
	amText = malloc(TIME_SIZE);
	dkmText = malloc(DIST_SIZE);
	kmText = malloc(DIST_SIZE);
	dmText = malloc(TIME_SIZE);
	mText = malloc(TIME_SIZE);

	all_summary = init_summary();
	dkm_summary = init_summary();
	km_summary = init_summary();
	dm_summary = init_summary();
	m_summary = init_summary();

	/* Create location manager handle */
	if (location_manager_create(LOCATIONS_METHOD_GPS, &manager) != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create location manager");
		return false;
	}

	/* Register callbacks for position and satellites data update */
	location_error_e pos_cb = location_manager_set_position_updated_cb(manager, __position_updated_cb, POSITION_UPDATE_INTERVAL, NULL);

	if (pos_cb != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to register callback %d", pos_cb);
		return false;
	}

	/* Start location service */
	if ((pos_cb = location_manager_start(manager)) != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to start manager %d", pos_cb);
		return false;
	}

//	dlog_print(DLOG_DEBUG, LOG_TAG, "Started location services");
	return true;

}

void gps_destroy() {
	location_manager_unset_position_updated_cb(manager);
	location_manager_stop(manager);
	location_manager_destroy(manager);
}

static double distance_raw(double lat1, double long1, double lat2, double long2) {
	double r = 6371e3;
	double phi1 = lat1 * 3.14159265358979 / 180.0;
	double phi2 = lat2 * 3.14159265358979 / 180.0;
	double dp = phi2 - phi1;
	double dl = (long2 - long1) * 3.14159265358979 / 180.0;

	double a = sin(dp/2.0) * sin(dp/2.0) +
	        cos(phi1) * cos(phi2) *
	        sin(dl/2.0) * sin(dl/2.0);
	double c = 2.0 * atan2(sqrt(a), sqrt(1-a));

	return r * c;
}


static double distance(location_time* l1, location_time* l2) {
	return distance_raw(l1->latitude, l1->longitude, l2->latitude, l2->longitude);
}

static double intersect(location_time* l1, location_time* l2, location_time* ll) {
	double dlat = ll->latitude - l1->latitude;
	double dlong = ll->longitude - l1->longitude;
	double dn2 = (dlat*dlat + dlong*dlong);

	double t = ((l2->latitude - l1->latitude) * dlat + (l2->longitude - l1->longitude) * dlong);
	double nlat = l1->latitude;
	double nlong = l1->longitude;

	if (t > 0 && dn2 != 0.0) {
		nlat += dlat * t / dn2;
		nlong += dlong * t / dn2;
	}
	double dist = distance_raw(nlat, nlong, l2->latitude, l2->longitude);
	if (dist > l2->err && l2->err > 0.1) {
		nlat = l2->latitude + (nlat - l2->latitude) * l2->err / dist;
		nlong = l2->longitude + (nlong - l2->longitude) * l2->err / dist;
	}

	double ndist1 = distance_raw(nlat, nlong, l1->latitude, l1->longitude);
	double ndist2 = distance_raw(nlat, nlong, l2->latitude, l2->longitude);

	l2->latitude = nlat;
	l2->longitude = nlong;

	double nerr1 = l1->err - ndist1;
	double nerr2 = l2->err - ndist2;
	if (nerr1 < 0.0) nerr1 = 0.0;
	if (nerr2 < 0.0) nerr2 = 0.0;
	l2->err = nerr2 > nerr1 ? nerr1 : nerr2;
	return ndist1 > l1->err ? ndist1 - l1->err : 0.0;
}

static void update_increment() {
	location_inc* inc = malloc(sizeof(location_inc));

	location_time* nextLoc = firstLoc->next;

	inc->meters = intersect(firstLoc, nextLoc, lastLoc);
	inc->seconds = nextLoc->time - firstLoc->time;

	dlog_print(DLOG_DEBUG, LOG_TAG, "New increment: %f, %f", inc->meters, inc->seconds);

	nextLoc->prev = NULL;
	free(firstLoc);
	firstLoc = nextLoc;
	locCount--;


	inc->next = NULL;

	if (lastInc == NULL) {
		firstInc = inc;
		inc->prev = NULL;
	} else {
		inc->prev = lastInc;
		lastInc->next = inc;
	}

	lastInc = inc;

	incCount++;

	update_summary(all_summary, inc, -1, -1);
	update_summary(dkm_summary, inc, 100, -1);
	update_summary(km_summary, inc, 1000, -1);
	update_summary(dm_summary, inc, -1, 600);
	update_summary(m_summary, inc, -1, 60);

//	while (firstInc != dkm_summary->location && firstInc != dm_summary->location
//			&& firstInc != lastInc) {
//		location_inc* next = firstInc->next;
//		next->prev = NULL;
//		free(firstInc);
//		firstInc = next;
//		incCount--;
//	}

	gps_update();
}

static void
__position_updated_cb(double latitude, double longitude, double altitude, time_t timestamp, void *data)
{
	if (lastLoc != NULL &&
			lastLoc->latitude == latitude &&
			lastLoc->longitude == longitude) {
		return;
	}

    struct timespec now;
    clock_gettime(CLOCK_REALTIME, &now);

    double time = now.tv_sec + 1e-9*now.tv_nsec;

	encode_fit(latitude, longitude, altitude, get_last_hr(), time);

	location_time* loc = malloc(sizeof(location_time));
	loc->latitude = latitude;
	loc->longitude = longitude;
	loc->altitude = altitude;
	loc->heart_rate = get_last_hr();
	loc->time = time;

	double hor;
	double vert;
	location_accuracy_level_e level;
	location_manager_get_last_accuracy(manager, &level, &hor, &vert);
	loc->err = hor;

	loc->next = NULL;

	if (lastLoc == NULL) {
		firstLoc = loc;
		loc->prev = NULL;
	} else {
		loc->prev = lastLoc;
		lastLoc->next = loc;
	}

	lastLoc = loc;

	locCount++;

	dlog_print(DLOG_DEBUG, LOG_TAG, "New location: %f, %f, %f, %d", latitude, longitude, distance(firstLoc, lastLoc), locCount);
	dlog_print(DLOG_DEBUG, LOG_TAG, "Times: %f, %d", loc->time, timestamp);
//	dlog_print(DLOG_DEBUG, LOG_TAG, "Old location: %f, %f, %d, %f, %d", firstLoc->latitude, firstLoc->longitude);

	while (locCount >= MIN_UPDATE &&
			(distance(firstLoc, lastLoc) >= UPDATE_TOL + firstLoc->err + lastLoc->err)) {
		update_increment();
	}
}
