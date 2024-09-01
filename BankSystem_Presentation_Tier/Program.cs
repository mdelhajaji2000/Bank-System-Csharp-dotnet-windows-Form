using BankSystem_Presentation_Tier.SplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier
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

            using (SplashScreenForm spalsh = new SplashScreenForm())
            {
                spalsh.StartPosition = FormStartPosition.CenterScreen;
                spalsh.ShowDialog();
            }

            Application.Run(new LogIn.LogInForm());
        }
    }
}
