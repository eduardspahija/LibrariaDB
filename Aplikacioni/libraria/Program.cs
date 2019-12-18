using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraria
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

            using (Login fLogin = new Login())
            {
                if (fLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMainForm());
                }
                else
                {
                    Application.Exit();
                }
            }

        }
    }
}
