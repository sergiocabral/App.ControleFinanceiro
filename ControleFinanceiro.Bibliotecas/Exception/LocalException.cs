using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.Exception
{
    public class LocalException : System.Exception
    {
        public LocalException() : base() { }
        public LocalException(string message) : base(message) { }
        public LocalException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
