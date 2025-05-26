using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera2025.Class;

namespace Acelera2025.Telas
{
    public partial class CadastrarEmpresa: Form
    {
        public CadastrarEmpresa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            EntrarEmpresa entrarEmpresa = new EntrarEmpresa();
            entrarEmpresa.Show();
            this.Hide();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
         
            string nome = txtNomeEmpresa.Text;
            string cnpj = txtCnpj.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            

            Empresa empresa = new Empresa(nome, cnpj, telefone, email, senha);

            if (EmpresaManager.GetInstance().SearchByEmailAndPassword(email, senha) == null)
            {
                EmpresaManager.GetInstance().AddEmpresa(empresa);

                limparCampos();

                MessageBox.Show("Empresa cadastrada!");
            }
            else
            {
                MessageBox.Show("Email já cadastrado!");
            }
        }


        void limparCampos()
        {
            txtNomeEmpresa.Text = "";
            txtCnpj.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Logar logar = new Logar();
            logar.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void CadastrarEmpresa_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
            txtConfirmarSenha.PasswordChar = '*';
            btnMostrarSenhaConfirmar.Image = Properties.Resources.icons8_hide_24_1;
        }

        private void btnMostrarSenhaConfirmar_Click(object sender, EventArgs e)
        {
             if (txtConfirmarSenha.PasswordChar == '*')
                {
                    txtConfirmarSenha.PasswordChar = '\0';
                    btnMostrarSenhaConfirmar.Image = Properties.Resources.icons8_eye_30_1;
                }
                else
                {
                    txtConfirmarSenha.PasswordChar = '*';
                    btnMostrarSenhaConfirmar.Image = Properties.Resources.icons8_hide_24_1;
                }
        }
    }
}
