using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ac;

namespace Acelera2025.Views
{
    public partial class CardEditarPerfil: UserControl
    {
        public event EventHandler FecharTelaSolicitado;
        private PessoaModels usuario;
        public CardEditarPerfil(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
            button1.Image = Properties.Resources.icons8_hide_24_1;
            txtSenhaAtual.PasswordChar = '*';
            txtNovaSenha.PasswordChar = '*';
        }

        private void btnOrganizarEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Perfil perfil = new Perfil();
            //perfil.Show();

            //FecharTelaSolicitado?.Invoke(this, EventArgs.Empty);
            Navegador.IrParaPerfilUsuario(this.usuario);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione uma foto de perfil",
                Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp;*.gif",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoImagem = openFileDialog.FileName;
                usuario.CaminhoFoto = caminhoImagem;
                picFotoPerfil.Image = Image.FromFile(caminhoImagem);

                //MessageBox.Show("Foto atualizada!");
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text; 
            string senhaAtual = txtSenhaAtual.Text;
            string novoEmail = txtEmail.Text.Trim();

            // Verificação de senha atual
            if (senhaAtual != usuario.Senha)
            {
                MessageBox.Show("Senha atual incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação básica do e-mail (opcional)
            if (!string.IsNullOrWhiteSpace(novoEmail) && !novoEmail.Contains("@"))
            {
                MessageBox.Show("E-mail inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Atualiza o e-mail
            if (!string.IsNullOrWhiteSpace(novoEmail))
            {
                usuario.Email = novoEmail;
            }

            // Atualiza a senha se nova senha foi informada
            if (!string.IsNullOrWhiteSpace(novaSenha))
            {
                usuario.Senha = novaSenha;
            }

            MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void picFotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSenhaAtual.PasswordChar == '*')
            {
                txtSenhaAtual.PasswordChar = '\0';
                button1.Image = Properties.Resources.icons8_eye_30_1;
            }
            else
            {
                txtSenhaAtual.PasswordChar = '*';
                button1.Image = Properties.Resources.icons8_hide_24_1;
            }
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.PasswordChar == '*')
            {
                txtNovaSenha.PasswordChar = '\0';
                btnMostrarSenha.Image = Properties.Resources.icons8_eye_30_1;
            }
            else
            {
                txtNovaSenha.PasswordChar = '*';
                btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
            }
        }
    }
}
