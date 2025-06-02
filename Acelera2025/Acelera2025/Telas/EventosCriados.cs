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
    public partial class EventosCriados: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;

        public EventosCriados()
        {
            InitializeComponent();
        }
        
        private void EventosCriados_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil("empresa");
            cardPerfil.Visible = false;


            this.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(this.Width - cardPerfil.Width - 20, 50);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            /*Principal p = new Principal();
             p.Show();
             this.Hide();*/
        }

        private void circularPanel3_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void btnOrganizarEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnEventosIngressados_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
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

        private void roundedPicture1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Principal p = new Principal();
                p.Show();
                this.Hide();*/
        }
    }
}
