using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Views
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione um arquivo",
                Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp;*.gif",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Arquivo escolhido: " + openFileDialog.FileName);
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
