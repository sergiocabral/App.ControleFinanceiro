using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Bibliotecas.Interface;
using ControleFinanceiro.BancoDeDados;

namespace ControleFinanceiro.ManipuladorDeDados
{
    public enum SqlExecutar_InsertOuUpdateType : int { Insert = 1, Update }

    public class MdConexao
    {
        private static MdConexao _this;

        private ConexaoFireBird conexao;
        public IConexao Conexao
        {
            get { return conexao; }
        }

        private MdConexao()
        {
            this.conexao = new ConexaoFireBird();
        }

        public static MdConexao Instanciar()
        {
            if (MdConexao._this == null)
            {
                MdConexao._this = new MdConexao();
            }

            return MdConexao._this;
        }

        /// <summary>
        /// Executa um comando SQL.
        /// </summary>
        /// <param name="sqlCount">SQL que retorna o total de registros na tabela.</param>
        /// <param name="sqlInsert">Executa este comando se o sqlCount = 0</param>
        /// <param name="sqlUpdate">Executa este comando se o sqlCount > 0</param>
        internal SqlExecutar_InsertOuUpdateType SqlExecutar_InsertOuUpdate(string sqlCount, string sqlInsert, string sqlUpdate, Dictionary<string, object> parametros)
        {
            if ((int)Conexao.SqlExecutarConsulta(sqlCount, parametros) == 0)
            {
                Conexao.SqlExecutarComando(sqlInsert, parametros);
                return SqlExecutar_InsertOuUpdateType.Insert;
            }
            else
            {
                Conexao.SqlExecutarComando(sqlUpdate, parametros);
                return SqlExecutar_InsertOuUpdateType.Update;
            }
        }
    }
}
