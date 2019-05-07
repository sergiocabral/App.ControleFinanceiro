namespace ControleFinanceiro.Janelas.ManterCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Janela));
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Original = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCategorias
            // 
            this.gridCategorias.AllowUserToDeleteRows = false;
            this.gridCategorias.AllowUserToResizeColumns = false;
            this.gridCategorias.AllowUserToResizeRows = false;
            this.gridCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCategorias.ColumnHeadersVisible = false;
            this.gridCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Categoria,
            this.Original});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategorias.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridCategorias.Location = new System.Drawing.Point(0, 0);
            this.gridCategorias.MultiSelect = false;
            this.gridCategorias.Name = "gridCategorias";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCategorias.RowHeadersVisible = false;
            this.gridCategorias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridCategorias.Size = new System.Drawing.Size(233, 309);
            this.gridCategorias.TabIndex = 0;
            this.gridCategorias.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategorias_CellValueChanged);
            this.gridCategorias.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridCategorias_CellValidating);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Nome";
            this.Categoria.HeaderText = "Nome";
            this.Categoria.Name = "Categoria";
            // 
            // Original
            // 
            this.Original.DataPropertyName = "Nome";
            this.Original.HeaderText = "Original";
            this.Original.Name = "Original";
            this.Original.Visible = false;
            // 
            // Janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 309);
            this.Controls.Add(this.gridCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Janela";
            this.Text = "Categoria de gastos";
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Original;

    }
}