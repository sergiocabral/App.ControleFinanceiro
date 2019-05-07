namespace ControleFinanceiro.Janelas.Sobre
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
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.lblVersao.Location = new System.Drawing.Point(80, 83);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(166, 18);
            this.lblVersao.TabIndex = 1;
            this.lblVersao.Text = "versão 3";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInformacao
            // 
            this.lblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacao.Location = new System.Drawing.Point(57, 116);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(223, 75);
            this.lblInformacao.TabIndex = 2;
            this.lblInformacao.Text = "Copyright © 2009 SPAN Ltda.\r\ncontrolefinanceiro@spanltda.com.br";
            this.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ControleFinanceiro.Properties.Resources.img_fundo_janela_sobre;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(401, 200);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.lblVersao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Janela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informações Sobre . . .";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Janela_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblInformacao;
    }
}