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
    public partial class AlterarCondominio : Form
    {

        CondominioAlteracao Condominio;
        public AlterarCondominio()
        {
            InitializeComponent();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conversor.ApenasNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conversor.ApenasNumeros(e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if(Conversor.ConverteStringParaDouble(txtAtual.Text)  == Condominio.ValorAtual)
            {
                MessageBox.Show("Condomínio não pode ser alterado", "O novo valor informado é o mesmo que o valor atual", MessageBoxButtons.OK);
                return;
            }

            dateTimePicker1.Value = DateTime.Now;
               

            CondominioAlteracao cond = new CondominioAlteracao(
                dateTimePicker1.Value,
                Conversor.ConverteStringParaDouble(txtAtual.Text),
                Condominio.ValorAtual,
                true
                );
            CondominioAlteracaoService.Inserir(cond);
            MessageBox.Show("Condomínio alterado com sucesso!", "Alteração Efetuada", MessageBoxButtons.OK);
            //this.Dispose();
            AlterarCondominio_Load(sender, e);

        }

        private void AlterarCondominio_Load(object sender, EventArgs e)
        {
            Condominio = CondominioAlteracaoService.ObterValido();
            txtAtual.Text = Conversor.ConverteDoubleParaString(Condominio.ValorAtual);
            txtAnterior.Text = Conversor.ConverteDoubleParaString(Condominio.ValorAnterior);
            dateTimePicker1.Value = Condominio.DataAlteracao;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new MenuRestrito();
            form.Show();
            this.Dispose();
        }
    }
}
