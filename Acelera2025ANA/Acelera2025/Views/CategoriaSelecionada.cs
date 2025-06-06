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
    public partial class CategoriaSelecionada: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        public CategoriaSelecionada()
        {
            InitializeComponent();
        }

        private void CategoriaSelecionada_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;

            //cardPerfil = new CardPerfil();
            cardPerfil.Visible = false;
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
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

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            EventosIngressados eventosIngressados = new EventosIngressados();
            eventosIngressados.Show();
            this.Hide();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            EventosCriados eventosCriados = new EventosCriados();
            eventosCriados.Show();
            this.Hide();
        }

        private void btnOrganizadorEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizarEvento organizarEvento = new OrganizarEvento();
            organizarEvento.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa();
            pesquisa.Show();
            this.Hide();
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Principal p = new Principal();
            p.Show();
            this.Hide();*/
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }
    }
}
