#include "app_main.h"
#include "gps.h"
#include "hrm.h"
#include "encode.h"
#include "speech.h"
#include "upload.h"

#include "g_inc_uib.h"
#include "uib_views.h"
#include "uib_app_manager.h"
#include "uib_view1_view.h"
#include <locations.h>
#include <bits/time.h>
#include <time.h>
#include <device/haptic.h>

#define HAPTIC_DURATION 500
#define HAPTIC_FEEDBACK 100

#define INTEGRAL_DIVISIONS 4
#define POSITION_UPDATE_INTERVAL 1
#define SAT_UPDATE_INTERVAL 5
#define UPDATE_TOL 1.0
#define ERR_FAC 1.0
#define ERR_INT 0.5
#define MIN_UPDATE 3
#define RAD_PER_DEG 3.14159265358979 / 180.0

typedef struct {
	double meters;
	double seconds;
	void* prev;
	void* next;
} location_inc;

typedef struct {
	double latitude;
	double longitude;
	double d_latitude;
	double d_longitude;
	
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

static location_summary* am_summary = NULL;
static location_summary* km_summary = NULL;
static location_summary* hm_summary = NULL;

#define TEXT_SIZE 10
static char* amText = NULL;
static char* hmText = NULL;
static char* kmText = NULL;
static char* aText = NULL;
static char* sText = NULL;
static char* mText = NULL;

static int locCount = 0;
static location_time* firstLoc = NULL;
static location_time* lastLoc = NULL;
static location_inc* firstInc = NULL;
static location_inc* lastInc = NULL;

static location_manager_h manager = NULL;

static double distance_exact(double lat1, double long1, double lat2, double long2);
static double distance(location_time* l1, location_time* l2);
static void __position_updated_cb(double latitude, double longitude, double altitude, time_t timestamp, void *data);
static void __satellite_updated_cb(int number_of_active, int number_inview, time_t timestamp, void *data);

static double lastErr = -1.0;
static double lastAlt = 0.0;

static bool metric = true;
static bool pace = true;
static bool speech = true;
static bool haptic = true;
static haptic_device_h haptic_h;

bool gps_has_signal() {
	return lastErr >= 0.0;
}

bool gps_get_metric() {
	return metric;
}

void gps_set_metric(bool val) {
	metric = val;
}

bool gps_get_pace() {
	return pace;
}

void gps_set_pace(bool val) {
	pace = val;
}

bool gps_get_haptic() {
	return haptic;
}

void gps_set_haptic(bool val) {
	haptic = val;
}

bool gps_get_speech() {
	return speech;
}

void gps_set_speech(bool val) {
	speech = val;
}

static location_summary* init_summary() {
	location_summary* l = malloc(sizeof(location_summary));
	l->meters = 0.0;
	l->seconds = 0.0;
	l->location = NULL;
	return l;
}

static void update_summary(location_summary* summary, location_inc* location, double meterTarget, double secondTarget) {
	if (summary->location == NULL) {
		summary->location = location;
	}
	summary->meters += location->meters;
	summary->seconds += location->seconds;

	while (summary->location != NULL &&
			((meterTarget >= 0.0 && summary->meters > meterTarget && summary->meters - summary->location->meters > 1.0)
			|| (secondTarget >= 0.0 && summary->seconds > secondTarget && summary->seconds - summary->location->seconds > 1.0))) {
		summary->meters -= summary->location->meters;
		summary->seconds -= summary->location->seconds;
		summary->location = summary->location->next;
	}
}

static void get_speed(char* chs, double meters, double seconds) {
	int index = 9;
	chs[index--] = 0;
	chs[index--] = 'h';
	chs[index--] = 'p';
	chs[index--] = metric ? 'k' : 'm';
	int i = seconds >= 0.1 ? (int)(meters / seconds * (metric ? 3600.0/1000.0 * 100.0 : 3600.0/1600.0 * 100.0) + 0.5) : 0.0;
	chs[index--] = '0' + (i % 10);
	chs[index--] = '0' + (i % 10);
	i /= 10;
	chs[index--] = '.';
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

static void get_meters(char* chs, double meters, double seconds, double target) {
	if (!metric) {
		meters *= 3.28084;
	}

	int index = 9;
	chs[index--] = 0;
	chs[index--] = metric ? 'm' : 'f';
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

static void get_kilometers(char* chs, double meters) {

	int index = 9;
	chs[index--] = 0;
	chs[index--] = metric ? 'm' : 'i';
	chs[index--] = metric ? 'k' : 'm';
	int i = (int)(meters * (metric ? 100.0/1000.0 : 100.0/1600.0) + 0.5);
	chs[index--] = '0' + (i % 10);
	i /= 10;
	chs[index--] = '0' + (i % 10);
	i /= 10;
	chs[index--] = '.';
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

static void get_time(char* chs, double seconds, double meters, double target) {
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

static void get_speech_kilometers(char* chs, double meters) {
	double km = metric ? meters / 1000.0 : meters / 1600.0;
	int tenths = (int)(km * 10.0) % 10;
	int whole = (int) km;

	sprintf(chs, metric ? "%d.%d kilometers " : "%d.%d miles ", whole, tenths);
}

static void get_speech_time(char* chs, double seconds, double meters, double target) {
	int i = meters >= 1.0 && target >= 1.0 ? (int)(seconds * target / meters + 0.5) : (int)(seconds + 0.5);
	int s = i % 60;
	int m = (i / 60) % 60;
	int h = i / 3600;

	if (h > 0) {
		sprintf(chs, "%d hours %d minutes %d seconds ", h, m, s);
	} else if (m > 0) {
		sprintf(chs, "%d minutes %d seconds ", m, s);
	} else {
		sprintf(chs, "%d seconds ", s);
	}
}

static bool running = false;
void gps_toggle_label() {
	pace = !pace;
	gps_update();
}

bool gps_is_running() {
	return running;
}

void gps_toggle_running() {
	running = !running;

	if (!running) {

		while (firstLoc != NULL) {
			location_time* next = firstLoc->next;
			free(firstLoc);
			firstLoc = next;
		}
		lastLoc = NULL;

		dlog_print(DLOG_DEBUG, LOG_TAG, "Pausing fit");
		pause_fit();
	} else {
		dlog_print(DLOG_DEBUG, LOG_TAG, "Resuming fit");
		resume_fit();
	}

	gps_update();
}

static void update_error() {

	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	int i = (int) (lastErr * (metric ? 1.0 : 3.28084) + 0.5);
	if (i > 99) i = 99;

	char err[4];
	err[3] = 0;
	err[2] = metric ? 'm' : 'f';
	err[1] = '0' + (i % 10);
	err[0] = i < 10 ? ' ' : '0' + (i / 10);
	elm_object_text_set(vc->erv, err);

	uib_views_get_instance()->uib_views_current_view_redraw();

}

void gps_update(){
	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	elm_object_text_set(vc->l1, metric ? "*km" : "*mi");
	elm_object_text_set(vc->l2, metric ? "km" : "mi");
	elm_object_text_set(vc->l3, metric ? ".1km" : ".1mi");

	if (running) {
		elm_object_text_set(vc->topLabel, "Pause");
		elm_object_text_set(vc->bottomLabel, "");
	} else {
		elm_object_text_set(vc->topLabel, "Resume");
		elm_object_text_set(vc->bottomLabel, "Exit");
	}

	if (pace) {
		get_time(amText, am_summary->seconds, am_summary->meters, metric ? 1000.0 : 1600.0);
		get_time(kmText, km_summary->seconds, km_summary->meters, metric ? 1000.0 : 1600.0);
		get_time(hmText, hm_summary->seconds, hm_summary->meters, metric ? 1000.0 : 1600.0);

	} else {
		get_speed(amText, am_summary->meters, am_summary->seconds);
		get_speed(kmText, km_summary->meters, km_summary->seconds);
		get_speed(hmText, hm_summary->meters, hm_summary->seconds);

	}

	get_meters(aText, lastAlt, -1.0, -1.0);
	get_kilometers(mText, am_summary->meters);
	get_time(sText, am_summary->seconds, -1.0, -1.0);

	elm_object_text_set(vc->l4,"dis");
	elm_object_text_set(vc->l5,"tim");
	elm_object_text_set(vc->l6,"ele");
	elm_object_text_set(vc->v4,mText);
	elm_object_text_set(vc->v5,sText);
	elm_object_text_set(vc->v6,aText);


	elm_object_text_set(vc->v1,amText);
	elm_object_text_set(vc->v2,kmText);
	elm_object_text_set(vc->v3,hmText);

	uib_views_get_instance()->uib_views_current_view_redraw();
}

bool gps_init(){

	if (0 != device_haptic_open(0, &haptic_h)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to open haptic");
		haptic_h = NULL;
	}

	amText = malloc(TEXT_SIZE);
	kmText = malloc(TEXT_SIZE);
	hmText = malloc(TEXT_SIZE);
	mText = malloc(TEXT_SIZE);
	sText = malloc(TEXT_SIZE);
	aText = malloc(TEXT_SIZE);

	am_summary = init_summary();
	hm_summary = init_summary();
	km_summary = init_summary();

	/* Create location manager handle */
	if (location_manager_create(LOCATIONS_METHOD_GPS, &manager) != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create location manager");
		return false;
	}

	location_error_e pos_cb;


	if ((pos_cb = location_manager_set_position_updated_cb(manager, __position_updated_cb, POSITION_UPDATE_INTERVAL, NULL)) != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to register callback %d", pos_cb);
		return false;
	}

	/* Start location service */
	if ((pos_cb = gps_status_set_satellite_updated_cb(manager, __satellite_updated_cb, SAT_UPDATE_INTERVAL, NULL)) != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_WARN, LOG_TAG, "Failed to register satellites %d", pos_cb);
	}

	/* Start location service */
	if ((pos_cb = location_manager_start(manager)) != LOCATIONS_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to start manager %d", pos_cb);
		return false;
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "Started location services");
	return true;

}

void gps_destroy() {
	device_haptic_close(haptic_h);

	location_manager_unset_position_updated_cb(manager);
	gps_status_unset_satellite_updated_cb(manager);
	location_manager_stop(manager);
	location_manager_destroy(manager);
}

/*
static double distance_est(double lat1, double long1, double lat2, double long2) {
	
	double r = 6371e3;
	double dlat = (lat2 - lat1) * RAD_PER_DEG;
	double dlong = (long2 - long1) * RAD_PER_DEG;
	double longRatio = cos(lat1 * RAD_PER_DEG)*cos(lat2 * RAD_PER_DEG);
	
	return sqrt(dlat*dlat + dlong*dlong * longRatio)*r;
}
*/

static double distance_exact(double lat1, double long1, double lat2, double long2) {
	//double d;
	//location_manager_get_distance(lat1, long1, lat2, long2, &d);
	//return d;
	double r = 6371e3;
	double phi1 = lat1 * RAD_PER_DEG;
	double phi2 = lat2 * RAD_PER_DEG;
	double dp = phi2 - phi1;
	double dl = (long2 - long1) * RAD_PER_DEG;

	double sdp = sin(dp/2.0);
	double sdl = sin(dl/2.0);
	double a = sdp*sdp + cos(phi1)*cos(phi2) * sdl*sdl;
	double c = 2.0 * atan2(sqrt(a), sqrt(1-a));

	return r * c;
}

static double distance(location_time* l1, location_time* l2) {
	return distance_exact(l1->latitude, l1->longitude, l2->latitude, l2->longitude);
}

static double intersect(location_time* l1, location_time* l2, location_time* ll) {
	
	
	double dtl = ll->time - l1->time;
	double dt2 = l2->time - l1->time;
	
	// Find acceleration to get from 1 to 3 with constant acceleration, stop at time 2 for point 2
	// ll->latitude = l1->latitude + l1->d_latitude * dtl + 0.5 * alat * dtl * dtl;
	double alat = 2.0*(ll->latitude - l1->latitude - l1->d_latitude * dtl) / (dtl * dtl);
	double along = 2.0*(ll->longitude - l1->longitude - l1->d_longitude * dtl) / (dtl * dtl);
	
	double nlat = l1->latitude + l1->d_latitude * dt2 + 0.5 * alat * dt2 * dt2;
	double nlong = l1->longitude + l1->d_longitude * dt2 + 0.5 * along * dt2 * dt2;
	/*
	double longRatio = cos(l1->latitude * RAD_PER_DEG);
	
	double nlat = l1->latitude;
	double nlong = l1->longitude;
	
	double dlat = ll->latitude - l1->latitude;
	double dlong = ll->longitude - l1->longitude;
	double dn2 = (dlat*dlat + dlong*dlong*longRatio*longRatio);

	double t = ((l2->latitude - l1->latitude) * dlat + (l2->longitude - l1->longitude) * dlong*longRatio*longRatio);

	if (t > 0 && dn2 != 0.0) {
		nlat += dlat * t / dn2;
		nlong += dlong * t / dn2;
	}
	*/
	
	
	// If new point is not within l2 error radius, push it to edge of it
	double dist = distance_exact(nlat, nlong, l2->latitude, l2->longitude);
	if (dist > l2->err && l2->err > 0.01) {
		nlat = l2->latitude + (nlat - l2->latitude) * l2->err / dist;
		nlong = l2->longitude + (nlong - l2->longitude) * l2->err / dist;
	}

	double ndist1 = distance_exact(nlat, nlong, l1->latitude, l1->longitude);
	double ndist2 = distance_exact(nlat, nlong, l2->latitude, l2->longitude);

	l2->latitude = nlat;
	l2->longitude = nlong;

	// If there is error in l1 (start of tracking only), push it to edge to ignore it
	if (l1->err > 0.01 && ndist1 > 0.01) {
		double d1 = l1->err > ndist1 ? ndist1 : l1->err;
		l1->latitude = l1->latitude + (nlat - l1->latitude) * d1 / ndist1;
		l1->longitude = l1->longitude + (nlong - l1->longitude) * d1 / ndist1;
	}

	// Update l2 error based on min of errors of new position from original positions --
	double nerr1 = l1->err - ndist1;
	double nerr2 = l2->err - ndist2;
	if (nerr1 < 0.0) nerr1 = 0.0;
	if (nerr2 < 0.0) nerr2 = 0.0;
	l2->err = nerr2 > nerr1 ? nerr1 : nerr2;

	// Update velocity at point based on acceleration from point 1 to 3 at time 2
	alat = 2.0*(l2->latitude - l1->latitude - l1->d_latitude * dt2) / (dt2 * dt2);
	along = 2.0*(l2->longitude - l1->longitude - l1->d_longitude * dt2) / (dt2 * dt2);
	l2->d_latitude = l1->d_latitude + alat * dt2;
	l2->d_longitude = l1->d_longitude + along * dt2;
	
	if (ndist1 - l1->err < 0.01) {
		return 0.0;
	}

	double clat = l1->latitude;
	double clong = l1->longitude;
	double ct = l1->time;
	double dlat = l1->d_latitude;
	double dlong = l1->d_longitude;
	double dt = dt2 / INTEGRAL_DIVISIONS;
	double distf = 0.0;

	for (int i=0; i<INTEGRAL_DIVISIONS; i++) {
		encode_fit(clat, clong, l1->altitude, l1->heart_rate, ct);

		double ulat = clat + dlat * dt + 0.5 * alat * dt * dt;
		double ulong = clong + dlong * dt + 0.5 * along * dt * dt;

		distf += distance_exact(clat, clong, ulat, ulong);

		clat = ulat;
		clong = ulong;
		ct += dt;
		dlat += alat * dt;
		dlong += along * dt;
	}

	return distf;
}

void update_speech() {
	char buf[255];

	sprintf(buf, "distance ");
	get_speech_kilometers(buf + strlen(buf), am_summary->meters);
	sprintf(buf + strlen(buf), "duration ");
	get_speech_time(buf + strlen(buf), am_summary->seconds, -1.0, -1.0);
	sprintf(buf + strlen(buf), metric ? "last kilometer " : "last mile ");
	get_speech_time(buf + strlen(buf), km_summary->seconds, km_summary->meters, metric ? 1000.0 : 1600.0);
	speech_text(buf);
}

static void update_increment() {
	location_time* nextLoc = firstLoc->next;
	
	double dist = intersect(firstLoc, nextLoc, lastLoc);
	double time = nextLoc->time - firstLoc->time;

	if (dist >= 0.01) {
		location_inc* inc = malloc(sizeof(location_inc));
		inc->meters = dist;
		inc->seconds = time;

	//	dlog_print(DLOG_DEBUG, LOG_TAG, "New increment: %f, %f", inc->meters, inc->seconds);



		inc->next = NULL;

		if (lastInc == NULL) {
			firstInc = inc;
			inc->prev = NULL;
		} else {
			inc->prev = lastInc;
			lastInc->next = inc;
		}

		lastInc = inc;

		int lastTotal = (int)(am_summary->meters * (metric ? 10.0/1000.0 : 10.0/1600.0));

		update_summary(am_summary, inc, -1, -1);
		update_summary(hm_summary, inc, metric ? 100 : 160, -1);
		update_summary(km_summary, inc, metric ? 1000 : 1600, -1);

		int newTotal = (int)(am_summary->meters * (metric ? 10.0/1000.0 : 10.0/1600.0));

		while (firstInc != hm_summary->location && firstInc != km_summary->location
				&& firstInc != lastInc) {
			location_inc* next = firstInc->next;
			next->prev = NULL;
			free(firstInc);
			firstInc = next;
		}

		gps_update();

		if (newTotal != lastTotal) {
			if (newTotal / 5 != lastTotal / 5 && speech) {
				update_speech();
			} else if (haptic && haptic_h) {
				dlog_print(DLOG_DEBUG, LOG_TAG, "Doing haptic");

				haptic_effect_h effect;
				device_haptic_vibrate(haptic_h, HAPTIC_DURATION, HAPTIC_FEEDBACK, &effect);
			}
		}
	}
	
	nextLoc->prev = NULL;
	free(firstLoc);
	firstLoc = nextLoc;
	locCount--;	
}

static void __satellite_updated_cb(int num_of_active, int num_of_inview, time_t timestamp, void *user_data) {
	dlog_print(DLOG_DEBUG, LOG_TAG, "Satellite: %d, %d", num_of_active, num_of_inview);
}

static void
__position_updated_cb(double latitude, double longitude, double altitude, time_t timestamp, void *data)
{
	double hor;
	double vert;
	location_accuracy_level_e level;
	location_manager_get_last_accuracy(manager, &level, &hor, &vert);

    struct timespec now;
    clock_gettime(CLOCK_REALTIME, &now);

    double time = now.tv_sec + 1e-9*now.tv_nsec;
	
	//encode_fit_raw(latitude, longitude, altitude, (int) hor, time);
		
	dlog_print(DLOG_DEBUG, LOG_TAG, "Location: %f, %f, %f, %f, %f", latitude, longitude, altitude, hor, vert);
	if (lastLoc != NULL &&
			lastLoc->latitude == latitude &&
			lastLoc->longitude == longitude &&
			lastLoc->altitude == altitude) {
		return;
	}

	lastAlt = altitude;

	lastErr = hor;
	update_error();
	update_settings();

	if (!running) {
		return;
	}

	location_time* loc = malloc(sizeof(location_time));
	loc->latitude = latitude;
	loc->longitude = longitude;
	loc->d_latitude = 0.0;
	loc->d_longitude = 0.0;
	loc->altitude = altitude;
	loc->heart_rate = get_last_hr();
	loc->time = time;

	loc->err = hor * ERR_FAC;

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

//	dlog_print(DLOG_DEBUG, LOG_TAG, "New location: %f, %f, %f, %d", latitude, longitude, distance(firstLoc, lastLoc), distCount);
//	dlog_print(DLOG_DEBUG, LOG_TAG, "Times: %f, %d", loc->time, timestamp);
//	dlog_print(DLOG_DEBUG, LOG_TAG, "Old location: %f, %f, %d, %f, %d", firstLoc->latitude, firstLoc->longitude);

	while (locCount >= MIN_UPDATE &&
			(distance(firstLoc, lastLoc) >= UPDATE_TOL + (firstLoc->err + lastLoc->err)*ERR_INT)) {
		update_increment();
	}
}
