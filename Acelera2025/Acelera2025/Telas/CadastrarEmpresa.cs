using Acelera2025.Class;
using MeuSistema.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string confirmarSenha = txtConfirmarSenha.Text;


            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(cnpj) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(confirmarSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!EmailValido(email))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            var controller = new EmpresaController();

            var empresa = controller.CadastrarEmpresa(nome, cnpj, telefone, email, senha);

            MessageBox.Show($"Empresa {empresa.Nome} cadastrada com sucesso! ID: {empresa.Id}");
           
            this.Close();
            EntrarEmpresa login = new EntrarEmpresa();
            login.Show();

            txtNomeEmpresa.Clear();
            txtCnpj.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
        }
        private bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /*void limparCampos()
        {
            txtNomeEmpresa.Text = "";
            txtCnpj.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }*/

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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            EntrarEmpresa entrarEmpresa = new EntrarEmpresa();
            entrarEmpresa.Show();
            this.Hide();
        }

        private void txtCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            
            string texto = new string(txtCnpj.Text.Where(char.IsDigit).ToArray());

            
            if (char.IsControl(e.KeyChar))
                return;

            
            texto += e.KeyChar;

            
            if (texto.Length > 14)
            {
                e.Handled = true;
                return;
            }

            
            string formatado = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (i == 2 || i == 5)
                    formatado += ".";
                else if (i == 8)
                    formatado += "/";
                else if (i == 12)
                    formatado += "-";

                formatado += texto[i];
            }

            
            e.Handled = true;

            
            txtCnpj.Text = formatado;

            
            txtCnpj.SelectionStart = txtCnpj.Text.Length;
        }
    }
}
