using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.ManipuladorDeDados
{
    public class MdConfiguracao : MdBase
    {
        private static string informacoesUltimoAcesso = null;
        public string InformacoesUltimoAcesso
        {
            get { return MdConfiguracao.informacoesUltimoAcesso; }
        }

        public string InformacoesAcessoAtual
        {
            get
            {
                string sqlSelect = "select sist_tx_ultimo_acesso from tb_sistema";
                return Convert.ToString(MdConexao.Conexao.SqlExecutarConsulta(sqlSelect, null));
            }
            set
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("param1", value);

                string sqlSelect = "select count(*) from tb_sistema";
                string sqlInsert = "insert into tb_sistema(sist_tx_ultimo_acesso) values(:param1)";
                string sqlUpdate = "update tb_sistema set sist_tx_ultimo_acesso = :param1";

                MdConexao.SqlExecutar_InsertOuUpdate(sqlSelect, sqlInsert, sqlUpdate, parametros);
            }
        }

        public MdConfiguracao()
        {
            if (MdConfiguracao.informacoesUltimoAcesso == null)
            {
                MdConfiguracao.informacoesUltimoAcesso = InformacoesAcessoAtual;
            }
        }

        /// <summary>
        /// Total de vezes permitidas para errar a senha.
        /// </summary>
        public int TentativasDeAutenticacao
        {
            get
            {
                string sqlSelect = "select sist_nr_senha_invalida from tb_sistema";
                try
                {
                    return Convert.ToInt16(MdConexao.Conexao.SqlExecutarConsulta(sqlSelect, null));
                }
                catch (FormatException)
                {
                    return 0;
                }
                catch (InvalidCastException)
                {
                    return 0;
                }
                catch (NullReferenceException)
                {
                    return 0;
                }
            }
            set
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("param1", value);

                string sqlSelect = "select count(*) from tb_sistema";
                string sqlInsert = "insert into tb_sistema(sist_nr_senha_invalida) values(:param1)";
                string sqlUpdate = "update tb_sistema set sist_nr_senha_invalida = :param1";

                MdConexao.SqlExecutar_InsertOuUpdate(sqlSelect, sqlInsert, sqlUpdate, parametros);
            }
        }

        /// <summary>
        /// Verifica se uma string é uma senha válida
        /// </summary>
        /// <param name="senha">senha a ser validada</param>
        /// <returns>bool</returns>
        public bool SenhaAutenticar(string senha)
        {
            string sqlSelect = "select sist_tx_senha from tb_sistema";
            string senhaBanco = Convert.ToString(MdConexao.Conexao.SqlExecutarConsulta(sqlSelect, null));

            return senhaBanco == senha || (string.IsNullOrEmpty(senhaBanco) && string.IsNullOrEmpty(senha));
        }

        /// <summary>
        /// Define uma nova senha para acesso ao sistema.
        /// </summary>
        /// <param name="senha">nova senha</param>
        public void SenhaDefinir(string senha)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("param1", senha); 
            
            string sqlSelect = "select count(*) from tb_sistema";
            string sqlInsert = "insert into tb_sistema(sist_tx_senha) values(:param1)";
            string sqlUpdate = "update tb_sistema set sist_tx_senha = :param1";

            MdConexao.SqlExecutar_InsertOuUpdate(sqlSelect, sqlInsert, sqlUpdate, parametros);
        }

    }
}
