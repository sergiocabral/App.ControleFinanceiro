using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.Exception
{
    public class MsgException : LocalException
    {
        public MsgException() : base() { }
        public MsgException(string message) : base(message) { }
        public MsgException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
