using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Money
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
            Application.Run(new FrmPrincip());

            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();

            //if (frmLogin.Conectado)
            //{
            //    Application.Run(new FrmPrincip());
            //}
        }
    }
}
