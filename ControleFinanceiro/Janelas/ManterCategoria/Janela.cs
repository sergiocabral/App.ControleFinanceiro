using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.ManipuladorDoProcesso;
using ControleFinanceiro.Bibliotecas.Exception;
using ControleFinanceiro.Entidades;

namespace ControleFinanceiro.Janelas.ManterCategoria
{
    public partial class Janela : JanelaBaseDockTool
    {
        #region Propriedades

        private MpManterCategoria Mp
        {
            get
            {
                if (mp == null)
                {
                    mp = new MpManterCategoria();
                }
                return (MpManterCategoria)mp;
            }
        }        

        #endregion

        #region Métodos

        public Janela()
        {
            InitializeComponent();
            InitializeComponent2();
            CategoriasCarregar();
        }

        private void InitializeComponent2()
        {
            this.gridCategorias.AutoGenerateColumns = false;
        }

        private void CategoriasCarregar()
        {
            try
            {
                IList<Categoria> lista = Mp.Listar();
                gridCategorias.Rows.Clear();
                foreach (Categoria categoria in lista)
                {
                    gridCategorias.Rows.Add(categoria.Id, categoria.Nome, categoria.Nome);
                }
                gridCategorias.Sort(gridCategorias.Columns[1], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
            }
        }

        private void gridRow_Alterar(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridCategorias = (DataGridView)sender;
            string id = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells["Id"].Value);
            string novoValor = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            Categoria categoria = new Categoria();
            if (!string.IsNullOrEmpty(id))
            {
                categoria.Id = Convert.ToInt32(id);
            }
            categoria.Nome = novoValor;

            try
            {
                categoria = Mp.Alterar(categoria);
                gridCategorias.Rows[e.RowIndex].Cells["Id"].Value = categoria.Id;
                gridCategorias.Rows[e.RowIndex].Cells["Original"].Value = categoria.Nome;
                gridCategorias.Rows[e.RowIndex].Cells["Categoria"].Value = gridCategorias.Rows[e.RowIndex].Cells["Original"].Value;
            }
            catch (LocalException ex)
            {
                if (ex.Message.Contains("constraint"))
                {
                    Bibliotecas.MessageBox.Show(string.Format("A categoria \"{0}\" já existe.", categoria.Nome), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Informativo);
                    if (string.IsNullOrEmpty(id))
                    {
                        gridCategorias.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        gridCategorias.Rows[e.RowIndex].Cells["Categoria"].Value = gridCategorias.Rows[e.RowIndex].Cells["Original"].Value;
                    }
                }
                else
                {
                    throw;
                }
            }
        }

        private void gridRow_Excluir(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridCategorias = (DataGridView)sender;
            string id = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells["Id"].Value);
            string original = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells["Original"].Value);

            if (string.IsNullOrEmpty(id) || Bibliotecas.MessageBox.Show(string.Format("Excluir a categoria \"{0}\"?", original), ControleFinanceiro.Bibliotecas.MessageBoxTipo.PerguntaNaoSim) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(id))
                {
                    Mp.Excluir(int.Parse(id));
                }
                gridCategorias.Rows.RemoveAt(e.RowIndex);
            }
            else
            {
                gridCategorias.Rows[e.RowIndex].Cells["Categoria"].Value = gridCategorias.Rows[e.RowIndex].Cells["Original"].Value;
            }
        }

        #endregion

        #region Eventos

        private void gridCategorias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridCategorias = (DataGridView)sender;

            if (gridCategorias.Tag != null) return;
            gridCategorias.Tag = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string novoValor = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                string id = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells["Id"].Value);

                try
                {
                    if (string.IsNullOrEmpty(novoValor) || string.IsNullOrEmpty(novoValor.Trim()))
                    {
                        gridRow_Excluir(sender, e);
                    }
                    else
                    {
                        gridRow_Alterar(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
                    gridCategorias.Rows[e.RowIndex].Cells["Categoria"].Value = gridCategorias.Rows[e.RowIndex].Cells["Original"].Value;
                    if (string.IsNullOrEmpty(id))
                    {
                        gridCategorias.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

            gridCategorias.Tag = null;
        }

        private void gridCategorias_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView gridCategorias = (DataGridView)sender;
            string id = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells["Id"].Value);
            string original = Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells["Original"].Value);

            string valor = Convert.ToString(e.FormattedValue);

            if (string.IsNullOrEmpty(id) && e.RowIndex < (gridCategorias.Rows.Count - 1) && string.IsNullOrEmpty(valor))
            {
                gridCategorias.CancelEdit();
            }
        }

        #endregion
    }
}