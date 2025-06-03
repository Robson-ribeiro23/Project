using Acelera2025.Class;
using MeuSistema.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Telas
{
    public partial class EntrarEmpresa: Form
    {
        public EntrarEmpresa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            CadastrarEmpresa cadastrarEmpresa = new CadastrarEmpresa();
            cadastrarEmpresa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logar logar = new Logar();
            logar.Show();
            this.Hide();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string cnpj = txtCnpj.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            var controller = new EmpresaController();
            var empresa = controller.LoginEmpresa(cnpj, email, senha);

            if (empresa != null)
            {
                MessageBox.Show($"Login realizado com sucesso! Bem-vindo, {empresa.Nome}.");
                Principal principal = new Principal("empresa", null, empresa);
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("CNPJ, e-mail ou senha inválidos.");
            }

        }
       

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void EntrarEmpresa_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
                btnMostrarSenha.Image = Properties.Resources.icons8_eye_30_1;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
            }
        }
    }
}
