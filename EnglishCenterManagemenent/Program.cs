﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishCenterManagemenent.GUI;
using EnglishCenterManagemenent.GUI.Classes;

namespace EnglishCenterManagemenent
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
            Application.Run(new FormLogin());
            //Application.Run(new FormMain());
            //Application.Run(new FormClassInfoInput());
        }
    }
}
