using System;
using System.Collections.Generic;
using System.Text;
using ControleFinanceiro.Entidades;
using System.Data;

namespace ControleFinanceiro.ManipuladorDeDados
{
    public class MdCategoria : MdBaseEntidade<Categoria>
    {
        public MdCategoria()
        {
            base.EntidadeModelo = new Categoria();
        }

        protected override string ObterFiltro(Categoria entidade)
        {
            StringBuilder filtro = new StringBuilder();

            if (entidade.Id != null) filtro.Append(" and (" + EntidadeModelo.ConverterParaBanco("Id") + " = :paramId)");
            if (entidade.Nome != null) filtro.Append(" and (" + EntidadeModelo.ConverterParaBanco("Nome") + " like :paramNome)");

            filtro.Remove(0, " and ".Length);

            return filtro.ToString();
        }

        protected override IDictionary<string, object> ObterParametros(Categoria entidade)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("paramId", entidade.Id);
            parametros.Add("paramNome", ((string)("%" + entidade.Nome + "%")).Replace("%%", "%"));

            return parametros;
        }

        protected override Categoria RowParaEntidade(DataRow row)
        {
            Categoria entidade = new Categoria();
            entidade.Id = Convert.ToInt32(row[EntidadeModelo.ConverterParaBanco("Id")]);
            entidade.Nome = Convert.ToString(row[EntidadeModelo.ConverterParaBanco("Nome")]);
            return entidade;
        }
    }
}
