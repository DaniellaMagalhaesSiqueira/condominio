using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Condominio.Util
{
    class Casa
    {

        public static string Tratamento(string casa)
        {
            casa = casa.Replace("-", "").Replace("/","").Replace(" ", "");
            int number;
            string numeroStr = "";

            //método substring funciona diferentemente do de java
            for (int i = 0; i < casa.Length; i++)
            {

                if (int.TryParse(casa.Substring(i, 1), out number))
                {

                    numeroStr += casa.Substring(i, 1);

                }
                else
                {
                    if (numeroStr == "")
                    {

                        MessageBox.Show("Somente é possível registrar casas que comecem com números.", "Número de casa inválido", MessageBoxButtons.OK);

                        return "";
                    }
                    else
                    {
                        numeroStr += " - " + casa.Substring(numeroStr.Length);
                        return numeroStr;
                    }
                }
            }

            return numeroStr;
        }

    }
}
