using Condominio.DAO;
using Condominio.Modelos;
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
    public partial class TelaListaCondominos : Form
    {
        private List<Condomino> Condominos;
        public TelaListaCondominos()
        {
            InitializeComponent();
            ConfigurarListView();
            PopularListView();
        }

        public void PopularListView()
        {
            Condominos = CondominoService.Listar();
            foreach (Condomino c in Condominos)
            {
                listView1.Items.Add(new ListViewItem(new string[] {
                    c.Casa + "",
                    c.NomeRepresentante,
                    c.EmailCondomino,
                    c.Telefone
                }));
            }
            listView1.BackColor = Color.White;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listView1.Items[i].BackColor = Color.LightGray;
                }
                else
                {
                    listView1.Items[i].BackColor = Color.White;
                }
            }
        }

        private void ConfigurarListView()
        {

            listView1.Columns.Add("Casa", 180).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Representante", 330);
            listView1.Columns.Add("E-mail", 400);
            listView1.Columns.Add("Telefone", 170);

            
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;

        }


        private void TelaListaCondominos_Load(object sender, EventArgs e)
        {
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var valor = listView1.FocusedItem.Text;

                var cond = CondominoService.Obter(valor, false);
                if (cond == null)
                {
                    MessageBox.Show("Selecione uma casa na lista para alterar os dados", "Casa Não Selecionada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var telaCadastro = new CadastroCondomino();
                telaCadastro.Condomino = cond;
                telaCadastro.MdiParent = this.MdiParent;
                telaCadastro.Size = this.Size;
                telaCadastro.Location = this.Location;
                telaCadastro.WindowState = FormWindowState.Maximized;
                telaCadastro.Show();
                this.Dispose();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            this.Refresh();
        }
        private void btnRegistrarPagamento_Click(object sender, EventArgs e)
        {
            var valor = listView1.FocusedItem.Text;

            var cond = CondominoService.Obter(valor, false);
            var telaRegistroPagamento = new PagamentoCondomino();
            telaRegistroPagamento.Condomino = cond;
            if (cond == null)
            {
                MessageBox.Show("Selecione uma casa na lista para registrar pagamento", "Casa Não Selecionada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            telaRegistroPagamento.MdiParent = this.MdiParent;
            telaRegistroPagamento.Size = this.Size;
            telaRegistroPagamento.Location = this.Location;
            telaRegistroPagamento.WindowState = FormWindowState.Maximized;
            telaRegistroPagamento.Show();
        }

        private void btnDebitoListCondomino_Click(object sender, EventArgs e)
        {
            var valor = listView1.FocusedItem.Text;
            var cond = CondominoService.Obter(valor, false);
            var debitoEspecifico = new TelaDebitoEspecifico();
            debitoEspecifico.Condomino = cond;
            debitoEspecifico.MdiParent = this.MdiParent;
            debitoEspecifico.WindowState = FormWindowState.Maximized;
            debitoEspecifico.Show();

        }

        public void AtualizarLista()
        {
            listView1.Dispose();
            listView1.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Casa", 80).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Representante", 250);
            listView1.Columns.Add("E-mail", 430);
            listView1.Columns.Add("Telefone", 160);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;

            Condominos = CondominoService.Listar();
            foreach (Condomino c in Condominos)
            {
                listView1.Items.Add(new ListViewItem(new string[] {
                    c.Casa + "",
                    c.NomeRepresentante,
                    c.EmailCondomino,
                    c.Telefone
                }));
            }
        }

        private void btnCopyTel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string cellValue = listView1.SelectedItems[0].SubItems[3].Text; // o índice 1 representa a segunda coluna da listview
                Clipboard.SetText(cellValue);
            }
        }

        private void btnCopyEmail_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string cellValue = listView1.SelectedItems[0].SubItems[2].Text; // o índice 1 representa a segunda coluna da listview
                Clipboard.SetText(cellValue);
            }
        }

        private void btnBalanco_Click(object sender, EventArgs e)
        {
            var telaBalanco = new BalancoMensal();
            telaBalanco.MdiParent = this.MdiParent;
            telaBalanco.WindowState = FormWindowState.Maximized;
            telaBalanco.Show();
            this.Dispose();

        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            var telaDespesas = new RegistrarDespesa();
            telaDespesas.MdiParent = this.MdiParent;
            var size = new Size(1388, 727);
            telaDespesas.WindowState = FormWindowState.Maximized;
            telaDespesas.Show();
            this.Dispose();
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Obtém a linha clicada
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);

            if (item != null)
            {
                // Define a propriedade HideSelection como false para manter o foco na linha
                listView1.HideSelection = false;
                item.Selected = true;
            }
        }

        private void btnNovoCondomino_Click(object sender, EventArgs e)
        {
            var telaCadastro = new CadastroCondomino();
            telaCadastro.Condomino = null;
            telaCadastro.MdiParent = this.MdiParent;
            telaCadastro.WindowState = FormWindowState.Maximized;
            telaCadastro.Show();
            this.Dispose();
        }

        private void btnAlterarCondominio_Click(object sender, EventArgs e)
        {
            var alterarCond = new AlterarCondominio();
            alterarCond.MdiParent = this.MdiParent;
            alterarCond.WindowState = FormWindowState.Maximized;
            alterarCond.Show();
            this.Dispose();
        }

        private void TelaListaCondominos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender == this) // Substitua "form2" pelo nome do seu formulário específico
            {
            
                Application.Exit();
            }
        }

        private void btnLancarDebAnual_Click(object sender, EventArgs e)
        {
            var debito = new LancarDebito();
            debito.MdiParent = this.MdiParent;
            debito.WindowState = FormWindowState.Maximized;
            debito.Show();
            this.Dispose();
        }
    }
}
