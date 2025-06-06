using Ac;
using Acelera2025.Controllers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class CadastrarEmpresa: Form
    {
        private EmpresaControllers controllerEmpresa = new EmpresaControllers();
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
                else if (i == 7)
                    formatado += "-";

                formatado += texto[i];
            }

            e.Handled = true;

            txtTelefone.Text = formatado;
            txtTelefone.SelectionStart = txtTelefone.Text.Length;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            var empresa = new EmpresaModels
            {
                Nome = txtNomeEmpresa.Text,
                CNPJ = txtCnpj.Text,
                Telefone = txtTelefone.Text,
                Cidade = "São Paulo",
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                ConfirmarSenha = txtConfirmarSenha.Text,
            };

            if (controllerEmpresa.Cadastrar(empresa))
            {
                LimparCampos();
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
    }
}
