using Ac;
using Acelera2025.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

            /*string[] nomes = { "a", "b", "c", "d", "e" };

            for (int i = 0; i < nomes.Length; i++)
            {
                string four = new string(i.ToString()[0], 4);
                string three = new string(i.ToString()[0], 3);
                string two = new string(i.ToString()[0], 2);

                var user = new UsuarioModels
                {
                    Tipo = "usuario",
                    Nome = nomes[i],
                    Email = nomes[i]+"@gmail.com",
                    Cidade = "Cruzeiro",
                    CPF = $"{three}.{three}.{three}-{two}",
                    DataNascimento = $"{two}/{two}/{four}",
                    Senha = i.ToString(),
                    ConfirmarSenha = i.ToString(),
                    CaminhoFoto = @"C:\Programming\C#\university\Acelera2025\Acelera2025\Pictures\avatar_padrao.png"
                };

                controllerUsuario.Cadastrar(user);
            }

            var usuario = new UsuarioModels
            {
                Tipo = "usuario",
                Nome = "v",
                Email = "v@gmail.com",
                Cidade = "Cruzeiro",
                CPF = "999.999.999-99",
                DataNascimento = "99/99/9999",
                Senha = "9",
                ConfirmarSenha = "9",
                CaminhoFoto = @"C:\Programming\C#\university\Acelera2025\Acelera2025\Pictures\avatar_padrao.png"
            };

            if (controllerUsuario.Cadastrar(usuario))
            {
                Navegador.IrParaLoginUsuario();
            }*/
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
                Tipo = "usuario",
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Cidade = txtCidade.Text,
                CPF = txtCpf.Text,
                DataNascimento = txtData.Text,
                Senha = txtSenha.Text,
                ConfirmarSenha = txtConfirmarSenha.Text,
                CaminhoFoto = @"C:\Programming\C#\university\Acelera2025\Acelera2025\Pictures\avatar_padrao.png"
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
    }
}
