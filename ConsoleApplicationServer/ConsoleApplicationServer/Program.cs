/*
 Student Name: Andrew Campbell
 Student ID: 18100767 
 
 Student Name: Kevin K. Kennedy
 Student ID: 26100087
 
 Course: Advanced Application Development (CPTR465)
 Instructor: Mr. Damion R. Mitchell (Assistant Professor, M.Sc.)
 University: Northern Caribbean University
 Department: Computer and Information Sciences
 Programming Assignment #:5
 Assignment Ojective: Threads and Socket Programming
 Due Date: Sunday, June 22, 2014 
 
 */




using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ConsoleApplicationServer
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateServer();

        }


        /*--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         Method Name: CreateServer()
         Description: This method creates a server by creating a TCP Listener at a specified port after which it waits until a socket is accepted (i.e. a client sends a message)
         (Arguments) -> return type:  () -> void
         Precondition: The port chosen as the listener is NOT blocked and is available
         Postcondition: A TCP Listener (server) will be established
        Example (s): A server is created to listen on port 8080 and the localhost is utilised as the IP Address (e.g ""127.0.0.1"")

         ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

        private static void CreateServer()
        {
            TcpListener TCP = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);


            Console.Title = "Advanced Application Development Server";

            Console.WriteLine(">> Advanced Application Development Server Started");

            TCP.Start();

            while (true)
            {


                Socket s = TCP.AcceptSocket();


                CHandle ClientInstance = new CHandle(s);

                Thread ClientThread = new Thread(new ThreadStart(ClientInstance.ClientConnection));

                ClientThread.Start();



            }//end while
        }
    }
}
