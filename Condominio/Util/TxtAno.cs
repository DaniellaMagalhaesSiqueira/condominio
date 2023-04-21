using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Condominio.Util
{
    public class TxtAno: TextBox
    {
        private int valor;
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.AliceBlue;
            this.SelectAll();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            
            base.OnLostFocus(e);
            this.BackColor = Color.White;
            if (this.Text == "")
            {
                return;
            }
            try
            {
                Int32.TryParse(this.Text, out valor);
                if(valor < 2010 || valor > 2999)
                {
                    throw new Exception();
                }
            }
            catch
            {
                this.Text = "";
                MessageBox.Show("Insira um ano válido.", "Ano Inválido");
            }
           
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }

    }
}
