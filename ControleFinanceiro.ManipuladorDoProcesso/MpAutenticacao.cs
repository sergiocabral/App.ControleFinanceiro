using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.ManipuladorDeDados;
using ControleFinanceiro.Bibliotecas.Interface;
using System.Windows.Forms;

namespace ControleFinanceiro.ManipuladorDoProcesso
{
    public class MpAutenticacao : MpBase
    {
        MdConfiguracao mdAutenticacao = new MdConfiguracao();
        
        public int TentativasDeAutenticacao
        {
            get
            {
                return mdAutenticacao.TentativasDeAutenticacao;
            }
        }

        public bool SenhaAutenticar(string senha)
        {
            return mdAutenticacao.SenhaAutenticar(senha);            
        }

        public void UltimoAcessoRegistrarInformacoes()
        {
            StringBuilder informacoes = new StringBuilder();
            informacoes.Append(string.Format("Data e Hora: {0} {1}. \n", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
            informacoes.Append(string.Format("Usuário: {0}\\{1}. \n", SystemInformation.UserDomainName, SystemInformation.UserName));
            informacoes.Append(string.Format("Computador: {0}.\n", SystemInformation.ComputerName));

            mdAutenticacao.InformacoesAcessoAtual = informacoes.ToString();
        }
    }
}
