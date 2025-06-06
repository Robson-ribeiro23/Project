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
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void circularPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
