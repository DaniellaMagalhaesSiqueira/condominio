using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Condominio.Util
{
    public class ListViewUtil
    {
        public static void Configurar(ListView lv)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.MultiSelect = false;
            lv.HoverSelection = true;
            lv.FullRowSelect = true;
        }
    }
}
