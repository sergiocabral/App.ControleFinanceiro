using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.ManipuladorDeDados;
using ControleFinanceiro.Bibliotecas.Exception;
using ControleFinanceiro.Entidades;
using ControleFinanceiro.Bibliotecas.Interface;

namespace ControleFinanceiro.ManipuladorDoProcesso
{
    public class MpBaseEntidade<T> : MpBase where T : Entidade
    {
        MdBaseEntidade<T> md;
        public MdBaseEntidade<T> Md
        {
            get { return md; }
            set { md = value; }
        }

        public T Ler(int id)
        {
            return md.Ler(id);
        }

        public T Ler(T entidade)
        {
            return md.Ler(entidade);
        }

        public T Ler(string propriedade, string valor)
        {
            return md.Ler(propriedade, valor);
        }

        public IList<T> Listar()
        {
            return md.Listar();
        }

        public void Excluir(int id)
        {
            md.Excluir(id);
        }

        public void Excluir(T entidade)
        {
            md.Excluir(entidade);
        }

        public T Alterar(T entidade)
        {
            return md.Alterar(entidade);
        }
        
    }
}
