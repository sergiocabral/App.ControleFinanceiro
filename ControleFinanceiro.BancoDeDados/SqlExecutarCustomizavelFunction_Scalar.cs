using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.Firebird;

namespace ControleFinanceiro.BancoDeDados
{
    internal class SqlExecutarCustomizavelFunction_Scalar : ISqlExecutarCustomizavelFunction
    {
        public object funcao(FbCommand command)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.FetchSize = 1;
            return command.ExecuteScalar();
        }
    }
}
