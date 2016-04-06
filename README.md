Buffer.cs
============

Implementation of a synchronous circular buffer. Producers and consumers run simultaneously in a number of threads provided by the user.

Info
------------

Remake of http://github.com/kevinvkpetersen/buffer/ in C# to practice for MCSD exam 70-483.

Inspiration
------------

Original project from UBC's EECE 315, Operating and File Systems.

Installation
------------

Windows (Visual Studio):

    cd {solution destination}
    git clone https://github.com/kevinvkpetersen/buffer.git

In Visual Studio, go to File > Open > Project/Solution... and navigate to the solution file. To build the project, go to Build > Build Solution; buffer.cs.exe will be in the bin/Debug folder.


Usage
------------

Run from the Command Prompt with execution time, number of producers and number of consumers. For example, on Windows:

    buffer.exe 5 4 3

To get Visual Studio to send command line arguments, right-click on the buffer.cs project and select Properties. Under Debug, in the "Command line arguments" text box, enter the execution time, number of producer threads, and number of consumer threads.

Copyright 2016, Kevin Petersen. All rights reserved.