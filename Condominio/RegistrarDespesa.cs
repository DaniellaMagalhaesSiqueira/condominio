using Condominio.DAO;
using Condominio.Modelos;
using Condominio.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Condominio
{
    public partial class RegistrarDespesa : Form
    {
        private List<string> Despesas = new List<string>();
        public RegistrarDespesa()
        {
            InitializeComponent();
            CarregarCheckList();
            CarregarComboMes();
        }


        private void CarregarCheckList()
        {

            label10.Text = "Número-Descrição da Despesa-Mês/Ano-Valor";
            label10.Font = new Font("Sugoe UI", 11, FontStyle.Regular);
            label10.BackColor = Color.Transparent;
            label10.Padding = new Padding(2);
            label10.AutoSize = false;
            label10.Size = new Size(checkedListBox1.Width, 30);

            List<Despesa> lista = DespesaService.Listar();
            checkedListBox1.Items.Clear();
            if (comboMes.SelectedIndex >= 0)
            {
                lista = DespesaService.ListarPorMes(comboMes.SelectedIndex + 1);
            }
            foreach (var item in lista)
            {
                string linha = $"{item.IdDespesa} - {item.DescricaoDespesa} - " +
                    $"{item.MesDespesa}/{item.AnoDespesa} - R$ " +
                    $"{Conversor.ConverteDoubleParaString(item.ValorDespesa)}";
                checkedListBox1.Items.Add(linha);
            }
        }

        private void CarregarComboMes()
        {
            string[] items = new string[12];
            DateTime data = new DateTime(2023, 1, 1);
            for (int i = 0; i < 12; i++)
            {
                items[i] = data.ToString("MMMMMM");
                data = data.AddMonths(1);
            }
            comboMes.Items.AddRange(items);
        }
        private void LimparTela()
        {
            EsvaziarValores(groupBox2);
            EsvaziarValores(groupParcelamento);
            checkUnica.Checked = false;
            checkParcelamento.Checked = false;
            checkTodosMeses.Checked = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!checkTodosMeses.Checked && !checkParcelamento.Checked && !checkUnica.Checked)
            {
                MessageBox.Show("Selecione uma forma de despesa: Parcelamento, Mensal ou Única.", "Forma de Despesa Inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            string desc = txtDescricao.Text;
            double valor = Conversor.ConverteStringParaDouble(txtValor.Text);

            if (checkTodosMeses.Checked)
            {
                if (txtAno1.Text == "" || txtDescricao.Text == "" || txtValor.Text == "")
                {
                    MessageBox.Show("Faltam informações referentes à descrição, valor ou ano.", "Sem informações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int ano = Int32.Parse(txtAno1.Text);
                for (int i = 1; i < 13; i++)
                {
                    var despesa = new Despesa(
                        DateTime.Now,
                        desc,
                        valor,
                        i,
                        12,
                        i,
                        ano
                        );
                    int resultado = DespesaService.Inserir(despesa);
                }
                MessageBox.Show("A despesa mensal foi registrada.", "Despesa Incluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarCheckList();
                LimparTela();
                return;
            }
            else if (checkParcelamento.Checked)
            {
                if (txtParcelas.Text == "" || txtDescricao.Text == "" || txtValor.Text == "")
                {
                    MessageBox.Show("Faltam informações referentes à descrição, valor ou parcelas. Caso não seja informado, o vencimento será no dia 1.", "Sem informações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int inteiro;
                int parcelas = Int32.Parse(txtParcelas.Text);
                int vencimento = Int32.TryParse(txtVencimento.Text, out inteiro) ? inteiro : 1;
                int meses = DateTime.Now.Month;
                int anoParcelamento = DateTime.Now.Year;
                for (int i = 1; i <= parcelas; i++)
                {
                    if (meses > 12)
                    {
                        meses = 1;
                        anoParcelamento += 1;
                    }
                    DateTime dataParcela = new DateTime(day: vencimento, month: meses, year: anoParcelamento);
                    var despesa = new Despesa(
                        dataParcela,
                        desc,
                        valor,
                        i,
                        parcelas,
                        meses,
                        anoParcelamento
                        );
                    int resultado = DespesaService.Inserir(despesa);
                    meses += 1;
                }
                MessageBox.Show("O parcelamento foi registrado.", "Despesa Incluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarCheckList();
                LimparTela();
                return;
            }
            else if (checkUnica.Checked)
            {
                if (txtDescricao.Text == "" || txtValor.Text == "")
                {
                    MessageBox.Show("Faltam informações referentes à descrição ou valor.", "Sem informações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DateTime data = dateTimePicker1.Value;
                var despesa = new Despesa(
                        data,
                        desc,
                        valor,
                        1,
                        1,
                        data.Month,
                        data.Year
                        );
                int resultado = DespesaService.Inserir(despesa);
                MessageBox.Show("A despesa foi registrada.", "Despesa Incluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarCheckList();
                LimparTela();
                return;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var telaCondominos = new TelaListaCondominos();
            telaCondominos.MdiParent = this.MdiParent;
            telaCondominos.WindowState = FormWindowState.Maximized;
            telaCondominos.Show();
            this.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DespesasSelecionadas();
            var despesas = new List<Despesa>();
            foreach (string str in Despesas)
            {
                int id = Int32.Parse(str.Split(" - ")[0]);
                Despesa despesa = DespesaService.Obter(id);
                despesas.Add(despesa);
            }
            DialogResult resultado;
            if (despesas.Count == 0)
            {
                MessageBox.Show("Despesa não foi selecionada", "Seleção inválida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (despesas.Count > 1)
            {
                resultado = MessageBox.Show(
               $"Você selecionou mais de uma despesa para ser paga e excluída do banco de dados no valor de R${txtTotal.Text}. Tem certeza que deseja continuar?",
               "Pagamento de Despesa", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                foreach (Despesa desp in despesas)
                {
                    int inserir = DespesaService.Excluir(desp.IdDespesa, datePickerPagamento.Value);
                    if (inserir < 0)
                    {
                        MessageBox.Show("Não foi possível pagar a despesa", "Deu ruim!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("As despesas foram registradas como pagas", "Despesas Pagas", MessageBoxButtons.OK);
                    CarregarCheckList();
                    return;
                }
            }
            else
            {
                var despesa = DespesaService.Obter(Int32.Parse(Despesas[0].Split(" - ")[0]));
                resultado = MessageBox.Show(
                    $"Você tem certeza que deseja excluir a despesa do dia {despesa.DataDespesa.ToString("dd/MM/yyyy")}" +
                    $" no valor de R${Conversor.ConverteDoubleParaString(despesa.ValorDespesa)} referente a {despesa.DescricaoDespesa}?",
                    "Pagamento de Despesa", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    int inserir = DespesaService.Excluir(despesa.IdDespesa, datePickerPagamento.Value);

                    if (inserir < 0)
                    {
                        MessageBox.Show("Não foi possível pagar a despesa", "Deu ruim!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("A despesa foi registrada como paga", "Despesa Paga", MessageBoxButtons.OK);
                    CarregarCheckList();
                    return;
                }
            }
        }

        private void RegistrarDespesa_Load(object sender, EventArgs e)
        {

        }

        private void EsvaziarValores(GroupBox grupo)
        {
            // Iterar por todos os controles do GroupBox
            foreach (Control control in grupo.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear(); // Limpa o valor do TextBox
                }
            }
        }

        private void checkParcelamento_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkParcelamento.Checked)
            {
                txtVencimento.Enabled = true;
                txtParcelas.Enabled = true;
                checkTodosMeses.Checked = false;
                EsvaziarValores(groupMensal);
                checkUnica.Checked = false;
            }
            else
            {
                txtVencimento.Enabled = false;
                txtParcelas.Enabled = false;

            }
        }

        private void checkTodosMeses_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodosMeses.Checked)
            {
                txtAno1.Text = DateTime.Now.Year.ToString();
                txtAno1.Enabled = true;
                checkParcelamento.Checked = false;
                EsvaziarValores(groupParcelamento);
                checkUnica.Checked = false;
            }
            else
            {
                txtAno1.Enabled = false;

            }
        }

        private void checkUnica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUnica.Checked)
            {
                dateTimePicker1.Enabled = true;
                checkTodosMeses.Checked = false;
                EsvaziarValores(groupMensal);
                checkParcelamento.Checked = false;
                EsvaziarValores(groupParcelamento);
            }
            else
            {
                dateTimePicker1.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botão de limpar seleção do mês
            comboMes.SelectedIndex = -1;
        }

        private void comboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCheckList();
        }

        private void DespesasSelecionadas()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                bool isChecked = checkedListBox1.GetItemChecked(i);
                checkedListBox1.SetItemChecked(i, isChecked);
                if (isChecked)
                {
                    Despesas.Add(checkedListBox1.Items[i].ToString());

                }
            }
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            double valor = Conversor.ConverteStringParaDouble(txtTotal.Text);
            bool isChecked = checkedListBox1.GetItemChecked(e.Index);
            string desc = checkedListBox1.Items[e.Index].ToString();
            desc = desc.Split(" - ")[0];
            var despesa = DespesaService.Obter(Int32.Parse(desc));
            txtTotal.Text = Conversor.ConverteDoubleParaString(valor);
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(e.Index, isChecked);
                if (!isChecked)
                {
                    valor += despesa.ValorDespesa;
                    txtTotal.Text = Conversor.ConverteDoubleParaString(valor);
                    return;

                }
                else
                {
                    if (valor - despesa.ValorDespesa > 0)
                    {
                        valor -= despesa.ValorDespesa;
                        txtTotal.Text = Conversor.ConverteDoubleParaString(valor);
                        return;
                    }
                    valor = 0;
                    txtTotal.Text = Conversor.ConverteDoubleParaString(valor);
                    return;
                }
            }
        }
    }
}
