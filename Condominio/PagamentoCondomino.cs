using Condominio.DAO;
using Condominio.Modelos;
using Condominio.Util;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condominio
{
    public partial class PagamentoCondomino : Form
    {
        public Condomino Condomino;

        private double totalDebito;

        private Recibo Recibo;

        private List<string> Debitos = new List<string>();
        public PagamentoCondomino()
        {
            InitializeComponent();

        }

        private void CarregarDadosCondomino()
        {
            lbCasa.Text = $"Casa: {Condomino.Casa}";
            lbRepresentante.Text = $"Representante: {Condomino.PrimeiroNome()}";
            lbDebitoAtual.Text = $"Débito Atual: R${Condomino.GetDebitoAtual()}";

        }

        //private void ConfigurarListView()
        //{
        //    //listView1.Columns.Add("Debitos", 203).TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        //    //listView1.View = View.Details;
        //    //listView1.GridLines = true;
        //    //listView1.MultiSelect = false;
        //}

        //private void CarregarCheckedList(object[] debitos)
        //{

        //    checkedListBox1.Items.AddRange(debitos);

        //}


        private List<Debito> PopularListView()
        {
            List<Debito> lista = CondominoService.ObterListaDebitos(Condomino);
            if (lista.Count > 0)
            {
                pictureBox1.Dispose();
            }
            foreach (var item in lista)
            {
                checkedListBox1.Items.Add(item.DescricaoDebito);
            }

            return lista;
        }


        //private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    ApenasNumeros(e);
        //}

        //private void txtNumeroRecibo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    ApenasNumeros(e);
        //}

        //private void ApenasNumeros(KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private async void btnConfimarPagamento_Click(object sender, EventArgs e)
        {

            DebitosSelecionados(sender, e);
            if(Debitos.Count == 0)
            {
                MessageBox.Show("Não foi selecionado nenhum débito para ser gerado recibo",
                    "Seleção vazia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            progressBar1.Visible = true;

            foreach (string d in Debitos)
            {
                var debito = DebitoService.PorDescricao(d);
                totalDebito += debito.ValorDebito;
            }

            //var debito = DebitoService.PorDescricao(comboDebito.Text);

            DialogResult resultado = MessageBox.Show(
                $"Tem certeza que deseja registrar o pagamento no valor de {totalDebito}" +
                $" em nome de {Condomino.NomeRepresentante} (Casa: {Condomino.Casa})?",
                "Recibo Será Registrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                // Inicie a animação da ProgressBar
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.Maximum = 100;
                progressBar1.Minimum = 0;
                progressBar1.MarqueeAnimationSpeed = 30;
                // Inicie o trabalho em segundo plano
                //backgroundWorker.RunWorkerAsync();
                
                string result = await Task.Run(() => metodo());

                pararAnimacao();

                MessageBox.Show(result);
                this.Dispose();
                
            }



        }

        private string metodo() {

            var debitosApagados = GerarDebitos(Debitos, out Recibo);
            string mensagem = GerarPdf(debitosApagados);
            //for(int i = 0; i < 10000; i++)
            //{
            //    Debug.WriteLine(i);
            //}
            return mensagem;
        }

        private void pararAnimacao()
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;

            // Ocultar a ProgressBar
            progressBar1.Visible = false;

        }

        private string GerarPdf(List<Debito> debitos)
        {
            var arquivo = CaminhoArquivo.Nome(Recibo);
            int condQtd = 0;
            foreach (Debito deb in debitos)
            {
                if (deb.DescricaoDebito.Contains("(R$"))
                {
                    //descricao += "parcela de CONDOMÍNIO - ";
                    condQtd += 1;

                }
                //descricao += deb.DescricaoDebito + ",/n";
            }

            using (PdfWriter wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion
                (PdfVersion.PDF_2_0)))
            {
                try
                {
                    var pdfDocument = new PdfDocument(wPdf);
                    var document = new Document(pdfDocument, PageSize.A4);
                    //document.Add(new Paragraph("Isto é um parágrafo do PDF"));
                    //Tabela
                    //float[] columnWidths = { 20, 10, 10, 20, 10 };
                    float[] columnWidths = { 70 };
                    Table table = new Table(UnitValue.CreatePercentArray(columnWidths))
                            .UseAllAvailableWidth();
                    //Título
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Condomínio Álvaro Moutinho")))
                           .SetPadding(10).SetTextAlignment(TextAlignment.CENTER).SetFontSize(18);
                    table.AddCell(new Cell().Add(new Paragraph($"Recibo Nº {Recibo.IdRecibo} - Valor: R$ {Recibo.ValorPagamento}"))
                        .SetTextAlignment(TextAlignment.LEFT).SetFontSize(16));
                    string data = DateTime.Now.ToString("dd 'de' MMMMMM 'de' yyyy");
                    string referente = "";
                    if (condQtd > 0 && debitos.Count == condQtd)
                    {
                        referente = $" referente a contribuição condominial voluntária " +
                            $"da Casa {Recibo.Condomino.Casa}. ";
                    }
                    else if (condQtd > 0 && debitos.Count > condQtd)
                    {
                        referente = $" referente a contribuição condominial voluntária " +
                            $"da Casa {Recibo.Condomino.Casa} e outras despesas. ";
                    }
                    else
                    {
                        referente = $" referente a débitos diversos.";
                    }
                    string texto = $"Recebemos de {Recibo.Condomino.NomeRepresentante}"
                        + $" a quantia de R$ {Recibo.ValorPagamento} correspondente a {Recibo.DescricaoRecibo}"
                        + $"{referente}"
                        + $"\n\r\r{data}, São Gonçalo";


                    table.AddCell(new Cell().Add(new Paragraph(texto))
                        .SetTextAlignment(TextAlignment.LEFT));



                    document.Add(table);
                    document.Close();
                    pdfDocument.Close();
                    string mensagem = "Arquivo PDF gerado em " + arquivo;
                    return mensagem;
                    //MessageBox.Show("Arquivo PDF gerado em " + arquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo de errado não está certo.... (" + ex.Message + ")");
                    return ex.Message;
                }
            }
        }

        private void PagamentoCondomino_Load(object sender, EventArgs e)
        {
            if (Condomino != null)
            {
                PopularListView();
                CarregarDadosCondomino();

            }

            //MessageBox.Show("Escolha um condômino na lista para registrar pagamento");
            //this.Dispose();
        }

        private void DebitosSelecionados(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                bool isChecked = checkedListBox1.GetItemChecked(i);
                checkedListBox1.SetItemChecked(i, isChecked);
                if (isChecked)
                {
                    Debitos.Add(checkedListBox1.Items[i].ToString());

                }
            }
        }

        private List<Debito> GerarDebitos(List<string> debitosDescs, out Recibo rec)
        {
            List<Debito> debApagados = new List<Debito>();
            string descricao = "";
            int condQtd = 0;
            bool cond = false;
            bool especifica = false;
            foreach (string descs in debitosDescs)
            {
                if (descs.Contains("(R$"))
                {
                    if (!cond)
                    {
                        descricao += "PARCELAS DE CONDOMÍNIO - " + descs + ", ";
                        condQtd += 1;
                        cond = true;
                    }
                    else
                    {
                        descricao += descs + ", ";
                    }
                }
                else
                {
                    if (!especifica)
                    {
                        descricao += "DESPESA ESPECÍFICA - " + descs + ", ";
                        especifica = true;
                    }
                    else
                    {
                        descricao += descs + ", ";
                    }
                }
            }
            descricao = descricao.Substring(0, descricao.Length - 1);
            int idRecibo = 0;
            Recibo recibo = new Recibo();
            recibo.DataPagamento = DateTime.Now;
            recibo.ValorPagamento = totalDebito;
            recibo.Condomino = Condomino;
            recibo.DescricaoRecibo = descricao;

            for (int i = 0; i < debitosDescs.Count; i++)
            {

                var debito = DebitoService.PorDescricao(debitosDescs[i]);
                //var desc = Conversor.DescricaoDebitoParaRecibo(debito.DescricaoDebito);
                debApagados.Add(debito);
                try
                {
                    int delDebito = DebitoService.Apagar(debito.IdDebito);
                    if (delDebito > 0)
                    {
                        string desc = Condomino.PrimeiroNome();
                        if (recibo.DescricaoRecibo.Contains("PARCELAS DE CONDOMÍNIO -"))
                        {
                            desc += descricao.Replace("PARCELAS DE CONDOMÍNIO", "(COND.)");
                        }
                        if(descricao.Contains("DESPESA ESPECÍFICA"))
                        {
                            desc += descricao.Replace("DESPESA ESPECÍFICA", "(OUTRAS)");
                            desc += $"({recibo.ValorPagamento})";
                        }
                        Debug.WriteLine(desc);
                        
                        var receita = new Receita(
                        recibo.ValorPagamento, recibo.DataPagamento, desc,
                            debito.IdDebito);
                        int receitaId = ReceitaService.Inserir(receita);
                    }
                    else
                    {
                        MessageBox.Show("Esse débito não existe", "Erro ao inserir recibo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rec = null;
                        return debApagados;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    rec = null;
                    return null;
                }

            }
            idRecibo = ReciboService.Inserir(recibo);
            recibo.IdRecibo = idRecibo;
            if (idRecibo < 0)
            {
                MessageBox.Show("Algum recibo pode não ter sido impresso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rec = recibo;
                return debApagados;
            }
            rec = recibo;
            return debApagados;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            double valor = Conversor.ConverteStringParaDouble(txtValor.Text);
            bool isChecked = checkedListBox1.GetItemChecked(e.Index);
            string desc = checkedListBox1.Items[e.Index].ToString();



            Debito debito = DebitoService.PorDescricao(desc);
            checkedListBox1.SetItemChecked(e.Index, isChecked);
            if (!isChecked)
            {
                valor += debito.ValorDebito;
                txtValor.Text = Conversor.ConverteDoubleParaString(valor);
                return;

            }
            else
            {
                if (valor - debito.ValorDebito > 0)
                {
                    valor -= debito.ValorDebito;
                    txtValor.Text = Conversor.ConverteDoubleParaString(valor);
                    return;
                }
                valor = 0;
                txtValor.Text = Conversor.ConverteDoubleParaString(valor);
                return;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    //tarefa demorada
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Debug.WriteLine("Numero : - " + i);
        //    }
        //    var debitosApagados = GerarDebitos(Debitos, out Recibo);
        //    string mensagem = GerarPdf(debitosApagados);
        //    MessageBox.Show(mensagem);


        //}

        //private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    // Atualize o valor da ProgressBar
        //    progressBar1.Value = e.ProgressPercentage;

        //}
    }
}


