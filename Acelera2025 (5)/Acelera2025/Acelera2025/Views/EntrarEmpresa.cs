using Ac;
using Acelera2025.Controllers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class EntrarEmpresa: Form
    {
        private EmpresaControllers controllerEmpresa = new EmpresaControllers();

        CardRecuperacaoSenha cardRecuperacaoSenha;
        private bool cardRecuperacaoSenhaVisivel = false;
        public EntrarEmpresa()
        {
            InitializeComponent();
        }

        private void EntrarEmpresa_Load(object sender, EventArgs e)
        {
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;

            cardRecuperacaoSenha = new CardRecuperacaoSenha();
            cardRecuperacaoSenha.Visible = false;
            this.Controls.Add(cardRecuperacaoSenha);
            cardRecuperacaoSenha.Left = (this.ClientSize.Width - cardRecuperacaoSenha.Width) / 2;
            cardRecuperacaoSenha.FecharTelaSolicitado += (s, args) => this.Close();
            cardRecuperacaoSenha.Top = (this.ClientSize.Height - cardRecuperacaoSenha.Height) / 2;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaOpcaoLogin();
        }

        private void btnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            Navegador.IrParaCadastroEmpresa();
        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            var cnpj = txtCnpj.Text;
            var email = txtEmail.Text;
            var senha = txtSenha.Text;

            var empresa = controllerEmpresa.Login(cnpj, email, senha);

            if (empresa != null)
            {
                Navegador.IrParaHome(empresa);
            }
        }

        private void btnRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cardRecuperacaoSenhaVisivel = !cardRecuperacaoSenhaVisivel;
            cardRecuperacaoSenha.Visible = cardRecuperacaoSenhaVisivel;
            cardRecuperacaoSenha.BringToFront();
        }
    }
}
