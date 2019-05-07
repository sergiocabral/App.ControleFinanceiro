namespace ControleFinanceiro.Janelas.RealizarConexao
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(159, 97);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(206, 94);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(168, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(206, 120);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 20);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(164, 123);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServidor
            // 
            this.txtServidor.BackColor = System.Drawing.Color.White;
            this.txtServidor.ForeColor = System.Drawing.Color.Black;
            this.txtServidor.Location = new System.Drawing.Point(206, 42);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(168, 20);
            this.txtServidor.TabIndex = 2;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.BackColor = System.Drawing.Color.Transparent;
            this.lblServidor.ForeColor = System.Drawing.Color.Black;
            this.lblServidor.Location = new System.Drawing.Point(156, 45);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Servidor:";
            this.lblServidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBanco
            // 
            this.txtBanco.BackColor = System.Drawing.Color.White;
            this.txtBanco.ForeColor = System.Drawing.Color.Black;
            this.txtBanco.Location = new System.Drawing.Point(206, 68);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(168, 20);
            this.txtBanco.TabIndex = 4;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.BackColor = System.Drawing.Color.Transparent;
            this.lblBanco.ForeColor = System.Drawing.Color.Black;
            this.lblBanco.Location = new System.Drawing.Point(117, 71);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(88, 13);
            this.lblBanco.TabIndex = 3;
            this.lblBanco.Text = "Banco de dados:";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConectar
            // 
            this.btnConectar.ForeColor = System.Drawing.Color.Black;
            this.btnConectar.Location = new System.Drawing.Point(206, 146);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 13;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(206, 175);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(5, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 59);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Informe os parâmetros para conexão manual com o banco de dados.";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.ForeColor = System.Drawing.Color.Maroon;
            this.txtStatus.Location = new System.Drawing.Point(8, 100);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(104, 98);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            this.txtStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStatus_KeyPress);
            // 
            // Janela
            // 
            this.AcceptButton = this.btnConectar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ControleFinanceiro.Properties.Resources.img_fundo_janela_comum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(386, 206);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 232);
            this.Name = "Janela";
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexão";
            this.Shown += new System.EventHandler(this.Janela_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtStatus;


    }
}