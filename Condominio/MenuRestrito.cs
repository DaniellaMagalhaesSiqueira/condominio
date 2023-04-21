using Condominio.DAO;
using Condominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Condominio
{
    public partial class MenuRestrito : Form
    {
        public Administrador Adm { get; set; }
        public MenuRestrito()
        {
            InitializeComponent();
        }

        private void MenuRestrito_Load(object sender, EventArgs e)
        {
            TelaListaCondominos form = new TelaListaCondominos();
            form.MdiParent = this;
            
            form.Size = this.Size;
            form.Location = this.Location;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnListarCondominos_Click(object sender, EventArgs e)
        {
            var telaLista = new TelaListaCondominos();
            
            telaLista.ShowDialog();
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            var telaLancarDebito = new LancarDebito();
            telaLancarDebito.ShowDialog();
        }

        private void cadastrarCondominosMenuItem_Click(object sender, EventArgs e)
        {
            FecharJanelaAberta();
            var telaCadastro = new CadastroCondomino();
            telaCadastro.MdiParent = this;
            telaCadastro.WindowState = FormWindowState.Maximized;
            telaCadastro.Show();
        }

        private void listarCondominosMenuItem_Click(object sender, EventArgs e)
        {
            FecharJanelaAberta();
            var telaLista = new TelaListaCondominos();
            telaLista.MdiParent = this;
            telaLista.WindowState = FormWindowState.Maximized;
            telaLista.Show();
        }

        private void lançarDebitosMenuItem_Click(object sender, EventArgs e)
        {
            FecharJanelaAberta();
            var debito = new LancarDebito();
            debito.MdiParent = this;
            debito.WindowState = FormWindowState.Maximized;
            debito.Show();
        }

        private void casacataMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void organizarHoriMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void organizarVertMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharJanelaAberta();
            var alterarCond = new AlterarCondominio();
            alterarCond.MdiParent = this;
            alterarCond.WindowState = FormWindowState.Maximized;
            alterarCond.Show();
        }

        private void FecharJanelaAberta()
        {
            foreach (var form in this.MdiChildren)
            {
                if (!form.IsDisposed)
                {
                    form.Dispose();
                }
            }
        }

        private void regitrarDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharJanelaAberta();
            var telaRegistrarDespesa = new RegistrarDespesa();
            telaRegistrarDespesa.MdiParent = this;
            telaRegistrarDespesa.WindowState = FormWindowState.Maximized;
            telaRegistrarDespesa.Show();
        }

        private void balançMoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharJanelaAberta();
            BalancoMensal tela = new BalancoMensal();
            tela.MdiParent = this;
            tela.WindowState = FormWindowState.Maximized;
            tela.Show();
        }

        private void lançarDébitoAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharJanelaAberta();
            LancamentoDebitoAnual tela = new LancamentoDebitoAnual();
            tela.MdiParent = this;
            tela.WindowState = FormWindowState.Maximized;
            tela.Show();
        }

    }
}
