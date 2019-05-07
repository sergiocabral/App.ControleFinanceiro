using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.Exception
{
    public class MsgInformacaoLocalException : MsgException
    {
        public MsgInformacaoLocalException() : base() { }
        public MsgInformacaoLocalException(string message) : base(message) { }
        public MsgInformacaoLocalException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
