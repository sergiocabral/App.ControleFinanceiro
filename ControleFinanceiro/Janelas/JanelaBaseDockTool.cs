using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.Componente.DockPanel.Docking;

namespace ControleFinanceiro.Janelas
{
    public class JanelaBaseDockTool : JanelaBaseDock
    {

        public JanelaBaseDockTool()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // JanelaBaseDockTool
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.DockAreas = ((Componente.DockPanel.Docking.DockAreas)((Componente.DockPanel.Docking.DockAreas.DockLeft | Componente.DockPanel.Docking.DockAreas.DockRight)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JanelaBaseDockTool";
            this.ResumeLayout(false);

        }
    }
}
