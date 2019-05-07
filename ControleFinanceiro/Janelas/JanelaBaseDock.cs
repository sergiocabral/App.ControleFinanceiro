using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.Componente.DockPanel.Docking;
using ControleFinanceiro.ManipuladorDoProcesso;

namespace ControleFinanceiro.Janelas
{
    public class JanelaBaseDock : DockContent
    {

        protected MpBase mp;

        public JanelaBaseDock()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // JanelaBaseDock
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JanelaBaseDock";
            this.ResumeLayout(false);

        }
    }
}
