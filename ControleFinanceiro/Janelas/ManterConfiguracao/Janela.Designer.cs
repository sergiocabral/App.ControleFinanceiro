namespace ControleFinanceiro.Janelas.ManterConfiguracao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Janela));
            this.lblTentativasLogon = new System.Windows.Forms.Label();
            this.btnTentativasLogon = new System.Windows.Forms.Button();
            this.btnTrocarSenha = new System.Windows.Forms.Button();
            this.pnlLinha1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTentativasLogon = new System.Windows.Forms.MaskedTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtInformacoes = new System.Windows.Forms.RichTextBox();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaRepeticao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTentativasLogon
            // 
            this.lblTentativasLogon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTentativasLogon.Location = new System.Drawing.Point(3, 9);
            this.lblTentativasLogon.Name = "lblTentativasLogon";
            this.lblTentativasLogon.Size = new System.Drawing.Size(205, 13);
            this.lblTentativasLogon.TabIndex = 0;
            this.lblTentativasLogon.Text = "Tentativas de autenticação permitidas:";
            // 
            // btnTentativasLogon
            // 
            this.btnTentativasLogon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTentativasLogon.Location = new System.Drawing.Point(140, 25);
            this.btnTentativasLogon.Name = "btnTentativasLogon";
            this.btnTentativasLogon.Size = new System.Drawing.Size(65, 20);
            this.btnTentativasLogon.TabIndex = 2;
            this.btnTentativasLogon.Text = "&Gravar";
            this.btnTentativasLogon.UseVisualStyleBackColor = true;
            this.btnTentativasLogon.Click += new System.EventHandler(this.btnTentativasLogon_Click);
            // 
            // btnTrocarSenha
            // 
            this.btnTrocarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrocarSenha.Location = new System.Drawing.Point(6, 137);
            this.btnTrocarSenha.Name = "btnTrocarSenha";
            this.btnTrocarSenha.Size = new System.Drawing.Size(199, 20);
            this.btnTrocarSenha.TabIndex = 10;
            this.btnTrocarSenha.Text = "Trocar &Senha";
            this.btnTrocarSenha.UseVisualStyleBackColor = true;
            this.btnTrocarSenha.Click += new System.EventHandler(this.btnTrocarSenha_Click);
            // 
            // pnlLinha1
            // 
            this.pnlLinha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinha1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlLinha1.Location = new System.Drawing.Point(3, 51);
            this.pnlLinha1.Name = "pnlLinha1";
            this.pnlLinha1.Size = new System.Drawing.Size(205, 2);
            this.pnlLinha1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(3, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 2);
            this.panel1.TabIndex = 11;
            // 
            // txtTentativasLogon
            // 
            this.txtTentativasLogon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTentativasLogon.Location = new System.Drawing.Point(6, 25);
            this.txtTentativasLogon.Mask = "99";
            this.txtTentativasLogon.Name = "txtTentativasLogon";
            this.txtTentativasLogon.PromptChar = ' ';
            this.txtTentativasLogon.Size = new System.Drawing.Size(128, 20);
            this.txtTentativasLogon.TabIndex = 1;
            this.txtTentativasLogon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTentativasLogon.TextChanged += new System.EventHandler(this.txtTentativasLogon_TextChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformacoes.Location = new System.Drawing.Point(6, 171);
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.ReadOnly = true;
            this.txtInformacoes.Size = new System.Drawing.Size(199, 76);
            this.txtInformacoes.TabIndex = 12;
            this.txtInformacoes.Text = "";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(106, 59);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(99, 20);
            this.txtSenhaAtual.TabIndex = 5;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nova senha:";
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaNova.Location = new System.Drawing.Point(106, 85);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(99, 20);
            this.txtSenhaNova.TabIndex = 7;
            this.txtSenhaNova.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digite novamente:";
            // 
            // txtSenhaRepeticao
            // 
            this.txtSenhaRepeticao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaRepeticao.Location = new System.Drawing.Point(106, 111);
            this.txtSenhaRepeticao.Name = "txtSenhaRepeticao";
            this.txtSenhaRepeticao.Size = new System.Drawing.Size(99, 20);
            this.txtSenhaRepeticao.TabIndex = 9;
            this.txtSenhaRepeticao.UseSystemPasswordChar = true;
            // 
            // Janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(200, 251);
            this.ClientSize = new System.Drawing.Size(210, 251);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaRepeticao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.txtInformacoes);
            this.Controls.Add(this.txtTentativasLogon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLinha1);
            this.Controls.Add(this.btnTrocarSenha);
            this.Controls.Add(this.btnTentativasLogon);
            this.Controls.Add(this.lblTentativasLogon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Janela";
            this.Text = "Configurações";
            this.Enter += new System.EventHandler(this.Janela_Enter);
            this.Leave += new System.EventHandler(this.Janela_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTentativasLogon;
        private System.Windows.Forms.Button btnTentativasLogon;
        private System.Windows.Forms.Button btnTrocarSenha;
        private System.Windows.Forms.Panel pnlLinha1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtTentativasLogon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox txtInformacoes;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaRepeticao;
    }
}