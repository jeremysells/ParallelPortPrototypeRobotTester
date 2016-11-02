# ParallelPortPrototypeRobotTester
Parallel Port - Prototype Robot Tester - Written in C#

# WARNING
Note: This code is for an example only, do not run unless you know what you are doing as this writes digitally out of the parallel port using PWM (Pulse Width Modulation),
which means it could damage any printers/devices you have connected to your parallel port!

# LICENSE
Copyright (c) 2009 Jeremy Sells
See the file LICENSE for copying permission.

# ABOUT
WARNING: Compiling and running this code may damage devices connected to your computer especially connected through the parallel port!

This was written as a prototype for testing a robot I made and I needed some way to test the h-bridge.
I did research on the web for some way of communicating out of a PC using I/O pins and found out the the parallel port has 8 data pins I could use.
Then I found a DLL file and some example code (Sorry I do not remember the source address) to sent integers out of the 8 digital I/O pins.
What I did next was to build the following application quickly to test my circuits. Unfortunately I found the parallel port is too slow to do PWM effectively.
This was pre Raspberry PI and Arduino times!