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
static int haptic_every = 1;
static haptic_device_h haptic_h;
static int speech_every = 5;

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

int gps_get_haptic() {
	return haptic_every;
}

void gps_set_haptic(int val) {
	haptic_every = val;
}

int gps_get_speech() {
	return speech_every;
}

void gps_set_speech(int val) {
	speech_every = val;
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

static char* get_speed(char* chs, double meters, double seconds) {
	int i = seconds >= 0.1 ? (int)(meters / seconds * (metric ? 3600.0/1000.0 * 100.0 : 3600.0/1600.0 * 100.0) + 0.5) : 0.0;
	sprintf(chs, metric ? "<align=right>%d.%02dkpm</align>" : "<align=right>%d.%02dmph</align>", i / 100, i % 100);
	return chs;
}

static char* get_meters(char* chs, double meters, double seconds, double target) {
	if (!metric) {
		meters *= 3.28084;
	}

	int i = seconds >= 1.0 && target >= 1.0 ? (int)(meters * target / seconds + 0.5) : (int)(meters + 0.5);
	sprintf(chs, metric ? "<align=right>%dm</align>" : "<align=right>%df</align>", i);
	return chs;
}

static char* get_kilometers(char* chs, double meters) {

	int i = (int)(meters * (metric ? 100.0/1000.0 : 100.0/1600.0) + 0.5);
	sprintf(chs, metric ? "<align=right>%d.%02dkm</align>" : "<align=right>%d.%02dmi</align>", i / 100, i % 100);
	return chs;

}

static char* get_time(char* chs, double seconds, double meters, double target) {
	int i = meters >= 1.0 && target >= 1.0 ? (int)(seconds * target / meters + 0.5) : (int)(seconds + 0.5);
	int s = i % 60;
	int m = (i / 60) % 60;
	int h = i / 3600;

	sprintf(chs, "<align=right>%d:%02d:%02d</align>", h, m, s);
	return chs;
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

	char buf[16];
	sprintf(buf, metric ? "%dm" : "%df", i);
	elm_object_text_set(vc->erv, buf);

	uib_views_get_instance()->uib_views_current_view_redraw();

}

void gps_update(){
	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	elm_object_text_set(vc->l1, metric ? "*" : "*");
	elm_object_text_set(vc->l2, metric ? "km" : "mi");
	elm_object_text_set(vc->l3, "hm");

	if (running) {
		elm_object_text_set(vc->topLabel, "<align=center>Pause</align>");
		elm_object_text_set(vc->bottomLabel, "");
	} else {
		elm_object_text_set(vc->topLabel, "<align=center>Resume</align>");
		elm_object_text_set(vc->bottomLabel, "<align=center>Exit</align>");
	}

	char buf[64];
	if (pace) {
		elm_object_text_set(vc->v1, get_time(buf, am_summary->seconds, am_summary->meters, metric ? 1000.0 : 1600.0));
		elm_object_text_set(vc->v2, get_time(buf, km_summary->seconds, km_summary->meters, metric ? 1000.0 : 1600.0));
		elm_object_text_set(vc->v3, get_time(buf, hm_summary->seconds, hm_summary->meters, metric ? 1000.0 : 1600.0));

	} else {
		elm_object_text_set(vc->v1, get_speed(buf, am_summary->meters, am_summary->seconds));
		elm_object_text_set(vc->v2, get_speed(buf, km_summary->meters, km_summary->seconds));
		elm_object_text_set(vc->v3, get_speed(buf, hm_summary->meters, hm_summary->seconds));

	}

	elm_object_text_set(vc->v6, get_meters(buf, lastAlt, -1.0, -1.0));
	elm_object_text_set(vc->v4, get_kilometers(buf, am_summary->meters));
	elm_object_text_set(vc->v5, get_time(buf, am_summary->seconds, -1.0, -1.0));

	elm_object_text_set(vc->l4,"dis");
	elm_object_text_set(vc->l5,"tim");
	elm_object_text_set(vc->l6,"ele");

	uib_views_get_instance()->uib_views_current_view_redraw();
}

bool gps_init(){

	if (0 != device_haptic_open(0, &haptic_h)) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to open haptic");
		haptic_h = NULL;
	}

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

void gps_update_speech() {
	if (!speech_every) {
		return;
	}

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
		update_summary(hm_summary, inc, 100, -1);
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
			if (speech_every > 0 && newTotal / speech_every != lastTotal / speech_every) {
				gps_update_speech();
			}
			if (haptic_every > 0 && newTotal / haptic_every != lastTotal / haptic_every && haptic_h) {
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
	// dlog_print(DLOG_DEBUG, LOG_TAG, "Satellite: %d, %d", num_of_active, num_of_inview);
	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");

	if (num_of_inview > 99) num_of_inview = 99;

	char buf[3];
	buf[2] = 0;
	buf[1] = '0' + (num_of_inview % 10);
	buf[0] = num_of_inview < 10 ? ' ' : '0' + (num_of_inview / 10);
	elm_object_text_set(vc->satv, buf);

	uib_views_get_instance()->uib_views_current_view_redraw();
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
		
	//dlog_print(DLOG_DEBUG, LOG_TAG, "Location: %f, %f, %f, %f, %f", latitude, longitude, altitude, hor, vert);
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
