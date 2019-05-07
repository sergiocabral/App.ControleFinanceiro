using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.Entidades;
using ControleFinanceiro.ManipuladorDoProcesso;
using ControleFinanceiro.Bibliotecas.Exception;

namespace ControleFinanceiro.Janelas.ManterLivroCaixa
{
    public partial class Janela : JanelaBaseDockTool
    {

        #region Propriedades

        private MpManterLivroCaixa Mp
        {
            get
            {
                if (mp == null)
                {
                    mp = new MpManterLivroCaixa();
                }
                return (MpManterLivroCaixa)mp;
            }
        }

        #endregion

        #region Métodos

        public Janela()
        {
            InitializeComponent();
            LivrosCarregar();
            lstLivros_SelectedIndexChanged(lstLivros, null);
            toolBtn_ModoExibicao.PerformButtonClick();
        }

        private ListViewItem AtualizarItem(ListViewItem item, LivroCaixa dados)
        {
            if (item == null)
            {
                item = new ListViewItem();
            }

            item.ImageIndex = 0;
            item.SubItems.Clear();
            item.Text = dados.Nome;
            item.SubItems.Add(string.Format(new Bibliotecas.FormatProvider.LivroCaixaSaldoAtual(), "{0}", dados.Saldo));
            item.SubItems.Add(dados.AtivoEx2);
            item.SubItems.Add(dados.Id.ToString());

            return item;
        }

        private ListViewItem ObterItem(LivroCaixa dados)
        {
            foreach (ListViewItem item in lstLivros.Items)
            {
                if (int.Parse(item.SubItems[3].Text) == dados.Id)
                {
                    return item;
                }
            }
            return null;
        }

        private void LivrosCarregar()
        {
            lstLivros.Items.Clear();
            try
            {
                IList<LivroCaixa> listaDados = Mp.Listar();
                foreach (LivroCaixa livro in listaDados)
                {
                    if (toolBtn_MostrarTodos.Checked || livro.AtivoEx1)
                    {
                        lstLivros.Items.Add(AtualizarItem(null, livro));
                    }
                }
                lstLivros.Sort();
            }
            catch (Exception ex)
            {
                Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
            }
        }

        private void toolStrip_AtualizarControles()
        {
            LivroCaixa livro = LivroObterSelecionado();
            if (livro != null)
            {
                toolBtn_Ativar.Checked = livro.AtivoEx1;
                toolBtn_Desativar.Checked = !livro.AtivoEx1;
            }
            else
            {
                toolBtn_Ativar.Checked = false;
                toolBtn_Desativar.Checked = false;
            }
            toolBtn_Ativar.Enabled = (livro != null);
            toolBtn_Desativar.Enabled = (livro != null);
            toolBtn_Renomear.Enabled = (livro != null);
            toolBtn_Excluir.Enabled = lstLivros.SelectedItems.Count > 0;
        }

        private void LivroSelecionar(LivroCaixa livro)
        {
            lstLivros.SelectedItems.Clear();
            if (livro != null)
            {
                foreach (ListViewItem item in lstLivros.Items)
                {
                    if (item.Text == livro.Nome)
                    {
                        item.Selected = true;
                        break;
                    }
                }
            }
        }

        private LivroCaixa LivroObterSelecionado()
        {
            if (lstLivros.SelectedItems.Count == 1)
            {
                return LivroObter(lstLivros.SelectedItems[0]);
            }
            return null;
        }

        private LivroCaixa LivroObter(ListViewItem item)
        {
            try
            {
                return Mp.Ler(int.Parse(item.SubItems[3].Text));
            }
            catch (Exception ex)
            {
                Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
            }
            return null;
        }

        #endregion

        #region Eventos

        private void mnu_ModoExibicao_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem subItem in toolBtn_ModoExibicao.DropDownItems)
            {
                subItem.Checked = false;
            }
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.Checked = true;

            if (mnu_ModoExibicao_Detalhe.Checked)
            {
                lstLivros.View = View.Details;
            }
            else if (mnu_ModoExibicao_Icone.Checked)
            {
                lstLivros.View = View.LargeIcon;
            }
            else if (mnu_ModoExibicao_IconePequeno.Checked)
            {
                lstLivros.View = View.SmallIcon;
            }
            else if (mnu_ModoExibicao_LadoLado.Checked)
            {
                lstLivros.View = View.Tile;
            }
            else if (mnu_ModoExibicao_Lista.Checked)
            {
                lstLivros.View = View.List;
            }
        }

        private void toolBtn_ModoExibicao_ButtonClick(object sender, EventArgs e)
        {
            bool marcarOProximo = false;
            foreach (ToolStripMenuItem menuItem in toolBtn_ModoExibicao.DropDownItems)
            {
                if (marcarOProximo)
                {
                    menuItem.PerformClick();
                    return;
                }

                if (menuItem.Checked)
                {
                    marcarOProximo = true;
                }
            }

            toolBtn_ModoExibicao.DropDownItems[0].PerformClick();
        }

        private void lstLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStrip_AtualizarControles();
        }

        private void toolBtn_AtivarDesativar_Click(object sender, EventArgs e)
        {
            LivroCaixa livro = LivroObterSelecionado();
            if (livro != null)
            {
                if (((ToolStripButton)sender).Text.Contains("Desativar"))
                {
                    livro.AtivoEx1 = false;
                }
                else
                {
                    livro.AtivoEx1 = true;
                }
                try
                {
                    Mp.Alterar(livro);
                    AtualizarItem(lstLivros.SelectedItems[0], livro);
                    if (!toolBtn_MostrarTodos.Checked && !livro.AtivoEx1)
                    {
                        lstLivros.Items.Remove(lstLivros.SelectedItems[0]);
                    }
                    toolStrip_AtualizarControles();

                    ((Principal.Janela)ParentForm).JanelaLancamentoAtualizar(livro);
                }
                catch (Exception ex)
                {
                    Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
                }
            }
        }

        private void toolBtn_Incluir_Click(object sender, EventArgs e)
        {
            try
            {
                LivroCaixa livroNovo = Mp.CriarNovo("Livro Caixa {0}");
                lstLivros.Items.Add(AtualizarItem(null, livroNovo));
                LivroSelecionar(livroNovo);
                ((Principal.Janela)ParentForm).JanelaLancamentoAtualizar(livroNovo);
            }
            catch (Exception ex)
            {
                Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
            }
        }

        private void toolBtn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder listaLivrosCaixa = new StringBuilder();
                foreach (ListViewItem item in lstLivros.SelectedItems)
                {
                    LivroCaixa livro = LivroObter(item);
                    listaLivrosCaixa.Append(", \"" + livro.Nome + "\"");
                }
                if (listaLivrosCaixa.Length > 0)
                {
                    //Remove vírgula inicial.
                    listaLivrosCaixa.Remove(0, 2);
                    if (lstLivros.SelectedItems.Count > 1)
                    {
                        listaLivrosCaixa.Replace(", ", " e ", listaLivrosCaixa.ToString().LastIndexOf("\", \""), 3);
                    }
                }
                else
                {
                    return;
                }

                if (Bibliotecas.MessageBox.Show(string.Format("Excluir o{1} livro{1} caixa {0} incluindo todos os seus lançamentos?\nEsta operação é irreversível.", listaLivrosCaixa.ToString(), (lstLivros.SelectedItems.Count == 1 ? string.Empty : "s")), ControleFinanceiro.Bibliotecas.MessageBoxTipo.PerguntaNaoSim) == DialogResult.Yes)
                {
                    int? index = null;
                    foreach (ListViewItem item in lstLivros.SelectedItems)
                    {
                        if (index == null)
                        {
                            index = item.Index;
                        }
                        LivroCaixa livro = LivroObter(item);
                        Mp.Excluir(livro);
                        lstLivros.Items.Remove(item);
                        ((Principal.Janela)ParentForm).JanelaLancamentoAtualizar(livro);
                    }

                    if (index < lstLivros.Items.Count)
                    {
                        lstLivros.Items[(int)index].Selected = true;
                    }
                    else if (lstLivros.Items.Count > 0)
                    {
                        lstLivros.Items[lstLivros.Items.Count - 1].Selected = true;
                    }                    
                }
            }
            catch (Exception ex)
            {
                Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
            }
        }

        private void toolBtn_Renomear_Click(object sender, EventArgs e)
        {
            lstLivros.SelectedItems[0].BeginEdit();
        }

        private void lstLivros_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Label) && e.Label.Trim() != string.Empty)
            {
                ListView lstLivros = (ListView)sender;
                try
                {
                    LivroCaixa livro = Mp.Ler(int.Parse(lstLivros.Items[e.Item].SubItems[3].Text));
                    livro.Nome = e.Label;
                    Mp.Alterar(livro);
                    ((Principal.Janela)ParentForm).JanelaLancamentoAtualizar(livro);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("constraint"))
                    {
                        Bibliotecas.MessageBox.Show("Escolha outro nome. Este já existe.", ControleFinanceiro.Bibliotecas.MessageBoxTipo.Informativo);
                    }
                    else
                    {
                        Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
                    }
                    e.CancelEdit = true;
                }
            }
            else
            {
                e.CancelEdit = true;
            }
        }

        private void lstLivros_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                LivroCaixa livroCaixa = LivroObterSelecionado();

                Principal.Janela janelaPrincipal = (Principal.Janela)this.ParentForm;
                janelaPrincipal.JanelaLancamentoAbrir(livroCaixa);
            }
            catch (Exception ex)
            {
                Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
            }
        }

        private void toolBtn_MostrarTodos_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            btn.Checked = !btn.Checked;
            LivrosCarregar();
        }

        private void lstLivros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (e.KeyCode == (Keys.LButton | Keys.MButton | Keys.Back)))
            {
                lstLivros_DoubleClick(sender, e);
            }
            else if (e.KeyCode == Keys.Insert && (e.KeyCode == (Keys.LButton | Keys.MButton | Keys.Back | Keys.Space)))
            {
                if (toolBtn_Incluir.Enabled)
                {
                    toolBtn_Incluir.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Delete && (e.KeyCode == (Keys.RButton | Keys.MButton | Keys.Back | Keys.Space)))
            {
                if (toolBtn_Excluir.Enabled)
                {
                    toolBtn_Excluir.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                if (toolBtn_Renomear.Enabled)
                {
                    toolBtn_Renomear.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                if (toolBtn_Ativar.Enabled)
                {
                    toolBtn_Ativar.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
            {
                if (toolBtn_Desativar.Enabled)
                {
                    toolBtn_Desativar.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.T && e.Modifiers == Keys.Control)
            {
                if (toolBtn_MostrarTodos.Enabled)
                {
                    toolBtn_MostrarTodos.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {
                toolBtn_ModoExibicao_ButtonClick(toolBtn_ModoExibicao, e);
            }
        }

        #endregion

    }
}