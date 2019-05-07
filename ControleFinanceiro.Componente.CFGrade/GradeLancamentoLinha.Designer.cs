namespace ControleFinanceiro.Componente.CFGrade
{
    partial class GradeLancamentoLinha
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtDescricao = new ControleFinanceiro.Componente.CFGrade.TextBoxVerificador();
            this.txtDocumento = new ControleFinanceiro.Componente.CFGrade.TextBoxVerificador();
            this.txtData = new ControleFinanceiro.Componente.CFGrade.TextBoxVerificadorData();
            this.txtValorEsperado = new ControleFinanceiro.Componente.CFGrade.TextBoxVerificadorMoeda();
            this.txtValorSaldo = new ControleFinanceiro.Componente.CFGrade.TextBoxVerificadorMoeda();
            this.txtValorCredito = new ControleFinanceiro.Componente.CFGrade.TextBoxVerificadorMoeda();
            this.txtValorDebito = new ControleFinanceiro.Componente.CFGrade.TextBoxVerificadorMoeda();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(368, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(130, 34);
            this.checkedListBox1.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::ControleFinanceiro.Componente.CFGrade.Properties.Resources.ico_excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Location = new System.Drawing.Point(4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(20, 20);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.CorDoAlerta = System.Drawing.Color.Red;
            this.txtDescricao.Location = new System.Drawing.Point(232, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(130, 33);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.CorDoAlerta = System.Drawing.Color.Red;
            this.txtDocumento.Location = new System.Drawing.Point(126, 3);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.CalendarioExibido = false;
            this.txtData.CorDoAlerta = System.Drawing.Color.Red;
            this.txtData.Location = new System.Drawing.Point(30, 3);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(90, 20);
            this.txtData.TabIndex = 1;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorEsperado
            // 
            this.txtValorEsperado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorEsperado.CorDoAlerta = System.Drawing.Color.Red;
            this.txtValorEsperado.ExibirSiglaDaMoeda = true;
            this.txtValorEsperado.Location = new System.Drawing.Point(762, 3);
            this.txtValorEsperado.MaxLength = 20;
            this.txtValorEsperado.Name = "txtValorEsperado";
            this.txtValorEsperado.Size = new System.Drawing.Size(80, 20);
            this.txtValorEsperado.TabIndex = 8;
            this.txtValorEsperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorSaldo
            // 
            this.txtValorSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorSaldo.CorDoAlerta = System.Drawing.Color.Red;
            this.txtValorSaldo.ExibirSiglaDaMoeda = true;
            this.txtValorSaldo.Location = new System.Drawing.Point(676, 3);
            this.txtValorSaldo.MaxLength = 20;
            this.txtValorSaldo.Name = "txtValorSaldo";
            this.txtValorSaldo.Size = new System.Drawing.Size(80, 20);
            this.txtValorSaldo.TabIndex = 7;
            this.txtValorSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorCredito.CorDoAlerta = System.Drawing.Color.Red;
            this.txtValorCredito.ExibirSiglaDaMoeda = true;
            this.txtValorCredito.Location = new System.Drawing.Point(590, 3);
            this.txtValorCredito.MaxLength = 20;
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.Size = new System.Drawing.Size(80, 20);
            this.txtValorCredito.TabIndex = 6;
            this.txtValorCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDebito.CorDoAlerta = System.Drawing.Color.Red;
            this.txtValorDebito.Location = new System.Drawing.Point(504, 3);
            this.txtValorDebito.MaxLength = 20;
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(80, 20);
            this.txtValorDebito.TabIndex = 5;
            this.txtValorDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GradeLancamentoLinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtValorEsperado);
            this.Controls.Add(this.txtValorSaldo);
            this.Controls.Add(this.txtValorCredito);
            this.Controls.Add(this.txtValorDebito);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnExcluir);
            this.Name = "GradeLancamentoLinha";
            this.Size = new System.Drawing.Size(847, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private TextBoxVerificadorMoeda txtValorDebito;
        private TextBoxVerificadorMoeda txtValorCredito;
        private TextBoxVerificadorMoeda txtValorSaldo;
        private TextBoxVerificadorMoeda txtValorEsperado;
        private TextBoxVerificadorData txtData;
        private TextBoxVerificador txtDocumento;
        private TextBoxVerificador txtDescricao;
    }
}
