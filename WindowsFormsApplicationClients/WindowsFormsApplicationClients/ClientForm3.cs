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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationClients
{
    public partial class ClientForm3 : Form
    {


       
        public ClientForm3()
        {
            InitializeComponent();
        }

        private void ButtonSendData_Click(object sender, EventArgs e)
        {
            ClientWriteRead();
        }


        /*--------------------------------------------------------------------------------------------------------------------------
         Method Name: ClientWriteRead()
         Description: This method creates a client that is then connected to the server, after connecting to the server a message is sent from the client to the server, consequently this method also reads messages sent from the server/
         (Arguments) -> return type:  () -> void
         Precondition: The server must be online and there must be an available ports to accomodate communciation.
         Postcondition: A connection is established with the server. The client sent and recieve a message from the server.
         Example (s): After establishing a connection to the server immediately after the method is invoked, the client will sends a message (e.g. "ADD") to the server and the server will reply "You want to Add!"

         ----------------------------------------------------------------------------------------------------------------------- */
        private void ClientWriteRead()
        {
            try
            {
                TcpClient ThisClient = new TcpClient();

                ThisClient.Connect(IPAddress.Parse("127.0.0.1"), 8080);

                Stream stm = ThisClient.GetStream();

                String str = "3" + ComboBoxSendData.Text.ToString();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);


                stm.Write(ba, 0, ba.Length);

                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);

                String ClientMsg = "";

                for (int i = 0; i < k; i++)
                    ClientMsg += Convert.ToChar(bb[i]);

                TextBoxDialog.Text += Environment.NewLine + "Data from Server: Server Says to Client (3) " + ClientMsg;
                ThisClient.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Client Cannot Communciate With Server Due To A Blocked Port \nOR Connection Is NOT Established");

            }
        }

        private void ClientForm3_Load(object sender, EventArgs e)
        {
            StartClient();
        }

        /*--------------------------------------------------------------------------------------------------------------------------
        Method Name: StartClient()
        Description: This method creates a client and sends a client number to the server as means of letting the user know which client has started via the server console application
        (Arguments) -> return type:  () -> void
        Precondition: The server must be online and there must be an available port to accomodate server/client communciation.
        Postcondition: A connection is established with the server. The client sends a number identifying itself.
        Example (s): After establishing a connection to the server, the client sends a number (e.g. "1") which indicates to the server that the client started is client  "1".

        ----------------------------------------------------------------------------------------------------------------------- */
        private void StartClient()
        {
            try
            {

                TcpClient ThisClient = new TcpClient();

                ThisClient.Connect(IPAddress.Parse("127.0.0.1"), 8080);

                Stream stm = ThisClient.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes("3");


                stm.Write(ba, 0, ba.Length);

                TextBoxDialog.Text = ">> Online";
                ThisClient.Close();

            }

            catch (Exception)
            {

                TextBoxDialog.Text = ">> Offline Due to Server Not Being Found (Server Not Online)";

                MessageBox.Show("Connection NOT Established With Server");


            }//end catch()
        }//end ClientStart()
    }
}
