
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
    public partial class BalancoMensal : Form
    {
        Double Saldo;
        public BalancoMensal()
        {
            InitializeComponent();
            BalancoTotal();

        }

        private void BalancoTotal()
        {
            double total = 0.0;
            int result = ReceitaService.SaldoTotalGeral(out total);
            if(result > 0)
            {
                string val = total.ToString("0.00");
                txtBlancoTotal.Text = "R$ " + val;
            }
        }
        private void CarregarLists(DateTime dataInicio, DateTime dataFim)
        {
            
            Double totalReceita = 0.0;
            Double totalDespesa = 0.0;
            listDespesas.Columns.Clear();
            listReceitas.Columns.Clear();
            listReceitas.Columns.Add("Descrição", 810).TextAlign = HorizontalAlignment.Center;
            listReceitas.Columns.Add("Valor", 75);
            listDespesas.Columns.Add("Descrição", 810);
            listDespesas.Columns.Add("valor", 75);

            ListViewUtil.Configurar(listDespesas);
            ListViewUtil.Configurar(listReceitas);

            listDespesas.Items.Clear();
            listReceitas.Items.Clear();
            List<Despesa> despesas = DespesaService.ListarPagas(dataInicio, dataFim);
            foreach (Despesa d in despesas)
            {
                listDespesas.Items.Add(new ListViewItem(new string[] {
                    d.DescricaoDespesa,
                    Conversor.ConverteDoubleParaString(d.ValorDespesa)
                }));
                
                totalDespesa += d.ValorDespesa;
            }
            this.txtValorTotDesp.Text = Conversor.ConverteDoubleParaString(totalDespesa);
            List<Receita> receitas = ReceitaService.Listar(dataInicio, dataFim);
            foreach (Receita r in receitas)
            {
                listReceitas.Items.Add(new ListViewItem(new string[] {
                    r.DescricaoReceita,
                    Conversor.ConverteDoubleParaString(r.ValorReceita)
                }));
                Debug.WriteLine(r.DescricaoReceita);
                totalReceita += r.ValorReceita;
            }
            this.txtValorTotRec.Text = Conversor.ConverteDoubleParaString(totalReceita);
            Saldo = totalReceita - totalDespesa;
        }

        private void BalancoMensal_Load(object sender, EventArgs e)
        {
            string [] items = new string [12];
            DateTime data = new DateTime(2023, 1, 1);
            for (int i = 0; i < 12; i++)
            {
                items[i] = data.ToString("MMMMMM");
                data = data.AddMonths(1);
            }
            comboMes.Items.AddRange(items);
            DateTime dataAtual = DateTime.Now;
            int diaAtual = dataAtual.Day;
            int mesAtual = dataAtual.Month;
            comboMes.SelectedIndex = mesAtual - 1;
            this.txtAno1.Text = dataAtual.ToString("yyyy");
            //double total = 0.0;
            //int result = ReceitaService.SaldoTotalGeral(out total);
            //txtBlancoTotal.Text = "R$" + total;
            //DateTime data = DateTime.Today;
            //if(dtFim.Value.Equals(data) && dtInicio.Value.Equals(new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month))))
            //{
            //    var dataInicio = new DateTime(data.Year, data.Month, 1);
            //    var dataFim = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            //    CarregarLists(dataInicio, dataFim);

            //}
            //else { 

            //    CarregarLists(dtInicio.Value, dtFim.Value);
            //}
            txtValor1.Text = "" + Saldo;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            int ano = Int32.Parse(txtAno1.Text);
            DateTime primeiroDiaDoMes = new DateTime(ano, comboMes.SelectedIndex + 1, 1);
            DateTime ultimoDiaDoMes = primeiroDiaDoMes.AddMonths(1).AddDays(-1);
            CarregarLists(primeiroDiaDoMes, ultimoDiaDoMes);
            txtValor1.Text = "" + Saldo;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaListaCondominos();
            telaInicial.MdiParent = this.MdiParent;
            telaInicial.WindowState = FormWindowState.Maximized;
            telaInicial.Show();

        }
    }
}
