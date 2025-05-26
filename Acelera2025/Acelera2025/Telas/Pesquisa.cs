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
    public partial class Pesquisa: Form
    {
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            cardPerfil = new CardPerfil();
            cardPerfil.Visible = false;


            gradientPanel2.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(gradientPanel2.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO",
                     "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR",
                     "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

            string[] categorias = { "Tecnologia", "Saúde", "Educação", "Festivais", "Música", "Artes",
                "Dança", "Ciências", "Competições e Concursos", "Espiritualidade", "Exposições e Feiras",
                "Festas", "Esportes", "Sociedade", "Gastronomia", "Empreendedorismo", "Entretenimento",
                "Voluntariado", "Meio Ambiente" , "Hobbies" };

            

            comboUF.Items.AddRange(estados);
            comboFiltrarBusca.Items.Add("Eventos");
            comboFiltrarBusca.Items.Add("Empresas");
            comboFiltrarBusca.Items.Add("Pessoas");
            comboCategoria.Items.AddRange(categorias);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }
    }
}
