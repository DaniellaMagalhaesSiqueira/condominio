using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Condominio.Util
{
    public static class ComboMeses
    {
        public static void Carregar(ComboBox comboMes)
        {
            var items = new Object[12];

            for (int i = 0; i < Enum.GetValues(typeof(Meses)).Length; i++)
            {
                items[i] = (Meses)i + 1;
            }
            comboMes.Items.AddRange(items);
        }
    }
}
