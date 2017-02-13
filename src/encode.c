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

#include "encode.h"
#include "fit/fit_product.h"
#include "fit/fit_crc.h"

///////////////////////////////////////////////////////////////////////
// Private Function Prototypes
///////////////////////////////////////////////////////////////////////

void WriteFileHeader(FILE *fp);
///////////////////////////////////////////////////////////////////////
// Creates a FIT file. Puts a place-holder for the file header on top of the file.
///////////////////////////////////////////////////////////////////////

void WriteMessageDefinition(FIT_UINT8 local_mesg_number, const void *mesg_def_pointer, FIT_UINT8 mesg_def_size, FILE *fp);
///////////////////////////////////////////////////////////////////////
// Appends a FIT message definition (including the definition header) to the end of a file.
///////////////////////////////////////////////////////////////////////

void WriteMessageDefinitionWithDevFields
   (
   FIT_UINT8 local_mesg_number,
   const void *mesg_def_pointer,
   FIT_UINT8 mesg_def_size,
   FIT_UINT8 number_dev_fields,
   FIT_DEV_FIELD_DEF *dev_field_definitions,
   FILE *fp
   );
///////////////////////////////////////////////////////////////////////
// Appends a FIT message definition (including the definition header)
// and additionalo dev field definition data to the end of a file.
///////////////////////////////////////////////////////////////////////

void WriteMessage(FIT_UINT8 local_mesg_number, const void *mesg_pointer, FIT_UINT8 mesg_size, FILE *fp);
///////////////////////////////////////////////////////////////////////
// Appends a FIT message (including the message header) to the end of a file.
///////////////////////////////////////////////////////////////////////

void WriteDeveloperField(const void* data, FIT_UINT8 data_size, FILE *fp);
///////////////////////////////////////////////////////////////////////
// Appends Developer Fields to a Message
///////////////////////////////////////////////////////////////////////

void WriteData(const void *data, FIT_UINT8 data_size, FILE *fp);
///////////////////////////////////////////////////////////////////////
// Writes data to the file and updates the data CRC.
///////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////
// Private Variables
///////////////////////////////////////////////////////////////////////

static FIT_UINT16 data_crc;
static FILE* fp;
static char* file;

char* get_fit() {
	return file;
}

void start_fit(char* name) {
	file = name;

	   data_crc = 0;
	   fp = fopen(file, "w+b");

	   WriteFileHeader(fp);

		FIT_UINT8 local_mesg_number = 0;

		WriteMessageDefinition(local_mesg_number, fit_mesg_defs[FIT_MESG_RECORD], FIT_RECORD_MESG_DEF_SIZE, fp);

}

void stop_fit() {

	   // Write CRC.
	   fwrite(&data_crc, 1, sizeof(FIT_UINT16), fp);

	   // Update file header with data size.
	   WriteFileHeader(fp);

	   fclose(fp);
}

void encode_fit(double latitude, double longitude, double altitude, int heart_rate, double time)
{
	FIT_UINT8 local_mesg_number = 0;

   // Write a Field Description
	FIT_RECORD_MESG record_mesg;
	Fit_InitMesg(fit_mesg_defs[FIT_MESG_RECORD], &record_mesg);
	record_mesg.timestamp = (int) time;
	record_mesg.position_lat = (int) (latitude * 2147483648.0 / 180.0);
	record_mesg.position_long = (int) (longitude * 2147483648.0 / 180.0);
	record_mesg.heart_rate = heart_rate;
	record_mesg.altitude = (int)(5.0 * altitude + 500.0);
	WriteMessage(local_mesg_number, &record_mesg, FIT_RECORD_MESG_SIZE, fp);

}

void WriteFileHeader(FILE *fp)
{
   FIT_FILE_HDR file_header;

   file_header.header_size = FIT_FILE_HDR_SIZE;
   file_header.profile_version = FIT_PROFILE_VERSION;
   file_header.protocol_version = FIT_PROTOCOL_VERSION_20;
   memcpy((FIT_UINT8 *)&file_header.data_type, ".FIT", 4);
   fseek (fp , 0 , SEEK_END);
   file_header.data_size = ftell(fp) - FIT_FILE_HDR_SIZE - sizeof(FIT_UINT16);
   file_header.crc = FitCRC_Calc16(&file_header, FIT_STRUCT_OFFSET(crc, FIT_FILE_HDR));

   fseek (fp , 0 , SEEK_SET);
   fwrite((void *)&file_header, 1, FIT_FILE_HDR_SIZE, fp);
}

void WriteMessageDefinition(FIT_UINT8 local_mesg_number, const void *mesg_def_pointer, FIT_UINT8 mesg_def_size, FILE *fp)
{
   FIT_UINT8 header = local_mesg_number | FIT_HDR_TYPE_DEF_BIT;
   WriteData(&header, FIT_HDR_SIZE, fp);
   WriteData(mesg_def_pointer, mesg_def_size, fp);
}

void WriteMessageDefinitionWithDevFields
   (
   FIT_UINT8 local_mesg_number,
   const void *mesg_def_pointer,
   FIT_UINT8 mesg_def_size,
   FIT_UINT8 number_dev_fields,
   FIT_DEV_FIELD_DEF *dev_field_definitions,
   FILE *fp
   )
{
   FIT_UINT16 i;
   FIT_UINT8 header = local_mesg_number | FIT_HDR_TYPE_DEF_BIT | FIT_HDR_DEV_DATA_BIT;
   WriteData(&header, FIT_HDR_SIZE, fp);
   WriteData(mesg_def_pointer, mesg_def_size, fp);

   WriteData(&number_dev_fields, sizeof(FIT_UINT8), fp);
   for (i = 0; i < number_dev_fields; i++)
   {
      WriteData(&dev_field_definitions[i], sizeof(FIT_DEV_FIELD_DEF), fp);
   }
}

void WriteMessage(FIT_UINT8 local_mesg_number, const void *mesg_pointer, FIT_UINT8 mesg_size, FILE *fp)
{
   WriteData(&local_mesg_number, FIT_HDR_SIZE, fp);
   WriteData(mesg_pointer, mesg_size, fp);
}

void WriteDeveloperField(const void *data, FIT_UINT8 data_size, FILE *fp)
{
   WriteData(data, data_size, fp);
}

void WriteData(const void *data, FIT_UINT8 data_size, FILE *fp)
{
   FIT_UINT8 offset;

   fwrite(data, 1, data_size, fp);

   for (offset = 0; offset < data_size; offset++)
      data_crc = FitCRC_Get16(data_crc, *((FIT_UINT8 *)data + offset));
}
