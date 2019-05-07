using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.Exception
{
    public class MsgAlertaException : MsgException
    {
        public MsgAlertaException() : base() { }
        public MsgAlertaException(string message) : base(message) { }
        public MsgAlertaException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
