using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.FormatProvider
{
    public class LivroCaixaSaldoAtual : Moeda
    {
        protected override string Formatar(object valor)
        {
            string valorFormatado = base.Formatar(valor);
            string complemento;
            if (Convert.ToDouble(valor) < 0)
            {
                complemento = "Negativo";
            }
            else
            {
                complemento = "Positivo";
            }
            return string.Format("{0}: {1}", complemento, valorFormatado);
        }
    }
}
