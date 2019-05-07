using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ControleFinanceiro.Bibliotecas.Interface
{
    public interface IConexao
    {
        string ConexaoUsuario { get; set; }
        string ConexaoSenha { get; set; }
        string ConexaoServidor { get; set; }
        string ConexaoBanco { get; set; }
        IDbConnection Conexao { get; }
        bool Conectado { get; set; }
        int SqlExecutarComando(string sql, IDictionary<string, object> parametros);
        DataTable SqlExecutar(string sql, IDictionary<string, object> parametros);
        object SqlExecutarConsulta(string sql, IDictionary<string, object> parametros);
    }
}
