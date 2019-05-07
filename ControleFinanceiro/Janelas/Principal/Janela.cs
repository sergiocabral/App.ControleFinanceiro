using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.Bibliotecas.Exception;
using ControleFinanceiro.Entidades;

namespace ControleFinanceiro.Janelas.Principal
{
    public partial class Janela : JanelaBaseComum
    {
        #region Propriedades

        private List<ManterLancamento.Janela> janelasLancamentoLista;
        private List<ManterLancamento.Janela> JanelasLancamentoLista
        {
            get
            {
                if (janelasLancamentoLista == null)
                {
                    janelasLancamentoLista = new List<ManterLancamento.Janela>();
                }
                return janelasLancamentoLista;
            }
        }

        ManterConfiguracao.Janela janelaManterConfiguracao;
        public ManterConfiguracao.Janela JanelaManterConfiguracao
        {
            get
            {
                if (janelaManterConfiguracao == null || janelaManterConfiguracao.IsDisposed)
                {
                    janelaManterConfiguracao = new ManterConfiguracao.Janela();
                }
                return janelaManterConfiguracao;
            }
            set { janelaManterConfiguracao = value; }
        }

        ManterCategoria.Janela janelaManterCategoria;
        public ManterCategoria.Janela JanelaManterCategoria
        {
            get
            {
                if (janelaManterCategoria == null || janelaManterCategoria.IsDisposed)
                {
                    janelaManterCategoria = new ManterCategoria.Janela();
                }
                return janelaManterCategoria;
            }
            set { janelaManterCategoria = value; }
        }

        ManterLivroCaixa.Janela janelaManterLivroCaixa;
        public ManterLivroCaixa.Janela JanelaManterLivroCaixa
        {
            get
            {
                if (janelaManterLivroCaixa == null || janelaManterLivroCaixa.IsDisposed)
                {
                    janelaManterLivroCaixa = new ManterLivroCaixa.Janela();
                }
                return janelaManterLivroCaixa;
            }
            set { janelaManterLivroCaixa = value; }
        }

        #endregion

        #region Métodos

        public Janela()
        {
            InitializeComponent();
        }

        private void Autenticar()
        {
            try
            {
                Janelas.RealizarAutenticacao.Janela janela = new RealizarAutenticacao.Janela();
                if (janela.AutenticacaoFeita)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new MsgErroException(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_AutenticacaoErro, ex.Message), ex);
            }
            throw new TransparenteException();
        }

        public void Conectar()
        {
            try
            {
                Janelas.RealizarConexao.Janela janela = new Janelas.RealizarConexao.Janela();
                if (janela.ConexaoEstabelecida)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new MsgErroException(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_ConexaoErro, ex.Message), ex);
            }
            throw new TransparenteException();
        }

        private void AbrirJanela(JanelaBaseDock janela)
        {
            if (!janela.Visible)
            {
                janela.Show(pnlDockGeral);
                if (janela.Tag == null)
                {
                    janela.Tag = "definido posição da janela";
                    janela.DockState = Componente.DockPanel.Docking.DockState.DockRight;
                }
            }
            else
            {
                janela.Close();
            }
        }

        private void JanelaLancamentoFechar(ManterLancamento.Janela janela)
        {
            JanelasLancamentoLista.Remove(janela);
        }

        public void JanelaLancamentoFechar(LivroCaixa livroCaixa)
        {
            foreach (ManterLancamento.Janela janela in JanelasLancamentoLista)
            {
                if (janela.LivroCaixaAtivo.Id == livroCaixa.Id)
                {
                    JanelaLancamentoFechar(janela);
                    break;
                }
            }
        }

        public void JanelaLancamentoAbrir(LivroCaixa livroCaixa)
        {
            ManterLancamento.Janela janelaLancamento = null;

            foreach (ManterLancamento.Janela janela in JanelasLancamentoLista)
            {
                if (janela.LivroCaixaAtivo.Id == livroCaixa.Id)
                {
                    janelaLancamento = janela;
                    break;
                }
            }

            if (janelaLancamento == null)
            {
                janelaLancamento = new ManterLancamento.Janela(livroCaixa);
                JanelasLancamentoLista.Add(janelaLancamento);
            }

            janelaLancamento.Show(pnlDockGeral);
            if (janelaLancamento.Tag == null)
            {
                janelaLancamento.Tag = "definido posição da janela";
                janelaLancamento.DockState = Componente.DockPanel.Docking.DockState.Document;
            }
        }

        public void JanelaLancamentoAtualizar(LivroCaixa livro)
        {
            for (int i = 0; i < JanelasLancamentoLista.Count; i++)
            {
                if (livro == null || JanelasLancamentoLista[i].LivroCaixaAtivo.Id == livro.Id)
                {
                    JanelasLancamentoLista[i].LivroCaixaAtualizar();
                }
            }
        }

        #endregion

        #region Eventos

        private void Janela_Load(object sender, EventArgs e)
        {
            try
            {
                Conectar();
                Autenticar();
                mnuPrincipal_Livros.PerformClick();
            }
            catch (MsgException ex)
            {
                string msgErro = (ex.InnerException != null && ex.InnerException.GetType() == typeof(LocalException)) ? ex.InnerException.Message : ex.Message;
                ControleFinanceiro.Bibliotecas.MessageBox.Show(msgErro, ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
                Close();
            }
            catch (TransparenteException)
            {
                Close();
            }
        }

        private void mnuPrincipal_Sobre_Click(object sender, EventArgs e)
        {
            Sobre.Janela janela = new Sobre.Janela();
            janela.ShowDialog();
        }

        private void mnuPrincipal_Configuracoes_Click(object sender, EventArgs e)
        {
            AbrirJanela(JanelaManterConfiguracao);
        }

        private void mnuPrincipal_Categorias_Click(object sender, EventArgs e)
        {
            AbrirJanela(JanelaManterCategoria);
        }

        private void mnuPrincipal_Livros_Click(object sender, EventArgs e)
        {
            AbrirJanela(JanelaManterLivroCaixa);
        }

        private void mnuPrincipal_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Janela_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        #endregion
    }
}