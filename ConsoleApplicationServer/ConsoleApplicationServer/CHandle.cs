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
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Collections;

namespace ConsoleApplicationServer
{
    class CHandle
    {


        private Socket CurrentSocket = null;


        public CHandle(Socket AcceptedSocket)
        {
            CurrentSocket = AcceptedSocket;
        }


        /*--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Method Name: ClientConnection()
        Description: This method reads a message from a client and sends an appropriate message back to client base on the client 's intial message. In additon, this method also identify the clients that are started.
        (Arguments) -> return type:  () -> void
        Precondition: The client must be connected and a message is sent from the client to the server
        Postcondition: An appropriate response (message) is sent to the client after reading the client 's message
        Example (s): When the message (e.g. "MINUS") is read from the client the server will reply appropriate to the client 's message (The server will send the message "You want to Minus!")

        ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

        public void ClientConnection()
        {
            byte[] ByteRead = new byte[100];
            int ByteSize = CurrentSocket.Receive(ByteRead);


            String ClientMessage = "";

            for (int i = 0; i < ByteSize; i++)
                ClientMessage += Convert.ToChar(ByteRead[i]);

           // Console.WriteLine(">> Client No : ? started !" + CurrentSocket.RemoteEndPoint);



            if (ClientMessage == "1" || ClientMessage == "2" || ClientMessage == "3")
                Console.WriteLine(">> Client No : {0} started !", ClientMessage);

            
            
            if (ClientMessage != "1" && ClientMessage != "2" && ClientMessage != "3")
            { 


            Console.Write(">> From Client --> {0} ? MSG: ", ClientMessage[0]);

            ClientMessage = ClientMessage.Remove(0, 1);
            Console.WriteLine(ClientMessage);
   

            Hashtable ServerResponses = new Hashtable();

            ServerResponses.Add("ADD","You want to Add!!");
            ServerResponses.Add("MINUS", "You want to Minus");
            ServerResponses.Add("DIVIDE", "You want to Divide");



            String ServerMessage = "I don't Understand your request, \n Try Again";


            if (ServerResponses.ContainsKey(ClientMessage))
                ServerMessage = ServerResponses[ClientMessage].ToString();



            Byte[] msgToBeSent = ASCIIEncoding.ASCII.GetBytes(ServerMessage.ToCharArray());

           CurrentSocket.Send(msgToBeSent,msgToBeSent.Length,0);

            }//end

           


        }


        
    }
}
