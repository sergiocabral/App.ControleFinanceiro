using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.ManipuladorDoProcesso;
using ControleFinanceiro.Bibliotecas.Exception;

namespace ControleFinanceiro.Janelas.RealizarConexao
{
    public partial class Janela : JanelaBaseComum
    {

        #region Propriedades

        private MpConexao Mp
        {
            get
            {
                if (mp == null)
                {
                    mp = new MpConexao();
                }
                return (MpConexao)mp;
            }
        }

        private string conexaoStatus;
        public string ConexaoStatus
        {
            get
            {
                return conexaoStatus;
            }
            set
            {
                conexaoStatus = value;
                txtStatus.Text = conexaoStatus;
            }
        }

        public bool ConexaoEstabelecida
        {
            get
            {
                return string.IsNullOrEmpty(ConexaoStatus);
            }
        }

        #endregion

        #region Métodos

        public Janela()
        {
            InitializeComponent();
            Conectar();
        }

        /// <summary>
        /// Efetua a conexão com o banco de dados.
        /// </summary>
        private void Conectar()
        {
            try
            {
                Mp.Conexao.Conectado = true;
                ConexaoStatus = string.Empty;
            }
            catch (LocalException ex)
            {
                ConexaoStatus = ex.Message;
            }
            DefinirValoresConexaoParaTela();
            VerificarJanelaExibicao();
        }

        /// <summary>
        /// Atualiza os controles da tela com base na conexão com o banco de dados.
        /// </summary>
        private void DefinirValoresConexaoParaTela()
        {
            txtUsuario.Text = Mp.Conexao.ConexaoUsuario;
            txtSenha.Text = "";
            txtServidor.Text = Mp.Conexao.ConexaoServidor;
            txtBanco.Text = Mp.Conexao.ConexaoBanco;
        }

        /// <summary>
        /// Atualiza a conexão com o banco de dados com base nos controles da tela.
        /// </summary>
        private void DefinirValoresTelaParaConexao()
        {
            Mp.Conexao.ConexaoUsuario = txtUsuario.Text;
            Mp.Conexao.ConexaoSenha = txtSenha.Text;
            Mp.Conexao.ConexaoServidor = txtServidor.Text;
            Mp.Conexao.ConexaoBanco = txtBanco.Text;
        }

        private void VerificarFocoDosControles()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Focus();
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.Focus();
            }
            else if (string.IsNullOrEmpty(txtServidor.Text))
            {
                txtServidor.Focus();
            }
            else if (string.IsNullOrEmpty(txtBanco.Text))
            {
                txtBanco.Focus();
            }
            else
            {
                txtSenha.Focus();
            }
        }

        private void VerificarJanelaExibicao()
        {
            if (!string.IsNullOrEmpty(ConexaoStatus))
            {
                if (!Visible)
                {
                    ShowDialog();
                }
            }
            else
            {
                Hide();
            }
            VerificarFocoDosControles();
        }

        #endregion

        #region Eventos

        private void Janela_Shown(object sender, EventArgs e)
        {
            VerificarFocoDosControles();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            DefinirValoresTelaParaConexao();
            Conectar();
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            txtStatus.Text = ConexaoStatus;
        }

        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        #endregion
    }
}