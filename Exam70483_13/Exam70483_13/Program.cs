using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exam70483_13
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Registration());

            Application.Run(new Login());
            MessageBox.Show("Exiting now");
        }
    }
}
