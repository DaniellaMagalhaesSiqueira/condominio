using Condominio.DAO;
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
    public partial class LancarDebito : Form
    {
        private bool revogacao = false;
        public LancarDebito()
        {
            InitializeComponent();
            CriarCombo();
        }

        private void CriarCombo()
        {
            var items = new Object[12];

            for(int i = 0; i < Enum.GetValues(typeof(Meses)).Length ; i++)
            {
                items[i] = (Meses)i+1;
            }
            comboMes.Items.AddRange(items);
        }

       
       
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conversor.ApenasNumeros(e);
        }

        private void txtNumeroRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conversor.ApenasNumeros(e);
        }

        private void btnLancarDebitos_Click(object sender, EventArgs e)
        {
            if(comboMes.Text == "" || txtAno.Text == "")
            {
                MessageBox.Show("Insira mês e ano para lançar débitos.", "Campos Vazios", MessageBoxButtons.OK);
                return;
            }
            int ano = Int32.Parse(txtAno.Text);
            Meses comboValue = (Meses) comboMes.SelectedItem;
            int mes = (int)comboValue;
            var result = DebitoService.LancarDebitos(mes, ano);
            if(result < 0)
            {
                MessageBox.Show("Não foi possível lançar os débitos", "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(result == 2)
            {
                MessageBox.Show("Esse débito já foi lançado! Não é possível lançar débitos de mesmo ano e mesmo mês referente ao condomínio.",
                    "Débito já Existe", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show($"Foram lançados os débitos do mês {comboValue} nos registros de " +
                $"débitos de condôminos", "Débitos Lançados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();

        }

        private void btnApagarDebito_Click(object sender, EventArgs e)
        {
            int res = DebitoService.RevogarDebito();
            if(res > 0)
            {
                MessageBox.Show("Os últimos débitos foram excluídos da base de dados!", "Débitos Cancelados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                revogacao = true;
                this.Dispose();
                return;
            }
            MessageBox.Show("Ocorreu um erro ao excluir o débito", "Erro", MessageBoxButtons.OK);
            return;

        }

        private void LancarDebito_Load(object sender, EventArgs e)
        {
            var debito = DebitoService.UltimoLancamento();
            if (debito != null){
                txtMesAno.Text = (Meses) debito.MesDebito + " - " + debito.AnoDebito;
                dtCriacao.Value = debito.DataCriacao;
                return;
            }
            txtMesAno.Text = "Sem débitos";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }


}
