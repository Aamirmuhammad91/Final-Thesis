#ifndef __MAIN_H__
#define __MAIN_H__


#ifdef __cplusplus
extern "C" {
#endif


#define THREAD_PAUSE_MS				(100)													//     100 ms
#define THREAD_PAUSE_US				(THREAD_PAUSE_MS*1000)									// 100.000 µs = 100 ms (per cycle)




//********************************************
// global structs
//********************************************


//********************************************
// global variables
//********************************************
pthread_mutex_t				run_meas_mutex;
pthread_mutex_t				run_led_mutex;
pthread_cond_t				run_meas_cond;
pthread_cond_t				run_led_cond;



//********************************************
// global variables
//********************************************
void LedThread(void* threadid);
void StartLedThread(bool Param1, bool Param2);



#ifdef __cplusplus
}
#endif
#endif
