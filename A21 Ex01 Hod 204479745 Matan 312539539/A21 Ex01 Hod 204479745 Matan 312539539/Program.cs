using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFacebookForm());
        }
    }
}