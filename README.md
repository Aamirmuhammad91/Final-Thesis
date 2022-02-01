# Final-Thesis

In this thesis, I have mainly discussed the use of Ultrasonic Sensor with an
intention to explore the possibility of object recognition. To be specific, developing a
system that can differentiate human from non-human objects, so-called box classifier,
and evaluating its performance. The main technologies in this work are ultrasonic
signal and features extracted from the FFT (Fast Fourier Transform) of the received
ultrasonic signal using C programming. 10 different features have been recorded for
the statistical analysis on basis of which decisions has been made to differentiate
between hard and soft object. For realization of object recognition and estimation of its
feasibility with these approaches, a hardware device called Red Pitaya has been used.
Red Pitaya is a hardware device consisting of a microprocessor and an ultrasonic
sensor. The device was employed to gather a set of numerical values converted from the
reflected analog signals of targeted objects. When it comes to software, a UDP client
which is developed in C# language is used extensively for the programming, analysis,
and control of Red Pitaya and SRF02 ultrasonic sensor. Open source GCC compiler is
incorporated, in addition to those other libraries are used to build an application for
the Autonomous Illumination Control System. To make changes in the Red Pitaya
software and SCP connection is established by means of WinSCP to navigate to the
folder of the program and in parallel for a shell connection like Putty has been
established to make the program and check for possible errors. Two LEDs are used
white LED for human and blue LED for other than human. To control the ON/OFF
functionality of the LEDs 2 Relays has been employed which work as push buttons,
which will turn ON and OFF the LED when the corresponding Relay is switched ON for
2 seconds. C as a programming language has been used to implement a methodology
for the classification. Lastly, for an approach to object recognition using these
technologies with high performance, this report discusses the encountered challenges
and possibilities for further research.
