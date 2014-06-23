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
    public partial class FormMainClients : Form
    {
        public FormMainClients()
        {
            InitializeComponent();
        }

        private void ButtonClient1_Click(object sender, EventArgs e)
        {
            FormClient2 currentForm = new FormClient2();
            currentForm.Show();

        }

        private void ButtonClient2_Click(object sender, EventArgs e)
        {

            ClientForm2 currentForm = new ClientForm2();
            currentForm.Show();

        }

        private void ButtonClient3_Click(object sender, EventArgs e)
        {
            ClientForm3 currentForm = new ClientForm3();
            currentForm.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
