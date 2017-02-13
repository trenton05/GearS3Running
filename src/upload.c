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
#include "upload.h"
#include "app_main.h"

#include <curl/curl.h>

bool upload_fit(char* file, char* token) {

	  CURL *curl;

	  struct curl_httppost *formpost=NULL;
	  struct curl_httppost *lastptr=NULL;
	  struct curl_slist *headerlist=NULL;
	  char buf[256];
	  strcpy(buf, "Authorization: Bearer ");
	  strcat(buf, token);

	  /* Fill in the file upload field. This makes libcurl load data from
	     the given file name when curl_easy_perform() is called. */
	  curl_formadd(&formpost,
	               &lastptr,
	               CURLFORM_COPYNAME, "file",
	               CURLFORM_FILE, file,
	               CURLFORM_END);

	  /* Fill in the filename field */
	  curl_formadd(&formpost,
	               &lastptr,
	               CURLFORM_COPYNAME, "activity_type",
	               CURLFORM_COPYCONTENTS, "run",
	               CURLFORM_END);

	  /* Fill in the submit field too, even if this is rarely needed */
	  curl_formadd(&formpost,
	               &lastptr,
	               CURLFORM_COPYNAME, "data_type",
	               CURLFORM_COPYCONTENTS, "fit",
	               CURLFORM_END);

	  curl = curl_easy_init();
	  /* initialize custom header list (stating that Expect: 100-continue is not
	     wanted */
	  headerlist = curl_slist_append(headerlist, buf);
	  if(curl) {
	    /* what URL that receives this POST */
	    curl_easy_setopt(curl, CURLOPT_URL, "https://www.strava.com/api/v3/uploads");
		/* only disable 100-continue header if explicitly requested */
		curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headerlist);
	    curl_easy_setopt(curl, CURLOPT_HTTPPOST, formpost);

	    /* Perform the request, res will get the return code */
	    CURLcode res = curl_easy_perform(curl);
	    /* Check for errors */
	    if(res != CURLE_OK) {
	      dlog_print(DLOG_ERROR, LOG_TAG, "curl_easy_perform() failed: %s\n",
	              curl_easy_strerror(res));
	      return false;
	    }

	    /* always cleanup */
	    curl_easy_cleanup(curl);

	    /* then cleanup the formpost chain */
	    curl_formfree(formpost);
	    /* free slist */
	    curl_slist_free_all(headerlist);
	    return true;
	  }
	  return false;
}
