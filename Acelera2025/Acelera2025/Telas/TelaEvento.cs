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
    public partial class TelaEvento: Form
    {
        private bool panelVisivel = false;
        public TelaEvento()
        {
            InitializeComponent();
            this.panel2.Resize += Panel2_Resize;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            panelMeusEventos.Visible = false;
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TelaEvento_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void superiorRoundedPic1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel2_Resize(object sender, EventArgs e)
        {
            int espaco = 100;
            int margemLateral = 70;

            int larguraDisponivel = panel2.ClientSize.Width - (2 * margemLateral) - espaco;
            int larguraCadaElemento = larguraDisponivel / 2;

            int altura = panel2.ClientSize.Height;

            picEvento.Width = larguraCadaElemento;
            picEvento.Height = altura;
            picEvento.Left = margemLateral;
            picEvento.Top = 0;

            roundedPanel1.Width = larguraCadaElemento;
            roundedPanel1.Height = altura;
            roundedPanel1.Left = picEvento.Right + espaco;
            roundedPanel1.Top = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizarEvento organizarEvento = new OrganizarEvento();
            organizarEvento.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void circularPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {

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

        private void circularPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularPanel3_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();

        }
    }
}
