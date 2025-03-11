using _3SPorts;
using System;
using System.IO;
using System.Windows.Forms;

namespace _3Sports
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(Application.StartupPath, "Services"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashView());
        }
    }
}
