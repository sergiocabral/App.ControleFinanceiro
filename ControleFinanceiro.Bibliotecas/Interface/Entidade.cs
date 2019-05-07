using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Bibliotecas.Exception;

namespace ControleFinanceiro.Bibliotecas.Interface
{
    public abstract class Entidade
    {
        private int? id;
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }

        private IDictionary<string, string> nomesObjetoBanco = new Dictionary<string, string>();
        public IDictionary<string, string> NomesObjetoBanco
        {
            get { return nomesObjetoBanco; }
        }

        private string bancoTabela = null;
        public string BancoTabela
        {
            get { return bancoTabela; }
            set { bancoTabela = value; }
        }

        public Entidade()
        {
            InicializarNomeObjetoBanco();
        }

        protected abstract void InicializarNomeObjetoBanco();

        public string ConverterParaBanco(string nomeObjeto)
        {
            foreach (KeyValuePair<string, string> valor in nomesObjetoBanco)
            {
                if (nomeObjeto != null && valor.Key.ToLowerInvariant().Trim() == nomeObjeto.ToLowerInvariant().Trim())
                {
                    return valor.Value;
                }
            }

            throw new LocalException(string.Format("A propriedade do objeto \"{0}\" não foi relacionada ao banco de dados.", nomeObjeto));
        }

        public string ConverterParaObjeto(string nomeBanco)
        {
            foreach (KeyValuePair<string, string> valor in nomesObjetoBanco)
            {
                if (nomesObjetoBanco != null && valor.Value.ToLowerInvariant().Trim() == nomeBanco.ToLowerInvariant().Trim())
                {
                    return valor.Key;
                }
            }
            throw new LocalException(string.Format("O nome de banco de dados \"{0}\" não foi relacionado a uma propriedade do objeto.", nomeBanco));
        }

    }
}
