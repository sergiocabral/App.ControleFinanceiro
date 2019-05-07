using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.Firebird;

namespace ControleFinanceiro.BancoDeDados
{
    internal interface ISqlExecutarCustomizavelFunction
    {
        object funcao(FbCommand command);
    }
}
