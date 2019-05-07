using System;
using System.Collections.Generic;
using System.Text;
using FirebirdSql.Data.Firebird;
using System.Data;
using System.Xml;
using ControleFinanceiro.BancoDeDados.Exception;
using ControleFinanceiro.Bibliotecas.Exception;
using ControleFinanceiro.Bibliotecas.Interface;
using System.IO;
using System.Text.RegularExpressions;

namespace ControleFinanceiro.BancoDeDados
{
    public class ConexaoFireBird : IConexao
    {
        string conexaoUsuario;
        string conexaoSenha;
        string conexaoServidor;
        string conexaoBanco;
        private FbConnection fbConnection;
        private Dictionary<string, string> connectionStringDictionary;

        public ConexaoFireBird()
        {
            ConexaoInicializar();
        }

        public string ConexaoUsuario
        {
            get { return conexaoUsuario; }
            set
            {
                conexaoUsuario = value;
                ConnectionStringDictionary["User"] = value;
            }
        }
        public string ConexaoSenha
        {
            get { return conexaoSenha; }
            set
            {
                conexaoSenha = value;
                ConnectionStringDictionary["Password"] = value;
            }
        }
        public string ConexaoServidor
        {
            get { return conexaoServidor; }
            set
            {
                conexaoServidor = value;
                ConnectionStringDictionary["DataSource"] = value;
            }
        }
        public string ConexaoBanco
        {
            get { return conexaoBanco; }
            set
            {
                conexaoBanco = value;

                if (!conexaoBanco.Contains("\\"))
                {
                    DirectoryInfo di = new DirectoryInfo(".");
                    conexaoBanco = di.FullName + "\\" + conexaoBanco;
                }

                ConnectionStringDictionary["Database"] = conexaoBanco;
            }
        }

        public IDbConnection Conexao
        {
            get
            {
                return fbConnection;
            }
        }

        public Dictionary<string, string> ConnectionStringDictionary
        {
            get { return connectionStringDictionary; }
        }
        public string ConnectionString
        {
            get
            {
                StringBuilder connectionString = new StringBuilder();
                if (ConnectionStringDictionary != null)
                {
                    foreach (KeyValuePair<string, string> valor in ConnectionStringDictionary)
                    {
                        connectionString.Append(valor.Key);
                        connectionString.Append("=");
                        connectionString.Append(valor.Value);
                        connectionString.Append(";");
                    }
                }
                return connectionString.ToString();
            }
        }

        public bool Conectado
        {
            get
            {
                return Conexao.State == ConnectionState.Open;
            }
            set
            {
                if (value)
                {
                    try
                    {
                        fbConnection.ConnectionString = ConnectionString;
                        Conexao.Open();
                    }
                    catch (FbException ex)
                    {
                        if (ex.Message.ToLower().Contains("unable to complete network request to host"))
                        {
                            throw new ConexaoException(string.Format(ControleFinanceiro.BancoDeDados.Properties.Resources.Msg_ConexaoErro_ServidorErro, ConexaoServidor), ex);
                        }
                        else if (ex.Message.ToLower().Contains("user name and password"))
                        {
                            throw new ConexaoException(string.Format(ControleFinanceiro.BancoDeDados.Properties.Resources.Msg_ConexaoErro_LoginInvalido), ex);
                        }
                        else if (ex.Message.ToLower().Contains("i/o"))
                        {
                            throw new ConexaoException(string.Format(ControleFinanceiro.BancoDeDados.Properties.Resources.Msg_ConexaoErro_BancoErro, ConexaoBanco), ex);
                        }
                        else
                        {
                            throw new ConexaoException(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_ConexaoErro, ex.Message), ex);
                        }
                    }
                }
                else
                {
                    Conexao.Close();
                }
            }
        }

        /// <summary>
        /// Prepara a conexão com o banco de dados.
        /// Define a Connextionstring
        /// </summary>
        private void ConexaoInicializar()
        {
            ConnectionStringInicializarDoXml();
            fbConnection = new FbConnection();
        }

        /// <summary>
        /// Carrega os dados da conexão no arquivo Xml para a propriedade this.Connectionstring
        /// </summary>
        private void ConnectionStringInicializarDoXml()
        {
            string arquivoXml = ControleFinanceiro.Bibliotecas.Properties.Resources.XmlConfig_Arquivo_Nome;
            string tagConnectionString = ControleFinanceiro.Bibliotecas.Properties.Resources.XmlConfig_Tag_ConnectionString;
            string tagConnectionStringFirebird = ControleFinanceiro.BancoDeDados.Properties.Resources.XmlConfig_Tag_ConnectionString_Firebird;
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(arquivoXml);
            }
            catch (XmlException ex)
            {
                throw new ArquivoDeConexaoXmlException(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_ArquivoConfigXml_Invalido, arquivoXml), ex);
            }
            catch (FileNotFoundException ex)
            {
                throw new ArquivoDeConexaoXmlException(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_ArquivoConfigXml_NaoEncontrado, arquivoXml), ex);
            }
            catch (System.Exception ex)
            {
                throw new ArquivoDeConexaoXmlException(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_ArquivoConfigXml_NaoCarregado, arquivoXml), ex);
            }

            foreach (XmlNode nodeConnectionString in xmlDoc.ChildNodes)
            {
                if (nodeConnectionString.Name == tagConnectionString)
                {
                    foreach (XmlNode nodeConnectionStringFirebird in nodeConnectionString.ChildNodes)
                    {
                        if (nodeConnectionStringFirebird.Name == tagConnectionStringFirebird)
                        {
                            connectionStringDictionary = new Dictionary<string, string>();

                            foreach (XmlNode nodeParam in nodeConnectionStringFirebird.ChildNodes)
                            {
                                ConnectionStringDictionary[nodeParam.Name.Replace("_", " ")] = nodeParam.InnerText;
                            }

                            PropriedadesConexaoInicializar();

                            break;
                        }
                    }

                    if (ConnectionStringDictionary != null)
                    {
                        break;
                    }
                }
            }

            if (ConnectionStringDictionary == null)
            {
                throw new ArquivoDeConexaoXmlException(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_ArquivoConfigXml_SemTag, arquivoXml, "<" + tagConnectionString + "><" + tagConnectionStringFirebird + ">...<" + tagConnectionStringFirebird + "><" + tagConnectionString + ">"));
            }
        }

        /// <summary>
        /// Inicializa as propriedades desta classe com os dados do arquivo Xml 
        /// que foram registrados em this.ConnectionStringDictionary
        /// </summary>
        private void PropriedadesConexaoInicializar()
        {
            string valor;

            if (ConnectionStringDictionary.TryGetValue("User", out valor))
            {
                ConexaoUsuario = valor;
            }
            if (ConnectionStringDictionary.TryGetValue("Password", out valor))
            {
                ConexaoSenha = valor;
            }
            if (ConnectionStringDictionary.TryGetValue("DataSource", out valor))
            {
                ConexaoServidor = valor;
            }
            if (ConnectionStringDictionary.TryGetValue("Database", out valor))
            {
                ConexaoBanco = valor;
            }
        }

        private object SqlExecutarCustomizavel(string sql, ISqlExecutarCustomizavelFunction classe)
        {
            FbCommand command = fbConnection.CreateCommand();
            command.Transaction = fbConnection.BeginTransaction();
            command.CommandText = sql;

            try
            {
                object result;
                result = classe.funcao(command);
                command.Transaction.Commit();
                return result;
            }
            catch (System.Exception ex)
            {
                command.Transaction.Rollback();
                throw new LocalException(string.Format(ControleFinanceiro.Bibliotecas.Properties.Resources.Msg_SqlErro, ex.Message), ex);
            }
        }

        /// <summary>
        /// Executa um comando SQL. Ideal para Select de uma linha.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parametros"></param>
        /// <returns>Retorna o valor da primeira célula e primeira linha da consulta.</returns>
        public object SqlExecutarConsulta(string sql, IDictionary<string, object> parametros)
        {
            return SqlExecutarCustomizavel(SqlPreparar(sql, parametros), new SqlExecutarCustomizavelFunction_Scalar());
        }

        /// <summary>
        /// Executa um comando SQL. Ideal para Select.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parametros"></param>
        /// <returns>Retorna os dados consultados</returns>
        public DataTable SqlExecutar(string sql, IDictionary<string, object> parametros)
        {
            return (DataTable)SqlExecutarCustomizavel(SqlPreparar(sql, parametros), new SqlExecutarCustomizavelFunction_Reader());
        }

        /// <summary>
        /// Executa um comando SQL. Ideal para Update, Insert, Delete.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parametros"></param>
        /// <returns>Retorna o total de linhas afetadas pelo sql</returns>
        public int SqlExecutarComando(string sql, IDictionary<string, object> parametros)
        {
            return (int)SqlExecutarCustomizavel(SqlPreparar(sql, parametros), new SqlExecutarCustomizavelFunction_NoQuery());
        }

        private string SqlPreparar(string sql, IDictionary<string, object> parametros)
        {
            string sqlPreparado = sql;

            if (parametros != null)
            {
                foreach (KeyValuePair<string, object> param in parametros)
                {
                    if (param.Value == null)
                    {
                        sqlPreparado = sqlPreparado.Replace(":" + param.Key, "null");
                    }
                    else
                    {
                        string valor = param.Value.ToString();
                        if (param.Value.GetType() == typeof(string) || param.Value.GetType() == typeof(char))
                        {
                            valor = "'" + valor.Replace("'", "''") + "'";
                        }
                        else if (param.Value.GetType() == typeof(double))
                        {
                            valor = valor.Replace(",", ".");
                        }
                        sqlPreparado = sqlPreparado.Replace(":" + param.Key, valor);
                    }
                }
            }
            Regex regex = new Regex("(?<=(where|or|and)+\\s*[^=]+)=(?=\\s*null)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            sqlPreparado = regex.Replace(sqlPreparado, "is");

            return sqlPreparado;
        }
    }
}
