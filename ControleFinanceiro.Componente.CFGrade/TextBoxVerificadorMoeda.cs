using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace ControleFinanceiro.Componente.CFGrade
{
    public class TextBoxVerificadorMoeda : TextBoxVerificador
    {
        bool exibirSiglaDaMoeda = false;
        [DefaultValue(false)]
        public bool ExibirSiglaDaMoeda
        {
            get { return exibirSiglaDaMoeda; }
            set { exibirSiglaDaMoeda = value; }
        }

        public TextBoxVerificadorMoeda()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextBoxVerificadorMoeda
            // 
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.evento_KeyPress);
            this.ResumeLayout(false);
        }

        protected override bool VerificarTextoOk(string texto)
        {
            texto = texto == null ? null : texto.Trim();
            if (!string.IsNullOrEmpty(texto))
            {
                try
                {
                    if (ExibirSiglaDaMoeda)
                    {
                        string siglaMoeda = ((double)0).ToString("C");
                        siglaMoeda = Regex.Replace(siglaMoeda, "(?<=\\s).*", string.Empty).Trim();
                        if (texto.IndexOf(siglaMoeda) == 0)
                        {
                            texto = texto.Remove(0, siglaMoeda.Length).Trim();
                        }
                    }
                    ValorOriginal = Math.Abs(Convert.ToDouble(texto));
                    string valorMoeda = ((double)ValorOriginal).ToString("C");
                    if (!ExibirSiglaDaMoeda)
                    {
                        valorMoeda = Regex.Replace(valorMoeda, ".*\\s", string.Empty);
                    }
                    base.Text = valorMoeda;                    
                }
                catch (FormatException)
                {
                    base.Text = "";
                    return false;
                }
                catch (OverflowException)
                {
                    base.Text = "";
                    return false;
                }
            }
            else
            {
                ValorOriginal = 0;
            }
            return true;
        }

        private void evento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((byte)e.KeyChar >= 32)
            {
                if (Regex.Replace(e.KeyChar.ToString(), "[^0-9,\\.,\\,]", string.Empty) == string.Empty)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
