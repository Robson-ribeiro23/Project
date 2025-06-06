using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class Ajuda: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        public Ajuda()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil("empresa");
            cardPerfil.Visible = false;


            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

        }

        private void btnOrganizadorEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizarEvento organizarEvento = new OrganizarEvento();
            organizarEvento.Show();
            this.Hide();
        }

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void btnEventosCriados_Click(object sender, EventArgs e)
        {
            EventosCriados eventosCriados = new EventosCriados();
            eventosCriados.Show();
            this.Hide();
        }

        private void btnPerfil_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Principal p = new Principal();
            p.Show();
            this.Hide();
        */
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SobreNos sobreNos = new SobreNos();
            sobreNos.Show();
            this.Hide();
        }

        private void btnPrincipal_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Principal p = new Principal();
            p.Show();
            this.Hide();
       */ 
        }
    }
}
