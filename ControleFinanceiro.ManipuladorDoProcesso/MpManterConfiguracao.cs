using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.ManipuladorDeDados;
using ControleFinanceiro.Bibliotecas.Exception;

namespace ControleFinanceiro.ManipuladorDoProcesso
{
    public class MpManterConfiguracao : MpBase
    {
        MdConfiguracao mdConfiguracao = new MdConfiguracao();

        public int TentativasDeAutenticacao
        {
            get { return mdConfiguracao.TentativasDeAutenticacao; }
            set { mdConfiguracao.TentativasDeAutenticacao = value; }
        }

        public string InformacoesUltimoAcesso
        {
            get { return mdConfiguracao.InformacoesUltimoAcesso; }
        }

        public string InformacoesAcessoAtual
        {
            get { return mdConfiguracao.InformacoesAcessoAtual; }
        }

        public bool SenhaAutenticar(string senha)
        {
            return mdConfiguracao.SenhaAutenticar(senha);
        }

        public void SenhaAlterar(string senhaAtual, string senhaNova, string senhaRepeticao)
        {
            if (mdConfiguracao.SenhaAutenticar(senhaAtual))
            {
                if (senhaNova == senhaRepeticao)
                {
                    mdConfiguracao.SenhaDefinir(senhaNova);
                }
                else
                {
                    throw new MsgAlertaException("A nova senha não foi repetida corretamente.");
                }
            }
            else
            {
                throw new MsgErroException("A senha atual não está correta.");
            }
        }
    }
}
