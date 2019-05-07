using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.ManipuladorDeDados;
using ControleFinanceiro.Bibliotecas.Interface;

namespace ControleFinanceiro.ManipuladorDoProcesso
{
    public class MpConexao : MpBase
    {
        MdConexao mdConexao = MdConexao.Instanciar();

        public IConexao Conexao
        {
            get
            {
                return this.mdConexao.Conexao;
            }
        }
    }
}
