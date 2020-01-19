using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace user_interface_calculator
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
            Application.Run(new F1());
        }
    }
}
