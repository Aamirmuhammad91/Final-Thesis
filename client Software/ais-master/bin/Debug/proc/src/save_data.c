#include <arpa/inet.h>
#include <fcntl.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <errno.h>
#include <stdint.h>
#include <stdbool.h>
#include <sys/socket.h>
#include <sys/time.h>

#include "rp.h"
#include "udp_server.h"
#include "iic.h"



//********************************************
// private defines
//********************************************
#define SAVE_ROOT		"/root/iic/"			//  "/tmp/ram/"
#define SAVE_DATA		"%sdata_%02i.txt"


//********************************************
// extern variables
//********************************************



//********************************************
// local variables
//********************************************
static volatile uint16_t counter=0;
static const char root_folder[]=SAVE_ROOT;




//********************************************
// local function prototypes
//********************************************


//********************************************
// public functions
//********************************************
int save_data( char *p_data )
{
	FILE *file = NULL;
	char file_name[40];
	
	sprintf(file_name, SAVE_DATA, root_folder, (uint16_t)(counter++/600));
	
	
	if( (file = fopen(file_name,"a")) < 0 ){
		return(-1);
	}
	
	fprintf( file, "%s", p_data );
	
	fclose(file);
	
	return(0);
}



int save_data_binary( int16_t *p_data, uint16_t number )
{
	FILE *file = NULL;
	char file_name[40];
	
	sprintf(file_name, "%sadc_data_%02i.bin", root_folder, (uint16_t)(counter++/600));
	
	if( (file = fopen(file_name,"ab")) < 0 ){
		return(-1);
	}
	
	fwrite( p_data, (size_t)(sizeof(int16_t)), number, file);
	
	fclose(file);
	
	return(0);
}



int init_data( void )
{
	char file_name[40];
	for( uint8_t ix=0; ix<=100; ix++){
		sprintf(file_name, SAVE_DATA, root_folder, ix);
		if( remove( file_name ) < 0 ){
			return(0);
		}
	}
	counter=0;
	return(0);
}


//********************************************
// local functions
//********************************************




