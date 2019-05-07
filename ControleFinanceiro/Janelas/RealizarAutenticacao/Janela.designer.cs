namespace ControleFinanceiro.Janelas.RealizarAutenticacao
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblTentativas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(126, 85);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(248, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(126, 113);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(56, 23);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(126, 142);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(123, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Informe a senha de acesso ao sistema.";
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = global::ControleFinanceiro.Properties.Resources.ico_seguranca;
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIcone.Location = new System.Drawing.Point(12, 69);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(96, 96);
            this.picIcone.TabIndex = 17;
            this.picIcone.TabStop = false;
            // 
            // lblTentativas
            // 
            this.lblTentativas.BackColor = System.Drawing.Color.Transparent;
            this.lblTentativas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTentativas.Location = new System.Drawing.Point(203, 108);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(176, 15);
            this.lblTentativas.TabIndex = 18;
            this.lblTentativas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Janela
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ControleFinanceiro.Properties.Resources.img_fundo_janela_comum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(386, 206);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.picIcone);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Janela";
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação";
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblTentativas;
    }
}