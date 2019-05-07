using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.ManipuladorDeDados;
using ControleFinanceiro.Bibliotecas.Exception;
using ControleFinanceiro.Entidades;

namespace ControleFinanceiro.ManipuladorDoProcesso
{
    public class MpManterLancamento : MpBaseEntidade<LivroCaixa>
    {
        private MpManterLivroCaixa mpManterLivroCaixa;
        public MpManterLivroCaixa MpManterLivroCaixa
        {
            get
            {
                if (mpManterLivroCaixa == null)
                {
                    mpManterLivroCaixa = new MpManterLivroCaixa();
                }
                return mpManterLivroCaixa;
            }
        }

        public MpManterLancamento()
        {
            Md = new MdLivroCaixa();
        }
    }
}
