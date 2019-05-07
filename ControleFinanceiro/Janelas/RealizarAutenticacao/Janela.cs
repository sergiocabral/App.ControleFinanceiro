using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.ManipuladorDoProcesso;
using ControleFinanceiro.Bibliotecas.Exception;

namespace ControleFinanceiro.Janelas.RealizarAutenticacao
{
    public partial class Janela : JanelaBaseComum
    {
        private int tentativasDeAutenticacao;
        public int TentativasDeAutenticacao
        {
            get
            {
                return tentativasDeAutenticacao; 
            }
            set
            {
                tentativasDeAutenticacao = value;
                if (TentativasDeAutenticacao > 0 && TentativasDeAutenticacao != Mp.TentativasDeAutenticacao)
                {
                    lblTentativas.Text = "Tentativas restantes: " + TentativasDeAutenticacao;
                }
                else
                {
                    lblTentativas.Text = "";
                }
            }
        }

        private bool autenticacaoFeita;
        public bool AutenticacaoFeita
        {
            get { return autenticacaoFeita; }
            set { autenticacaoFeita = value; }
        }

        public Janela()
        {
            InitializeComponent();
            Autenticar();
            if (!AutenticacaoFeita)
            {
                TentativasDeAutenticacao = Mp.TentativasDeAutenticacao;
                ShowDialog();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private MpAutenticacao Mp
        {
            get
            {
                if (mp == null)
                {
                    mp = new MpAutenticacao();
                }
                return (MpAutenticacao)mp;
            }
        }

        /// <summary>
        /// Efetua a autenticação no sistema.
        /// </summary>
        private void Autenticar()
        {
            TentativasDeAutenticacao--;
            AutenticacaoFeita = Mp.SenhaAutenticar(txtSenha.Text);
            if (AutenticacaoFeita || TentativasDeAutenticacao == 0)
            {
                if (AutenticacaoFeita)
                {
                    Mp.UltimoAcessoRegistrarInformacoes();
                }
                Hide();
            }
            else
            {
                txtSenha.Text = string.Empty;
                txtSenha.Focus();
            }
        }

    }
}