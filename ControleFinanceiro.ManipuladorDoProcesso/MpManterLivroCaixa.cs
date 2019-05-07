using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.ManipuladorDeDados;
using ControleFinanceiro.Bibliotecas.Exception;
using ControleFinanceiro.Entidades;

namespace ControleFinanceiro.ManipuladorDoProcesso
{
    public class MpManterLivroCaixa : MpBaseEntidade<LivroCaixa>
    {
        public MpManterLivroCaixa()
        {
            Md = new MdLivroCaixa();
        }

        public LivroCaixa CriarNovo(string mascara)
        {
            LivroCaixa novo = new LivroCaixa();
            novo.AtivoEx1 = true;
            novo.Nome = (new Random(DateTime.Now.Millisecond)).NextDouble().ToString();
            novo = Md.Alterar(novo);
            novo.Nome = string.Format(mascara, novo.Id.ToString().PadLeft(2,'0'));
            novo = Md.Alterar(novo);
            return novo;
        }
    }
}
