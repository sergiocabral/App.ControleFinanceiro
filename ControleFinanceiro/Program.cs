using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ControleFinanceiro.Janelas.Principal.Janela());
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("O sistema não foi finalizado corretamente. {0}", ex.Message), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}