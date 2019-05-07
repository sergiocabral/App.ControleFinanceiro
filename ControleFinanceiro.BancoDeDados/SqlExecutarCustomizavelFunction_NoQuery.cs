using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.Firebird;

namespace ControleFinanceiro.BancoDeDados
{
    internal class SqlExecutarCustomizavelFunction_NoQuery : ISqlExecutarCustomizavelFunction
    {
        public object funcao(FbCommand command)
        {
            command.CommandType = System.Data.CommandType.Text;
            return command.ExecuteNonQuery();
        }
    }
}
