using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.Exception
{
    public class MsgErroException : MsgException
    {
        public MsgErroException() : base() { }
        public MsgErroException(string message) : base(message) { }
        public MsgErroException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
