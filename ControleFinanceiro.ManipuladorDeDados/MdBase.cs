using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Bibliotecas.Interface;

namespace ControleFinanceiro.ManipuladorDeDados
{
    public class MdBase
    {
        private MdConexao mdConexao = MdConexao.Instanciar();
        public MdConexao MdConexao
        {
            get { return mdConexao; }
            set { mdConexao = value; }
        }
    }
}
