using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.Exception
{
    public class TransparenteException : LocalException
    {
        public TransparenteException() : base() { }
        public TransparenteException(string message) : base(message) { }
        public TransparenteException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
