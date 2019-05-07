using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.Bibliotecas.FormatProvider
{
    public class Moeda : IFormatProvider, ICustomFormatter
    {
        protected virtual string Formatar(object valor)
        {
            return Convert.ToDouble(valor).ToString("C");
        }

        #region IFormatProvider Members

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region ICustomFormatter Members

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg != null)
            {
                return this.Formatar(arg);
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
