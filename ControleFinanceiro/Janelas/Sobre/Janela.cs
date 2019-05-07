using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleFinanceiro.Janelas.Sobre
{
    public partial class Janela : JanelaBaseComum
    {
        public Janela()
        {
            InitializeComponent();
        }

        private void Janela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }

    }
}