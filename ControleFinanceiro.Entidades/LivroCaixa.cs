using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Bibliotecas.Interface;

namespace ControleFinanceiro.Entidades
{
    public class LivroCaixa : Entidade
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private double? saldo;
        public double? Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        private char? ativo;
        public char? Ativo
        {
            get { return ativo; }
            set { 
                if (value == null)
                {
                    ativo = value;
                }
                else if (Convert.ToString(value).ToUpper() == "S")
                {
                    ativo = 'S';
                }
                else
                {
                    ativo = 'N';
                }
            }
        }

        public bool AtivoEx1
        {
            get
            {
                if (Ativo == null)
                {
                    return false;
                }
                else 
                {
                    return (Ativo.ToString().ToUpper() == "S");
                }
            }
            set
            {
                Ativo = value ? 'S' : 'N';
            }
        }

        public string AtivoEx2
        {
            get
            {
                if (Ativo == null)
                {
                    return null;
                }
                else if (Ativo.ToString().ToUpper() == "S")
                {
                    return "Ativado";
                }
                else
                {
                    return "Desativado";
                }
            }
        }

        protected override void InicializarNomeObjetoBanco()
        {
            BancoTabela = "tb_livro_caixa";
            NomesObjetoBanco["Id"] = "lica_sq_id";
            NomesObjetoBanco["Nome"] = "lica_nm_livro";
            NomesObjetoBanco["Descricao"] = "lica_ds_livro";
            NomesObjetoBanco["Saldo"] = "lica_vl_saldo";
            NomesObjetoBanco["Ativo"] = "lica_in_ativo";
        }
    }
}
