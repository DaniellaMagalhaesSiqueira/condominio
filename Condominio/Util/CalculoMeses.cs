using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Util
{
    public class CalculoMeses
    {
        public static int Despesas(DateTime inicial, DateTime final)
        {
            if(inicial.Year == final.Year)
            {
                return final.Month - (inicial.Month - 1); ;
            }
            if(final.Year - inicial.Year > 1)
            {
                return ((13 - inicial.Month) + final.Month) * (final.Year - inicial.Year);
            }

            return (13 - inicial.Month) + final.Month;
        }
    }
}
