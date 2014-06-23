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
using System.Windows.Forms;

namespace WindowsFormsApplicationClients
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainClients());
        }
    }
}
