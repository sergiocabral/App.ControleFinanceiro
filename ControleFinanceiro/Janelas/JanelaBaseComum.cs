using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.ManipuladorDoProcesso;

namespace ControleFinanceiro.Janelas
{
    public class JanelaBaseComum : Form
    {

        #region Propriedades

        protected MpBase mp;

        private string text = string.Empty;
        public override string Text
        {
            get { return base.Text; }
            set
            {
                this.text = value;
                if (ShowInTaskbar && !Application.ProductName.Contains("Microsoft"))
                {
                    base.Text = Application.ProductName + (string.IsNullOrEmpty(this.text.Trim()) ? "" : " - " + this.text);
                }
                else
                {
                    base.Text = this.text;
                }
            }
        }

        #endregion

        #region Métodos

        public JanelaBaseComum()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // JanelaBase
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "JanelaBase";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion
    }
}
