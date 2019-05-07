namespace ControleFinanceiro.Janelas.ManterLivroCaixa
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
            this.toolBtn_MostrarTodos = new System.Windows.Forms.ToolStripButton();
            this.lstLivros = new System.Windows.Forms.ListView();
            this.lstLivrosCol_Nome = new System.Windows.Forms.ColumnHeader();
            this.lstLivrosCol_Saldo = new System.Windows.Forms.ColumnHeader();
            this.lstLivrosCol_Estado = new System.Windows.Forms.ColumnHeader();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtn_ModoExibicao = new System.Windows.Forms.ToolStripSplitButton();
            this.mnu_ModoExibicao_LadoLado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ModoExibicao_Icone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ModoExibicao_IconePequeno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ModoExibicao_Lista = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ModoExibicao_Detalhe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtn_Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_Ativar = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Desativar = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtn_Incluir = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Renomear = new System.Windows.Forms.ToolStripButton();
            this.toolBtn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBtn_MostrarTodos
            // 
            this.toolBtn_MostrarTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtn_MostrarTodos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_MostrarTodos.Name = "toolBtn_MostrarTodos";
            this.toolBtn_MostrarTodos.Size = new System.Drawing.Size(40, 22);
            this.toolBtn_MostrarTodos.Text = "Todos";
            this.toolBtn_MostrarTodos.ToolTipText = "Inclui na lista os Livros Caixas desativados (CTRL+T)";
            this.toolBtn_MostrarTodos.Click += new System.EventHandler(this.toolBtn_MostrarTodos_Click);
            // 
            // lstLivros
            // 
            this.lstLivros.AllowColumnReorder = true;
            this.lstLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstLivrosCol_Nome,
            this.lstLivrosCol_Saldo,
            this.lstLivrosCol_Estado});
            this.lstLivros.FullRowSelect = true;
            this.lstLivros.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstLivros.LabelEdit = true;
            this.lstLivros.LargeImageList = this.imageListLarge;
            this.lstLivros.Location = new System.Drawing.Point(0, 24);
            this.lstLivros.Name = "lstLivros";
            this.lstLivros.ShowItemToolTips = true;
            this.lstLivros.Size = new System.Drawing.Size(292, 242);
            this.lstLivros.SmallImageList = this.imageListSmall;
            this.lstLivros.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstLivros.TabIndex = 0;
            this.lstLivros.UseCompatibleStateImageBehavior = false;
            this.lstLivros.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstLivros_AfterLabelEdit);
            this.lstLivros.SelectedIndexChanged += new System.EventHandler(this.lstLivros_SelectedIndexChanged);
            this.lstLivros.DoubleClick += new System.EventHandler(this.lstLivros_DoubleClick);
            this.lstLivros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLivros_KeyDown);
            // 
            // lstLivrosCol_Nome
            // 
            this.lstLivrosCol_Nome.Text = "Nome";
            this.lstLivrosCol_Nome.Width = 80;
            // 
            // lstLivrosCol_Saldo
            // 
            this.lstLivrosCol_Saldo.Text = "Saldo Atual";
            this.lstLivrosCol_Saldo.Width = 120;
            // 
            // lstLivrosCol_Estado
            // 
            this.lstLivrosCol_Estado.Text = "Estado";
            this.lstLivrosCol_Estado.Width = 75;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "ico_controle_financeiro_48.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "ico_controle_financeiro_16.png");
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtn_ModoExibicao,
            this.toolBtn_Sep1,
            this.toolBtn_Ativar,
            this.toolBtn_Desativar,
            this.toolBtn_MostrarTodos,
            this.toolBtn_Sep2,
            this.toolBtn_Incluir,
            this.toolBtn_Renomear,
            this.toolBtn_Excluir});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(292, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtn_ModoExibicao
            // 
            this.toolBtn_ModoExibicao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_ModoExibicao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ModoExibicao_LadoLado,
            this.mnu_ModoExibicao_Icone,
            this.mnu_ModoExibicao_IconePequeno,
            this.mnu_ModoExibicao_Lista,
            this.mnu_ModoExibicao_Detalhe});
            this.toolBtn_ModoExibicao.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_ModoExibicao.Image")));
            this.toolBtn_ModoExibicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_ModoExibicao.Name = "toolBtn_ModoExibicao";
            this.toolBtn_ModoExibicao.Size = new System.Drawing.Size(32, 22);
            this.toolBtn_ModoExibicao.Text = "Modos de exibição (CTRL+E)";
            this.toolBtn_ModoExibicao.ButtonClick += new System.EventHandler(this.toolBtn_ModoExibicao_ButtonClick);
            // 
            // mnu_ModoExibicao_LadoLado
            // 
            this.mnu_ModoExibicao_LadoLado.Name = "mnu_ModoExibicao_LadoLado";
            this.mnu_ModoExibicao_LadoLado.Size = new System.Drawing.Size(167, 22);
            this.mnu_ModoExibicao_LadoLado.Text = "Lado a Lado";
            this.mnu_ModoExibicao_LadoLado.Click += new System.EventHandler(this.mnu_ModoExibicao_Click);
            // 
            // mnu_ModoExibicao_Icone
            // 
            this.mnu_ModoExibicao_Icone.Name = "mnu_ModoExibicao_Icone";
            this.mnu_ModoExibicao_Icone.Size = new System.Drawing.Size(167, 22);
            this.mnu_ModoExibicao_Icone.Text = "Ícones";
            this.mnu_ModoExibicao_Icone.Click += new System.EventHandler(this.mnu_ModoExibicao_Click);
            // 
            // mnu_ModoExibicao_IconePequeno
            // 
            this.mnu_ModoExibicao_IconePequeno.Name = "mnu_ModoExibicao_IconePequeno";
            this.mnu_ModoExibicao_IconePequeno.Size = new System.Drawing.Size(167, 22);
            this.mnu_ModoExibicao_IconePequeno.Text = "Ícones pequenos";
            this.mnu_ModoExibicao_IconePequeno.Click += new System.EventHandler(this.mnu_ModoExibicao_Click);
            // 
            // mnu_ModoExibicao_Lista
            // 
            this.mnu_ModoExibicao_Lista.Name = "mnu_ModoExibicao_Lista";
            this.mnu_ModoExibicao_Lista.Size = new System.Drawing.Size(167, 22);
            this.mnu_ModoExibicao_Lista.Text = "Lista";
            this.mnu_ModoExibicao_Lista.Click += new System.EventHandler(this.mnu_ModoExibicao_Click);
            // 
            // mnu_ModoExibicao_Detalhe
            // 
            this.mnu_ModoExibicao_Detalhe.Name = "mnu_ModoExibicao_Detalhe";
            this.mnu_ModoExibicao_Detalhe.Size = new System.Drawing.Size(167, 22);
            this.mnu_ModoExibicao_Detalhe.Text = "Detalhes";
            this.mnu_ModoExibicao_Detalhe.Click += new System.EventHandler(this.mnu_ModoExibicao_Click);
            // 
            // toolBtn_Sep1
            // 
            this.toolBtn_Sep1.Name = "toolBtn_Sep1";
            this.toolBtn_Sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtn_Ativar
            // 
            this.toolBtn_Ativar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Ativar.Image = global::ControleFinanceiro.Properties.Resources.ico_ativar;
            this.toolBtn_Ativar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Ativar.Name = "toolBtn_Ativar";
            this.toolBtn_Ativar.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_Ativar.Text = "Ativar";
            this.toolBtn_Ativar.ToolTipText = "Ativar (CTRL+A)";
            this.toolBtn_Ativar.Click += new System.EventHandler(this.toolBtn_AtivarDesativar_Click);
            // 
            // toolBtn_Desativar
            // 
            this.toolBtn_Desativar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Desativar.Image = global::ControleFinanceiro.Properties.Resources.ico_desativar;
            this.toolBtn_Desativar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Desativar.Name = "toolBtn_Desativar";
            this.toolBtn_Desativar.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_Desativar.Text = "Desativar";
            this.toolBtn_Desativar.ToolTipText = "Desativar (CTRL+D)";
            this.toolBtn_Desativar.Click += new System.EventHandler(this.toolBtn_AtivarDesativar_Click);
            // 
            // toolBtn_Sep2
            // 
            this.toolBtn_Sep2.Name = "toolBtn_Sep2";
            this.toolBtn_Sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtn_Incluir
            // 
            this.toolBtn_Incluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Incluir.Image = global::ControleFinanceiro.Properties.Resources.ico_incluir;
            this.toolBtn_Incluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Incluir.Name = "toolBtn_Incluir";
            this.toolBtn_Incluir.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_Incluir.Text = "Criar";
            this.toolBtn_Incluir.ToolTipText = "Criar (Insert)";
            this.toolBtn_Incluir.Click += new System.EventHandler(this.toolBtn_Incluir_Click);
            // 
            // toolBtn_Renomear
            // 
            this.toolBtn_Renomear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Renomear.Image = global::ControleFinanceiro.Properties.Resources.ico_renomear;
            this.toolBtn_Renomear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Renomear.Name = "toolBtn_Renomear";
            this.toolBtn_Renomear.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_Renomear.Text = "Renomear";
            this.toolBtn_Renomear.ToolTipText = "Renomear (F2)";
            this.toolBtn_Renomear.Click += new System.EventHandler(this.toolBtn_Renomear_Click);
            // 
            // toolBtn_Excluir
            // 
            this.toolBtn_Excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("toolBtn_Excluir.Image")));
            this.toolBtn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn_Excluir.Name = "toolBtn_Excluir";
            this.toolBtn_Excluir.Size = new System.Drawing.Size(23, 22);
            this.toolBtn_Excluir.Text = "Excluir";
            this.toolBtn_Excluir.ToolTipText = "Excluir (Delete)";
            this.toolBtn_Excluir.Click += new System.EventHandler(this.toolBtn_Excluir_Click);
            // 
            // Janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lstLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Janela";
            this.Text = "Livros caixa";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstLivros;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton toolBtn_ModoExibicao;
        private System.Windows.Forms.ToolStripMenuItem mnu_ModoExibicao_Detalhe;
        private System.Windows.Forms.ToolStripMenuItem mnu_ModoExibicao_Lista;
        private System.Windows.Forms.ToolStripMenuItem mnu_ModoExibicao_Icone;
        private System.Windows.Forms.ToolStripMenuItem mnu_ModoExibicao_IconePequeno;
        private System.Windows.Forms.ToolStripMenuItem mnu_ModoExibicao_LadoLado;
        private System.Windows.Forms.ColumnHeader lstLivrosCol_Nome;
        private System.Windows.Forms.ColumnHeader lstLivrosCol_Estado;
        private System.Windows.Forms.ColumnHeader lstLivrosCol_Saldo;
        private System.Windows.Forms.ToolStripSeparator toolBtn_Sep1;
        private System.Windows.Forms.ToolStripButton toolBtn_Ativar;
        private System.Windows.Forms.ToolStripButton toolBtn_Desativar;
        private System.Windows.Forms.ToolStripSeparator toolBtn_Sep2;
        private System.Windows.Forms.ToolStripButton toolBtn_Incluir;
        private System.Windows.Forms.ToolStripButton toolBtn_Excluir;
        private System.Windows.Forms.ToolStripButton toolBtn_Renomear;
        private System.Windows.Forms.ToolStripButton toolBtn_MostrarTodos;
    }
}