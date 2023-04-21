using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Condominio.Util
{
    public class TxtValor : TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.SkyBlue;
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
                double valor = Convert.ToDouble(this.Text.Replace("R$ ", ""));
                this.Text = String.Format("{0:c}", valor);
            }
            catch
            {
                this.Text = "";
                MessageBox.Show("Insira um valor válido.", "Valor Inválido");
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Space)
            {
                this.Text = "";
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }
    }
}
