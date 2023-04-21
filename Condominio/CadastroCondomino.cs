using Condominio.DAO;
using Condominio.Modelos;
using Condominio.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Condominio
{
    public partial class CadastroCondomino : Form
    {

        public Condomino Condomino { get; set; }

        private bool Alteracao = false;

        public CadastroCondomino()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new MenuRestrito();
            //form.MdiParent = this.MdiParent;
            //form.WindowState = FormWindowState.Maximized;
            if (Alteracao)
            {

                var cond = new Condomino(
                    this.Condomino.IdCondomino, txtCasa.Text,
                    txtRepresentante.Text, txtTelefone.Text == "" ? null : txtTelefone.Text,
                    txtProprietario.Text == "" ? txtRepresentante.Text : txtProprietario.Text,
                    txtVeiculo.Text == "" ? null : txtVeiculo.Text,
                    txtEmail.Text == "" ? null : txtEmail.Text,
                    txtDebito.Text == "" ? 0.00 : CondominoService.ConverteValorDebito(txtDebito.Text)
                    );
                try
                {
                    CondominoService.Alterar(cond);
                    MessageBox.Show("Alteração de cadastro realizada com sucesso.", "Sucesso!", MessageBoxButtons.OK);
                    form.Refresh();
                    form.Show();
                    this.Dispose();
                    return;

                }
                catch (Exception ex)
                {
                    DialogResult retorno = MessageBox.Show("Não foi possível fazer a alteração desejada", "Erro ao Alterar",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    Console.WriteLine(ex.Message);
                    if (retorno == DialogResult.Retry)
                    {
                        return;
                    }
                    form.Refresh();
                    form.Show();
                    this.Dispose();
                    return;
                }

            }
            else
            {
                txtCasa.Text = Casa.Tratamento(txtCasa.Text);

                if (txtCasa.Text == "" || txtRepresentante.Text == "" || txtTelefone.Text == "" || txtTelefone.Text.Length < 14)
                {
                    MessageBox.Show("É obrigatório registrar o número da casa, o nome do proprietário e um telefone.", "Campos Obrigatórios", MessageBoxButtons.OK);
                    return;
                }

                var cond = new Condomino(
                    0, txtCasa.Text, txtRepresentante.Text, txtTelefone.Text == "" ? null : txtTelefone.Text,
                    txtProprietario.Text == "" ? "Representante" : txtProprietario.Text,
                    txtVeiculo.Text == "" ? null : txtVeiculo.Text,
                    txtEmail.Text == "" ? null : txtEmail.Text,
                    txtDebito.Text == "" ? 0.00 : CondominoService.ConverteValorDebito(txtDebito.Text)
                    );
                int result = CondominoService.Inserir(cond);
                if (result < 0)
                {
                    DialogResult retorno = MessageBox.Show("Não foi possível incluir o Condômino",
                        "Erro ao incluir", MessageBoxButtons.RetryCancel);

                    if (retorno == DialogResult.Retry)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Essa janela será fechada.", "Erro ao Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.Show();
                        this.Dispose();
                        return;

                    }
                }
            }
            MessageBox.Show("Cadastro realizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.Show();
            form.Refresh();
            this.Dispose();
            return;
        }

        private void CadastroCondomino_Load(object sender, EventArgs e)
        {
            if (this.Condomino != null)
            {
                this.Alteracao = true;

                txtCasa.Text = Condomino.Casa + "";
                txtCasa.Enabled = false;
                txtProprietario.Text = Condomino.Proprietario;
                txtDebito.Text = Condomino.DebitoAnterior.ToString("0.00");
                txtRepresentante.Text = Condomino.NomeRepresentante;
                txtTelefone.Text = Condomino.Telefone;
                txtEmail.Text = Condomino.EmailCondomino;
                txtVeiculo.Text = Condomino.Veiculos;
                button1.Text = "Alterar Condômino";

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new MenuRestrito();
            form.Show();
            this.Dispose();
        }

    }
}
