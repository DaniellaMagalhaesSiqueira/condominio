using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Condominio.Modelos;
using Condominio.DAO;

namespace Condominio
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Digite usuário (e-mail) e senha para continuar", "Campos Vazios", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtSenha.Clear();
                txtUsuario.Focus();
                
            }
            else
            {
                try
                {
                    //var adm = AdmService.Login(txtUsuario.Text, txtSenha.Text);
                    //var principal = new MenuRestrito();
                    //principal.Adm = adm;
                    //principal.Closed += (s, args) => this.Close();
                    //principal.ShowDialog();

                }
                catch
                {
                    MessageBox.Show("Erro ao acessar o banco de dados", "Administrador não encontrado",
                        MessageBoxButtons.OK);
                }
            }
        }
    }
}
