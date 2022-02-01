
/* This code is sued for starting continous ranging on SRF02 sensor
 * 
 * (c) Red Pitaya  http://www.redpitaya.com
 *
 * This part of code is written in C programming language.
 * Please visit http://en.wikipedia.org/wiki/C_(programming_language)
 * for more details on the language used herein.
 */
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>
#include <syslog.h>
#include "rp.h"
#include "main.h"
#include "iic.h"
#include "udp_server.h"

// global defines
// Set the DIO pins direction to output
#define LightX()					rp_DpinSetDirection(RP_DIO2_P, RP_OUT),	\
									rp_DpinSetDirection(RP_DIO3_P, RP_OUT)

// For Switching the Relay ON and OFF
#define DIO3_P_ON					rp_DpinSetState( RP_DIO3_P, RP_HIGH )
#define DIO2_P_ON					rp_DpinSetState( RP_DIO2_P, RP_HIGH )
#define DIO3_P_OFF					rp_DpinSetState( RP_DIO3_P, RP_LOW )
#define DIO2_P_OFF					rp_DpinSetState( RP_DIO2_P, RP_LOW )




//********************************************
// local variables
//********************************************
static const uint32_t		thread_pause_us = THREAD_PAUSE_US;
static volatile bool		run_thread = true;
static volatile bool		blue_light, white_light;
bool current_blue = false;
bool current_white = false;


//********************************************
// function prototypes
//********************************************
void	TimeThread( void *threadid );



//********************************************
// process entry-point
//********************************************
int main(int argc, char **argv)
{
	pthread_t t_ServerThread, t_MeasureThread, t_TimeThread, t_LedThread;
	pthread_attr_t attr;
	void *th_status;
	
	// kill the parent-process
	// and fork the current execution to force a new PID and
	// start as a daemon
	daemon(0, 0);
	
	
	// start the udp server task in background!
	// set attribute for detaching status for each thread!
	pthread_attr_init( &attr );
	pthread_attr_setdetachstate( &attr, PTHREAD_CREATE_JOINABLE );
	
	
	// init all mutexes which are needed
	pthread_mutex_init( &run_meas_mutex, NULL );
	pthread_mutex_init(&run_led_mutex, NULL);
	pthread_cond_init( &run_meas_cond, NULL );
	pthread_cond_init( &run_led_cond, NULL);
	
	
	// create and start the threads
	pthread_create( &t_ServerThread,	&attr, (void *)&ServerThread,	NULL );
	pthread_create( &t_MeasureThread,	&attr, (void *)&MeasureThread,	NULL );
	pthread_create( &t_TimeThread,		&attr, (void *)&TimeThread,		NULL );
	pthread_create( &t_LedThread,		&attr, (void *)&LedThread, NULL);

	
	// free the attribute again
	pthread_attr_destroy( &attr );
	
	
	// wait for three threads to terminate
	// go into blocked mode
	pthread_join( t_ServerThread,	&th_status );
	pthread_join( t_MeasureThread,	&th_status );
	pthread_join( t_TimeThread,		&th_status );
	
	
	// end main as last thread!
	pthread_exit( NULL );
	return( EXIT_SUCCESS );
}



// ************************************************************ //
// ******************** Time thread **** ********************** //
// ************************************************************ //
void TimeThread( void *threadid )
{
	while( run_thread )
	{
		usleep( thread_pause_us );
		pthread_cond_signal(&run_meas_cond);
	}
}



void LedThread(void* threadid)
{
	
	while (1)
	{
		// stay in blocked mode from this point on and 
		//wait for any signal
		pthread_cond_wait(&run_led_cond, &run_led_mutex);

		//Initialize the DIO pins and set it to output
		LightX();

		// now we run, we can use for example usleep and
		//Switch the light ON and OFF
		if (current_white == true && white_light == false)
		{
			DIO2_P_ON;
			usleep(2000000);
			DIO2_P_OFF;
			current_white = false;
		}
		if (current_blue == true && blue_light == false)
		{
			DIO3_P_ON;
			usleep(2000000);
			DIO3_P_OFF;
			current_blue = false;
		}
		if (current_white == false && white_light == true)
		{
			DIO2_P_ON;
			usleep(2000000);
			DIO2_P_OFF;
			current_white = true;
		}
		if (current_blue == false && blue_light == true)
		{
			DIO3_P_ON;
			usleep(2000000);
			DIO3_P_OFF;
			current_blue = true;
		}
	}

	rp_Release();

	pthread_exit(NULL);

}



void StartLedThread(bool Param1, bool Param2)
{
	blue_light = Param1;
	white_light = Param2;
	pthread_cond_signal(&run_led_cond);
}
