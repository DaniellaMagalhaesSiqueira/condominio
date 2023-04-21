using System;
using System.Windows.Forms;
using System.Diagnostics;
using Condominio.Modelos;
using Condominio.DAO;
using System.Collections.Generic;
using Condominio.Exceptions;
using System.Drawing;
using Condominio.Util;
using System.ComponentModel;
using System.Threading;

namespace Condominio
{
    public partial class LancamentoDebitoAnual : Form
    {
        private int Ano;
        private string Inclusos;
        private int Result;
        public LancamentoDebitoAnual()
        {
            InitializeComponent();
        }

        private void btnLancarDespesaAnual_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;

            // Inicie a animação da ProgressBar
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            // Inicie o trabalho em segundo plano
            backgroundWorker.RunWorkerAsync();

            string inclusos = "";
            try
            {

                Debug.WriteLine(txtAno1.Text);
                if (txtAno1.Text.Equals(""))
                {
                    return;
                }
                else
                {
                    var ano = Int32.Parse(txtAno1.Text);

                    //var result = 
                    //foreach (KeyValuePair<string, string> dic in d)
                    //{
                    //    Debug.WriteLine($"{dic.Key} - {dic.Value}");
                    //}
                    //result = 1;
                    if (Result < 0)
                    {
                        throw new BancoException();
                    }
                    else if (Result == 0)
                    {
                        throw new Exception("Esse débito já foi lançado para todos os meses");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não foi possível incluir débitos", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                pararAnimacao();
                return;
            }
            MessageBox.Show($"Inclusão efetuada com sucesso. Foram incluídos os meses: {Inclusos}",
                "Sucesso", MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
            pararAnimacao();
            return;
            

        }

        private void pararAnimacao()
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;

            // Ocultar a ProgressBar
            progressBar1.Visible = false;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simule uma tarefa demorada (substitua este código pela sua própria lógica)
            Result = DebitoService.LancarDebitosAnual(Ano, out Inclusos);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Atualize o valor da ProgressBar
            progressBar1.Value = e.ProgressPercentage;
           
        }
    }
}
