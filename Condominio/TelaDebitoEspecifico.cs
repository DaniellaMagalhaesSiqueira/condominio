using Condominio.DAO;
using Condominio.Modelos;
using Condominio.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Condominio
{
    public partial class TelaDebitoEspecifico : Form
    {
        public Condomino Condomino { get; set; }
        public TelaDebitoEspecifico()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtValorDebito.SelectionStart = txtValorDebito.Text.Length + 1;
            var valor = txtValorDebito.SelectedText;
            string result = txtValorDebito.Text;
            if (txtValorDebito.SelectionStart > 1)
            {
                result += ",";
                if (txtValorDebito.Text.Contains(","))
                {
                    result = result.Replace(",", "");
                    if(result.Length > 1)
                    {
                        result = result.Insert(result.Length - 2, ",");
                    }
                }

            }
            else
            {
                    result = result.Replace(",", "");
            }

            txtValorDebito.Text = result;


        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var valorstr = txtValorDebito.Text;
            double valor = Convert.ToDouble(txtValorDebito.Text.Replace("R$ ", ""));
            var debito = new Debito(
                Condomino, txtDebitoDesc.Text + " " + valorstr , valor,
                dateTimePicker1.Value.Month, dateTimePicker1.Value.Year,
                dateTimePicker1.Value
                );
            int result = DebitoService.Inserir(debito);
            if(result < 0)
            {
                MessageBox.Show("O Débito não foi inserido", "Provavelmente algum problema que sua filha deixou passar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparTela();
                return;
            }
            else
            {
                DialogResult opcao =  MessageBox.Show("Débito foi inserido no nome do morador. Gostaria de " +
                    "voltar à tela inicial?", "Sucesso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                LimparTela();
                if(opcao == DialogResult.Yes)
                {
                    var form = new MenuRestrito();
                    form.Show();
                    this.Dispose();
                }
                return;
            }

        }

        private void LimparTela()
        {
            dateTimePicker1.Value = DateTime.Now;
            txtValorDebito.Text = "";
            txtDebitoDesc.Text = "";
        }

        private void TelaDebitoEspecifico_Load(object sender, EventArgs e)
        {
            if(Condomino != null)
            {
                lbRepresentante.Text = "Sr(a) " + Condomino.NomeRepresentante + "\t - Casa " + Condomino.Casa;
                //lbCasa.Text = "Casa " + Condomino.Casa;

            }
        }

        private void txtValorDebito_Click(object sender, EventArgs e)
        {
            txtValorDebito.SelectionStart = txtValorDebito.Text.Length + 1;
            Debug.WriteLine(sender);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var form = new MenuRestrito();
            form.Show();
            this.Dispose();
        }
    }
}
