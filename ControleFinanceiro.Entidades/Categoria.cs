using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Bibliotecas.Interface;

namespace ControleFinanceiro.Entidades
{
    public class Categoria : Entidade
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected override void InicializarNomeObjetoBanco()
        {
            BancoTabela = "tb_categoria";
            NomesObjetoBanco["Id"] = "cate_sq_id";
            NomesObjetoBanco["Nome"] = "cate_nm_categoria";
        }
    }
}
