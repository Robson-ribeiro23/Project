using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Telas
{
    public partial class PerfilEmpresa: Form
    {
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        public PerfilEmpresa()
        {
            InitializeComponent();
        }
        private void PerfilEmpresa_Load(object sender, EventArgs e)
        {
            cardPerfil = new CardPerfil("empresa");
            cardPerfil.Visible = false;


            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circularPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circularButton1_Click_1(object sender, EventArgs e)
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

        private void circularButton1_Click_2(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|all files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    PicPerfilEmpresa.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
