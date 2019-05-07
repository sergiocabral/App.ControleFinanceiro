using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.Firebird;
using System.Data;

namespace ControleFinanceiro.BancoDeDados
{
    internal class SqlExecutarCustomizavelFunction_Reader : ISqlExecutarCustomizavelFunction
    {
        public object funcao(FbCommand command)
        {
            command.CommandType = System.Data.CommandType.Text;

            DataTable dataTable = new DataTable();
            using (FbDataReader dataReader = command.ExecuteReader())
            {
                dataTable.BeginLoadData();
                dataTable.Load(dataReader);
                dataTable.EndLoadData();
            }

            return dataTable;
        }
    }
}
