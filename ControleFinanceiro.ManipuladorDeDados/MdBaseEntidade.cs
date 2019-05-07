using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Bibliotecas.Interface;
using System.Data;
using System.Reflection;

namespace ControleFinanceiro.ManipuladorDeDados
{
    public abstract class MdBaseEntidade<T> : MdBase where T : Entidade
    {
        private T entidadeModelo;
        public T EntidadeModelo
        {
            get { return entidadeModelo; }
            set { entidadeModelo = value; }
        }

        protected T Ler_(string campo, object valor)
        {
            T entidade = null;

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("param", valor);

            string sql = "select * from " + EntidadeModelo.BancoTabela + " where " + campo + " = :param";

            DataTable dataTable = MdConexao.Conexao.SqlExecutar(sql, parametros);

            if (dataTable.Rows.Count > 0)
            {
                entidade = RowParaEntidade(dataTable.Rows[0]);
            }

            return entidade;
        }

        public T Ler(T entidade)
        {
            entidade = Ler(Convert.ToInt32(entidade.Id));
            return entidade;
        }

        public T Ler(int id)
        {
            return Ler_(EntidadeModelo.ConverterParaBanco("Id"), id);
        }

        public T Ler(string propriedade, string valor)
        {
            return Ler_(EntidadeModelo.ConverterParaBanco(propriedade), valor);
        }

        public IList<T> Listar(T filtro)
        {
            IDictionary<string, object> parametros = filtro == null ? null : ObterParametros(filtro);
            string sqlFiltro = filtro == null ? null : ObterFiltro(filtro);
            string sql = "select * from " + EntidadeModelo.BancoTabela + (string.IsNullOrEmpty(sqlFiltro) ? string.Empty : " where " + sqlFiltro);

            DataTable dataTable = MdConexao.Conexao.SqlExecutar(sql, parametros);

            List<T> listaEntidade = new List<T>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                listaEntidade.Add(RowParaEntidade(dataTable.Rows[i]));
            }

            return listaEntidade;
        }

        public IList<T> Listar()
        {
            return Listar(null);
        }

        public void Excluir(int id)
        {
            IDictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("paramId", id);
            string sql = "delete from " + EntidadeModelo.BancoTabela + " where " + EntidadeModelo.ConverterParaBanco("Id") + " = :paramId";

            MdConexao.Conexao.SqlExecutarComando(sql, parametros);
        }
        
        public void Excluir(T entidade)
        {
            Excluir(Convert.ToInt32(entidade.Id));
        }

        public T Alterar(T entidade)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            StringBuilder sqlInsertEx1 = new StringBuilder();
            StringBuilder sqlInsertEx2 = new StringBuilder();
            StringBuilder sqlUpdateEx1 = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in EntidadeModelo.NomesObjetoBanco)
            {
                //Reflection para pegar a proprierdade prop.Key en (T)entidade
                parametros.Add("param" + prop.Key, entidade.GetType().GetProperty(prop.Key).GetValue(entidade, null));

                if (prop.Key != "Id")
                {
                    sqlInsertEx1.Append("," + prop.Value);
                    sqlInsertEx2.Append(",:param" + prop.Key);

                    sqlUpdateEx1.Append("," + prop.Value + " = :param" + prop.Key);
                }
            }
            if (sqlUpdateEx1.Length > 0)
            {
                sqlUpdateEx1.Remove(0, 1); //Remove a vírgula inicial.
            }

            string sqlSelect = "select count(*) from " + EntidadeModelo.BancoTabela + " where " + EntidadeModelo.ConverterParaBanco("Id") + " = :paramId";
            string sqlInsert = "insert into " + EntidadeModelo.BancoTabela + "(" + EntidadeModelo.ConverterParaBanco("Id") + sqlInsertEx1.ToString() + ") values((select coalesce(max(" + EntidadeModelo.ConverterParaBanco("Id") + "),0) + 1 from " + EntidadeModelo.BancoTabela + ")" + sqlInsertEx2.ToString() + ")";
            string sqlUpdate = "update " + EntidadeModelo.BancoTabela + " set " + sqlUpdateEx1.ToString() + " where " + EntidadeModelo.ConverterParaBanco("Id") + " = :paramId";

            if (MdConexao.SqlExecutar_InsertOuUpdate(sqlSelect, sqlInsert, sqlUpdate, parametros) == SqlExecutar_InsertOuUpdateType.Insert)
            {
                sqlSelect = "select max(" + EntidadeModelo.ConverterParaBanco("Id") + ") from " + EntidadeModelo.BancoTabela;
                int id = Convert.ToInt32(MdConexao.Conexao.SqlExecutarConsulta(sqlSelect, null));
                return Ler(id);
            }
            else
            {
                return Ler(Convert.ToInt32(entidade.Id));
            }
        }

        protected abstract T RowParaEntidade(DataRow row);
        protected abstract IDictionary<string, object> ObterParametros(T entidade);
        protected abstract string ObterFiltro(T entidade);

    }
}
