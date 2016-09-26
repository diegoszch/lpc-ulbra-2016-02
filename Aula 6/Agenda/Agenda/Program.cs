using Agenda.Formularios.Util;
using System;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frmLogin = new FrmLogin();
            var result = frmLogin.ShowDialog();
            if(result == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal());
            }
        }
    }
}
