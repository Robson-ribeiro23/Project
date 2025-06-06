using System;
using System.Windows.Forms;
using Ac;

namespace Acelera2025.Views
{
    public partial class EntrarUsuario: Form
    {
        private UsuarioControllers controllerUsuario = new UsuarioControllers();
        public EntrarUsuario()
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

        private void EntrarUsuario_Load(object sender, EventArgs e)
        {
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
        }

        private void btnEntrarUsuario_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var senha = txtSenha.Text;

            var usuario = controllerUsuario.Login(email, senha);

            if (usuario != null)
            {
                Navegador.IrParaHome(usuario);
            }

        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Navegador.IrParaCadastroUsuario();
        }
    }
}
