using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ac;
using Acelera2025.Models;

namespace Acelera2025.Views
{
    public partial class CadastrarUsuario: Form
    {
        private UsuarioControllers controllerUsuario = new UsuarioControllers();
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
            btnMostrarSenhaConfirmar.Image = Properties.Resources.icons8_hide_24_1;
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

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string texto = new string(txtCpf.Text.Where(char.IsDigit).ToArray());

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
                if (i == 3 || i == 6)
                    formatado += ".";
                else if (i == 9)
                    formatado += "-";

                formatado += texto[i];
            }

            e.Handled = true;

            txtCpf.Text = formatado;

            txtCpf.SelectionStart = txtCpf.Text.Length;
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string texto = new string(txtData.Text.Where(char.IsDigit).ToArray());

            if (char.IsControl(e.KeyChar))
                return;

            texto += e.KeyChar;

            if (texto.Length > 8)
            {
                e.Handled = true;
                return;
            }

            string formatado = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (i == 2 || i == 4)
                    formatado += "/";

                formatado += texto[i];
            }

            e.Handled = true;

            txtData.Text = formatado;
            txtData.SelectionStart = txtData.Text.Length;
        }

        private void CadastrarUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new UsuarioModels
            {
                Nome = txtNome.Text,
                Tipo = "usuario",
                Email = txtEmail.Text,
                Cidade = txtCidade.Text,
                CPF = txtCpf.Text,
                DataNascimento = txtData.Text,
                Senha = txtSenha.Text,
                ConfirmarSenha = txtConfirmarSenha.Text,
            };

            if (controllerUsuario.Cadastrar(usuario))
            {
                LimparCampos();
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            txtCpf.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
            txtData.Text = "";
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

        private void btnEntrarUsuario_Click(object sender, EventArgs e)
        {
            Navegador.IrParaLoginUsuario();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
