using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.Entidades;
using ControleFinanceiro.ManipuladorDoProcesso;

namespace ControleFinanceiro.Janelas.ManterLancamento
{
    public partial class Janela : JanelaBaseDock
    {
        #region Propriedades

        LivroCaixa livroCaixaAtivo;
        public LivroCaixa LivroCaixaAtivo
        {
            get { return livroCaixaAtivo; }
        }

        private MpManterLancamento Mp
        {
            get
            {
                if (mp == null)
                {
                    mp = new MpManterLancamento();
                }
                return (MpManterLancamento)mp;
            }
        }

        #endregion

        #region Métodos

        public Janela(LivroCaixa livroCaixa)
        {
            InitializeComponent();            
            this.livroCaixaAtivo = livroCaixa;
            LivroCaixaAtualizar();            
        }

        public void LivroCaixaAtualizar()
        {
            LivroCaixa livroCaixaBanco = Mp.MpManterLivroCaixa.Ler(int.Parse(LivroCaixaAtivo.Id.ToString()));
            if (livroCaixaBanco == null)
            {
                Close();
            }
            else
            {
                Text = livroCaixaBanco.Nome;
            }

            livroCaixaAtivo = livroCaixaBanco;
        }

        #endregion

        #region Eventos

        private void Janela_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal.Janela janelaPrincipal = (Principal.Janela)this.ParentForm;
            janelaPrincipal.JanelaLancamentoFechar(livroCaixaAtivo);
        }

        #endregion

    }
}

