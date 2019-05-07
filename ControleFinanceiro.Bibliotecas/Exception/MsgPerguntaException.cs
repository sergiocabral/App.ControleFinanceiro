using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.Exception
{
    public class MsgPerguntaException : MsgException
    {
        public MsgPerguntaException() : base() { }
        public MsgPerguntaException(string message) : base(message) { }
        public MsgPerguntaException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
