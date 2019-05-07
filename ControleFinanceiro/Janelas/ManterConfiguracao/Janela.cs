using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleFinanceiro.ManipuladorDoProcesso;
using ControleFinanceiro.Bibliotecas.Exception;

namespace ControleFinanceiro.Janelas.ManterConfiguracao
{
    public partial class Janela : JanelaBaseDockTool
    {

        #region Propriedades

        private MpManterConfiguracao Mp
        {
            get
            {
                if (mp == null)
                {
                    mp = new MpManterConfiguracao();
                }
                return (MpManterConfiguracao)mp;
            }
        }

        #endregion

        #region Métodos

        public Janela()
        {
            InitializeComponent();
            AtualizarInformacoes(true);
        }

        private void AtualizarInformacoes(bool focus)
        {
            try
            {
                AtualizarInformacoes_Informacoes(focus);
                AtualizarInformacoes_TrocarSenha(focus);
                AtualizarInformacoes_TentativasLogon(focus);
            }
            catch (Exception ex)
            {
                if (focus)
                {
                    Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
                }
                else
                {
                    throw;
                }
            }
        }

        private void AtualizarInformacoes_TrocarSenha(bool focus)
        {
            txtSenhaAtual.Text = string.Empty;
            txtSenhaNova.Text = string.Empty;
            txtSenhaRepeticao.Text = string.Empty;
            if (focus)
            {
                txtSenhaAtual.Focus();
            }
        }

        private void AtualizarInformacoes_Informacoes(bool focus)
        {
            string acessoAtual = Mp.InformacoesAcessoAtual;
            string acessoUltimo = Mp.InformacoesUltimoAcesso;
            
            StringBuilder info = new StringBuilder();

            if (string.IsNullOrEmpty(acessoUltimo))
            {
                info.Append("Este é seu primeiro acesso!\n\n");
            }

            info.Append("Informações do acesso atual:\n");
            info.Append(acessoAtual + "\n");

            if (!string.IsNullOrEmpty(acessoUltimo))
            {
                info.Append("\nInformações do último acesso:\n");
                info.Append(acessoUltimo + "\n");
            }

            txtInformacoes.Text = info.ToString();

            if (focus)
            {
                txtInformacoes.Focus();
            }
        }

        private void AtualizarInformacoes_TentativasLogon(bool focus)
        {
            txtTentativasLogon.Text = Mp.TentativasDeAutenticacao.ToString();
            if (focus)
            {
                txtTentativasLogon.Focus();
            }
        }

        #endregion

        #region Eventos

        private void btnTentativasLogon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTentativasLogon.Text))
            {
                try
                {
                    Mp.TentativasDeAutenticacao = int.Parse(txtTentativasLogon.Text);
                    Bibliotecas.MessageBox.Show(Bibliotecas.Properties.Resources.Msg_GravacaoSucesso, ControleFinanceiro.Bibliotecas.MessageBoxTipo.Informativo);
                }
                catch (Exception ex)
                {
                    Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                AtualizarInformacoes(false);
            }
            catch (Exception)
            {
                //Supressão do erro pois é uma tarefa background.
            }
        }

        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                Mp.SenhaAlterar(txtSenhaAtual.Text, txtSenhaNova.Text, txtSenhaRepeticao.Text);
                AtualizarInformacoes_TrocarSenha(true);
                Bibliotecas.MessageBox.Show("A senha foi alterada com sucesso.", ControleFinanceiro.Bibliotecas.MessageBoxTipo.Informativo);
            }
            catch (MsgException ex)
            {                
                AtualizarInformacoes_TrocarSenha(true);
                Bibliotecas.MessageBox.Show(ex.Message, ControleFinanceiro.Bibliotecas.MessageBoxTipo.Alerta);
            }
            catch (Exception ex)
            {
                Bibliotecas.MessageBox.Show(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_OperacaoErro, ex.Message), ControleFinanceiro.Bibliotecas.MessageBoxTipo.Erro);
            }
        }

        private void Janela_Enter(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void Janela_Leave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void txtTentativasLogon_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox txtTentativasLogon = (MaskedTextBox)sender;
            btnTentativasLogon.Enabled = (!string.IsNullOrEmpty(txtTentativasLogon.Text) && txtTentativasLogon.Text.Trim() != string.Empty);
        }

        #endregion

    }
}