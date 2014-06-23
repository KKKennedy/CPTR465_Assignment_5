CPTR465_Assignment_5
====================
Northern Caribbean University
Department of Computer & Information Sciences
CPTR465-Advanced Application Development
Assignment #5 (30pts / 10%)
Due Date: June 22, 2014 by 11:59PM

Instruction: Write the program for the problem below. This assignment must be submitted via http://lms.ncu.edu.jm. You will also be required to present this application at the start of class on Monday, June 23, 2014.

Additional Readings:
•	System.Net.Sockets
•	TcpListener
•	TcpClient
•	NetworkStream
•	Threads in C#.NET

Threads and Socket Programming

Overview
You have been hired to build a simple multithreaded Client/Server application. You are required to have three (3) clients connect to one server. You were told that with multithreaded socket programming, when a server gets a connection request from the client side, the server will create a separate client thread in the server side for communication to take place with that particular client socket. This means that for every client socket, there will be a separate client thread in the server side for independent communication.

The figure below shows a sample design of the system you will be implementing.





Requirements
1.	Build a console application that will handle the operations of the server as shown below. This application will receive requests, and send appropriate messages to the requested client. 
2.	Build a Windows Form Application as shown below, that should start three (3) instances of the client. Please note that the client can send three types of messages for which the server should respond to accordingly. Example, ADD, MINUS, and DIVIDE. If any other messages are sent the server should inform the client that it does not understand. 
 Initial Run of both applications





All three (3) clients connected




Client #1 sends an unknown message to server 
 
Client #1 Sends an ADD message, Client #2 a DIVIDE message, and Client #3 as MINUS. 



Deliverables
1.	Client project
2.	Server project

Rubric
Client properly implemented						5pts
Server properly implemented						10pts
Proper use of Threads							10pts
Comments								5pts
Total										30pts 



