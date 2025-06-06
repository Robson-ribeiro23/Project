using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Acelera2025.Views
{
    public partial class Perfil: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private CardEditarPerfil cardEditarPerfil;
        private bool cardPerfilVisivel = false;
        private bool cardEditarPerfilVisivel = false;

        public Perfil()
        {
            InitializeComponent();
        }
        private void Perfil_Load(object sender, EventArgs e)
        {
            roundedPanel10.Visible = false;
            cardPerfil = new CardPerfil("empresa");
            cardPerfil.Visible = false;
            cardEditarPerfil = new CardEditarPerfil();
            cardEditarPerfil.Visible = false;
            

            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width-20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            panel1.Controls.Add(cardEditarPerfil);
            cardEditarPerfil.Left = (this.ClientSize.Width - cardEditarPerfil.Width) / 2;
            cardEditarPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardEditarPerfil.Top = (this.ClientSize.Height - cardEditarPerfil.Height) / 2;


        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizarEvento organizarEvento = new OrganizarEvento();
            organizarEvento.Show();
            this.Hide();
        }

        private void roundedPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            EventosCriados eventosCriados = new EventosCriados();
            eventosCriados.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            roundedPanel10.Visible = panelVisivel;
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizarEvento organizarEvento = new OrganizarEvento();
            organizarEvento.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Principal p = new Principal();
                p.Show();
                this.Hide();*/
        }



        private void circularButton2_Click_1(object sender, EventArgs e)
        {
           
        }

        

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
            this.Hide();
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SobreNos sobreNos = new SobreNos();
            sobreNos.Show();
            this.Hide();
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Principal p = new Principal();
             p.Show();
             this.Hide();*/
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cardEditarPerfilVisivel = !cardEditarPerfilVisivel;
            cardEditarPerfil.Visible = cardEditarPerfilVisivel;
            cardEditarPerfil.BringToFront();
        }

        private void btnEditarInformações_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cardEditarPerfilVisivel = !cardEditarPerfilVisivel;
            cardEditarPerfil.Visible = cardEditarPerfilVisivel;
            cardEditarPerfil.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void panelPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|all files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    PicPerfil.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PicPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
