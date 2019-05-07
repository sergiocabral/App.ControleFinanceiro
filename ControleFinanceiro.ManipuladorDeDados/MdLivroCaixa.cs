using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Entidades;
using System.Data;

namespace ControleFinanceiro.ManipuladorDeDados
{
    public class MdLivroCaixa : MdBaseEntidade<LivroCaixa>
    {
        public MdLivroCaixa()
        {
            base.EntidadeModelo = new LivroCaixa();
        }

        protected override string ObterFiltro(LivroCaixa entidade)
        {
            StringBuilder filtro = new StringBuilder();

            if (entidade.Id != null) filtro.Append(" and (" + EntidadeModelo.ConverterParaBanco("Id") + " = :paramId)");
            if (entidade.Nome != null) filtro.Append(" and (" + EntidadeModelo.ConverterParaBanco("Nome") + " like :paramNome)");
            if (entidade.Saldo != null) filtro.Append(" and (" + EntidadeModelo.ConverterParaBanco("Saldo") + " = :paramSaldo)");
            if (entidade.Ativo != null) filtro.Append(" and (" + EntidadeModelo.ConverterParaBanco("Ativo") + " = :paramAtivo)");

            filtro.Remove(0, " and ".Length);

            return filtro.ToString();
        }

        protected override IDictionary<string, object> ObterParametros(LivroCaixa entidade)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("paramId", entidade.Id);
            parametros.Add("paramNome", ((string)("%" + entidade.Nome + "%")).Replace("%%", "%"));
            parametros.Add("paramSaldo", entidade.Saldo);
            parametros.Add("paramAtivo", entidade.Ativo);

            return parametros;
        }

        protected override LivroCaixa RowParaEntidade(DataRow row)
        {
            LivroCaixa entidade = new LivroCaixa();
            entidade.Id = Convert.ToInt32(row[EntidadeModelo.ConverterParaBanco("Id")]);
            entidade.Nome = Convert.ToString(row[EntidadeModelo.ConverterParaBanco("Nome")]);
            try
            {
                entidade.Saldo = Convert.ToDouble(row[EntidadeModelo.ConverterParaBanco("Saldo")]);
            }
            catch (Exception)
            {
                entidade.Saldo = null;
            }
            entidade.Ativo = Convert.ToChar(row[EntidadeModelo.ConverterParaBanco("Ativo")]);
            return entidade;
        }
    }
}
