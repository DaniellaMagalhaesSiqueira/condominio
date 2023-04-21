using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Condominio.Util
{
    public class TxtQuantidade: TextBox
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
            if(this.Text == "")
            {
                return;
            }
            try
            {
                Convert.ToInt32(this.Text);
            }catch
            {
                this.Text = "";
                MessageBox.Show("Insira um valor válido para a quantidade", "Quantidade Inválida");
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if(e.KeyCode == Keys.Space)
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
