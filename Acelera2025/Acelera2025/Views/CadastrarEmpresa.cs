using Ac;
using Acelera2025.Controllers;
using Acelera2025.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Acelera2025.Views
{
    public partial class CadastrarEmpresa : Form
    {
        private EmpresaControllers controllerEmpresa = new EmpresaControllers();
        private const int MAX_CARACTERES_NOME = 100;

        public CadastrarEmpresa()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaOpcaoLogin();
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
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
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

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string texto = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());

            if (char.IsControl(e.KeyChar))
                return;

            texto += e.KeyChar;

            if (texto.Length > 11)
            {
                e.Handled = true;
                return;
            }

            string formatado = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (i == 0)
                    formatado += "(";
                else if (i == 2)
                    formatado += ") ";
                else if (texto.Length > 6 && i == 7)
                    formatado += "-";

                formatado += texto[i];
            }

            e.Handled = true;

            txtTelefone.Text = formatado;
            txtTelefone.SelectionStart = txtTelefone.Text.Length;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validações
            if (!ValidarNomeEmpresa(txtNomeEmpresa.Text))
            {
                MessageBox.Show("Nome da empresa inválido. Deve conter pelo menos 3 caracteres e não ultrapassar 100 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeEmpresa.Focus();
                return;
            }

            if (!ValidarCNPJ(txtCnpj.Text))
            {
                MessageBox.Show("CNPJ inválido. Verifique o número digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCnpj.Focus();
                return;
            }

            if (!ValidarTelefone(txtTelefone.Text))
            {
                MessageBox.Show("Telefone inválido. Deve conter DDD + número (10 ou 11 dígitos).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Focus();
                return;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (!ValidarSenha(txtSenha.Text))
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra maiúscula, um número e ter no mínimo 8 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarSenha.Focus();
                return;
            }

            var empresa = new EmpresaModels
            {
                Tipo = "empresa",
                Nome = txtNomeEmpresa.Text.Trim(),
                CNPJ = new string(txtCnpj.Text.Where(char.IsDigit).ToArray()), // Apenas números
                Telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray()),
                Cidade = "São Paulo",
                Email = txtEmail.Text.Trim(),
                Senha = txtSenha.Text,
                ConfirmarSenha = txtConfirmarSenha.Text,
            };

            if (controllerEmpresa.Cadastrar(empresa))
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();

                // Pergunta se possui endereço físico
                var resposta = MessageBox.Show("A empresa possui endereço físico?", "Endereço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    // Vai para tela de endereço
                    var formEndereco = new CadastrarEmpresaEndereço(empresa);
                    formEndereco.Show();
                }
                else
                {
                    // Vai para tela de login da empresa
                    var loginEmpresa = new EntrarEmpresa();
                    loginEmpresa.Show();
                }

                this.Hide();
            }
        }

        private void LimparCampos()
        {
            txtNomeEmpresa.Text = "";
            txtCnpj.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            Navegador.IrParaLoginEmpresa();
        }

        // Métodos de validação
        private bool ValidarNomeEmpresa(string nome)
        {
            return !string.IsNullOrWhiteSpace(nome) &&
                   nome.Length >= 3 &&
                   nome.Length <= MAX_CARACTERES_NOME;
        }

        private bool ValidarCNPJ(string cnpj)
        {
            
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            
            if (cnpj.Length != 14)
                return false;

            
            if (cnpj.Distinct().Count() == 1)
                return false;

            
            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            
            return int.Parse(cnpj[12].ToString()) == digito1 &&
                   int.Parse(cnpj[13].ToString()) == digito2;
        }

        private bool ValidarTelefone(string telefone)
        {
            
            telefone = new string(telefone.Where(char.IsDigit).ToArray());

            
            return telefone.Length == 10 || telefone.Length == 11;
        }

        private bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool ValidarSenha(string senha)
        {
            const int MIN_CARACTERES_SENHA = 8;
            return !string.IsNullOrWhiteSpace(senha) &&
                   senha.Length >= MIN_CARACTERES_SENHA &&
                   senha.Any(char.IsUpper) &&
                   senha.Any(char.IsDigit);
        }

        
        private void txtNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeEmpresa.Text.Length > MAX_CARACTERES_NOME)
            {
                txtNomeEmpresa.Text = txtNomeEmpresa.Text.Substring(0, MAX_CARACTERES_NOME);
                txtNomeEmpresa.SelectionStart = MAX_CARACTERES_NOME;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}