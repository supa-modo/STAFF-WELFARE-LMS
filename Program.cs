﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           /* if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();*/

            loginScreen loginScreen = new loginScreen();
            if(loginScreen.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainScreen());
            }
            
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
