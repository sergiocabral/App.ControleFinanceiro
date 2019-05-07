using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Bibliotecas.Exception;

namespace ControleFinanceiro.BancoDeDados.Exception
{
    class ArquivoDeConexaoXmlException : ConexaoException
    {
        public ArquivoDeConexaoXmlException() : base() { }
        public ArquivoDeConexaoXmlException(string message) : base(message) { }
        public ArquivoDeConexaoXmlException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
