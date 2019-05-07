using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Bibliotecas.Exception;

namespace ControleFinanceiro.BancoDeDados.Exception
{
    class ConexaoException : LocalException
    {
        public ConexaoException() : base() { }
        public ConexaoException(string message) : base(message) { }
        public ConexaoException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
