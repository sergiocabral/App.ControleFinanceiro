namespace ControleFinanceiro.Janelas.ManterLancamento
{
    partial class Janela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Janela));
            this.gradeLancamento1 = new ControleFinanceiro.Componente.CFGrade.GradeLancamento();
            this.SuspendLayout();
            // 
            // gradeLancamento1
            // 
            this.gradeLancamento1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeLancamento1.Location = new System.Drawing.Point(0, 0);
            this.gradeLancamento1.Name = "gradeLancamento1";
            this.gradeLancamento1.Size = new System.Drawing.Size(872, 349);
            this.gradeLancamento1.TabIndex = 0;
            // 
            // Janela
            // 
            this.ClientSize = new System.Drawing.Size(872, 349);
            this.Controls.Add(this.gradeLancamento1);
            this.DockAreas = ((ControleFinanceiro.Componente.DockPanel.Docking.DockAreas)((ControleFinanceiro.Componente.DockPanel.Docking.DockAreas.Float | ControleFinanceiro.Componente.DockPanel.Docking.DockAreas.Document)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(880, 0);
            this.Name = "Janela";
            this.Text = "Lançamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Janela_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private ControleFinanceiro.Componente.CFGrade.GradeLancamento gradeLancamento1;


    }
}
