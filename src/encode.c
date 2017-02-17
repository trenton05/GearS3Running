////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2008-2015 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////

#define _CRT_SECURE_NO_WARNINGS

#include "stdio.h"
#include "string.h"
#include <time.h>
#include "encode.h"

static FILE* fp;
static char* file;
static bool started = false;
static bool written = false;
static bool running = false;

char* get_fit() {
	return file;
}

void start_fit(char* name) {
	file = name;

	started = true;
}

void resume_fit() {
}

void pause_fit() {
	if (!started) return;

	if (running) {
		running = false;

		fputs("</trkseg>", fp);
	}
}

void stop_fit() {
	pause_fit();

	started = false;

	if (written) {

		fputs("</trk></gpx>", fp);

		fclose(fp);
	}
}

void encode_fit(double latitude, double longitude, double altitude, int heart_rate, double time)
{
	if (!started) return;

	if (!written) {
		written = true;

	   fp = fopen(file, "w");

	   fputs("<?xml version=\"1.0\" encoding=\"UTF-8\"?>", fp);
	   fputs("<gpx creator=\"StravaGPX\" version=\"1.1\" xmlns=\"http://www.topografix.com/GPX/1/1\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd http://www.garmin.com/xmlschemas/GpxExtensions/v3 http://www.garmin.com/xmlschemas/GpxExtensionsv3.xsd http://www.garmin.com/xmlschemas/TrackPointExtension/v1 http://www.garmin.com/xmlschemas/TrackPointExtensionv1.xsd http://www.garmin.com/xmlschemas/GpxExtensions/v3 http://www.garmin.com/xmlschemas/GpxExtensionsv3.xsd http://www.garmin.com/xmlschemas/TrackPointExtension/v1 http://www.garmin.com/xmlschemas/TrackPointExtensionv1.xsd\" xmlns:gpxtpx=\"http://www.garmin.com/xmlschemas/TrackPointExtension/v1\" xmlns:gpxx=\"http://www.garmin.com/xmlschemas/GpxExtensions/v3\">", fp);
	   fputs("<trk>", fp);
	}

	if (!running) {
		running = true;
		fputs("<trkseg>", fp);
	}

	time_t now = (int) time;
    char buf[sizeof "2011-10-08T07:07:09Z"];
    strftime(buf, sizeof buf, "%FT%TZ", gmtime(&now));
	fprintf(fp, "<trkpt lat=\"%0.9f\" lon=\"%0.9f\">", latitude, longitude);
	if (heart_rate > 0) {
		fprintf(fp, "<extensions><gpxtpx:TrackPointExtension><gpxtpx:hr>%d</gpxtpx:hr></gpxtpx:TrackPointExtension></extensions>", heart_rate);
	}
	fprintf(fp, "<ele>%0.2f</ele><time>%s</time></trkpt>", altitude, buf);

}
