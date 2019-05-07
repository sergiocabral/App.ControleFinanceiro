using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.ManipuladorDeDados;
using ControleFinanceiro.Bibliotecas.Exception;
using ControleFinanceiro.Entidades;

namespace ControleFinanceiro.ManipuladorDoProcesso
{
    public class MpManterCategoria : MpBaseEntidade<Categoria>
    {
        public MpManterCategoria()
        {
            Md = new MdCategoria();
        }
    }
}
