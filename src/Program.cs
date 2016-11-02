/**
 * Copyright (c) 2009 Jeremy Sells
 * See the file LICENSE for copying permission.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace simpleRobot_controller_V1._0
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
            Application.Run(new Form1());
        }
    }
}
