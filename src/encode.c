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
static bool running = false;

char* get_fit() {
	return file;
}

void fit_init(char* name) {
	file = name;

	   fp = fopen(file, "w");

	   fputs("<?xml version=\"1.0\" encoding=\"UTF-8\"?>", fp);
	   fputs("<gpx creator=\"GearS3Running\" version=\"1.1\" xmlns=\"http://www.topografix.com/GPX/1/1\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd\">", fp);
	   fputs("<trk>", fp);

	started = true;
}

void resume_fit() {
	if (!started) return;

	if (!running) {
		running = true;
		fputs("<trkseg>", fp);
	}
}

void pause_fit() {
	if (!started) return;

	if (running) {
		running = false;
		fputs("</trkseg>", fp);
	}
}

void stop_fit() {
	started = false;

	fputs("</trkseg></trk></gpx>", fp);

	   fclose(fp);
}

void encode_fit(double latitude, double longitude, double altitude, int heart_rate, double time)
{
	if (!started) return;

	time_t now = (int) time;
    char buf[sizeof "2011-10-08T07:07:09Z"];
    strftime(buf, sizeof buf, "%FT%TZ", gmtime(&now));
	fprintf(fp, "<trkpt lat=\"%0.9f\" lon=\"%0.9f\">", latitude, longitude);
	if (heart_rate > 0) {
		fprintf(fp, "<hr>%d</hr>", heart_rate);
	}
	fprintf(fp, "<ele>%0.2f</ele><hr>%d</hr><time>%s</time></trkpt>", altitude, heart_rate, buf);

}
