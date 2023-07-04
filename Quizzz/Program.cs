using Quizzz;
using System;
using System.Windows.Forms;

namespace Quizzz
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

            // Create an instance of the RegistrationForm and run it
            RegistrationForm registrationForm = new RegistrationForm();
            Application.Run(registrationForm);
        }
    }
}
