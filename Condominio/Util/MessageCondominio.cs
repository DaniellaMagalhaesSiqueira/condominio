using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Condominio.Util
{
    class MessageCondominio
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            // Cria um objeto de fonte personalizado
            var font = new Font("Arial", 16, FontStyle.Regular);

            // Cria um objeto de MessageBox personalizado
            Form form = new Form();
            Label label = new Label();
            Button button1 = new Button();
            Button button2 = new Button();

            form.Text = caption;
            label.Text = message;
            label.Font = font;
            button1.Text = "OK";
            button2.Text = "Cancelar";
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    form.Controls.Add(button1);
                    button1.Location = new Point(125, 70);
                    break;
                case MessageBoxButtons.OKCancel:
                    form.Controls.Add(button1);
                    form.Controls.Add(button2);
                    button1.Location = new Point(70, 70);
                    button2.Location = new Point(175, 70);
                    break;
            }

            switch (icon)
            {
                case MessageBoxIcon.Error:
                    form.Icon = SystemIcons.Error;
                    break;
                case MessageBoxIcon.Information:
                    form.Icon = SystemIcons.Information;
                    break;
                case MessageBoxIcon.Question:
                    form.Icon = SystemIcons.Question;
                    break;
                case MessageBoxIcon.Warning:
                    form.Icon = SystemIcons.Warning;
                    break;
            }

            form.StartPosition = FormStartPosition.CenterScreen;
            label.AutoSize = true;
            label.Location = new Point(20, 20);
            form.ClientSize = new Size(Math.Max(250, label.Width + 150), label.Height + 200);
            form.Controls.Add(label);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.AcceptButton = button1;
            form.CancelButton = button2;

            DialogResult dialogResult = form.ShowDialog();
            form.Dispose();

            return dialogResult;
        }
    }
}
