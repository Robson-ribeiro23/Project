using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Telas
{
    public partial class CardEditarPerfil: UserControl
    {
        public event EventHandler FecharTelaSolicitado;
        public CardEditarPerfil()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOrganizarEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();

            FecharTelaSolicitado?.Invoke(this, EventArgs.Empty);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|all files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    PicPerfilEditar.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void roundedPicture2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtConfirmarNovaSenha.PasswordChar == '*')
            {
                txtConfirmarNovaSenha.PasswordChar = '\0';
                btnMostrarSenha.Image = Properties.Resources.icons8_eye_30_1;
            }
            else
            {
                txtConfirmarNovaSenha.PasswordChar = '*';
                btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
            }
        }
    }
}
