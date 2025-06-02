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
    public partial class OrganizarEvento: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        public OrganizarEvento()
        {
            InitializeComponent();

        }
        
        private void OrganizarEvento_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil("empresa");
            cardPerfil.Visible = false;


            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO",
                     "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR",
                     "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

            string[] categorias = { "Artes", "Tecnologia", "Saúde", "Educação", "Festivais", "Música", 
                "Dança", "Ciências", "Competições e Concursos", "Espiritualidade", "Exposições e Feiras",
                "Festas", "Esportes", "Sociedade", "Gastronomia", "Empreendedorismo", "Entretenimento",
                "Voluntariado", "Meio Ambiente" , "Hobbies" };

            string[] faixaEtaria = { "Livre", "+10", "+12",
                "+14", "+16", "+18"
            };

            comboUF.Items.AddRange(estados);
            comboCategoria.Items.AddRange(categorias);
            comboFaixaEtaria.Items.AddRange(faixaEtaria);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPresencial.Checked)
            {
                panel3.Visible = true;
                panel2.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void roundedPicture1_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnOnline.Checked)
            { 
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Principal p = new Principal();
             p.Show();
             this.Hide();*/

        }

        private void circularPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Principal p = new Principal();
              p.Show();
              this.Hide();*/
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            TelaEvento telaEvento = new TelaEvento();
            telaEvento.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
    }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            EventosCriados eventosCriados = new EventosCriados();
            eventosCriados.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void circularPanel3_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void circularPanel3_Paint(object sender, PaintEventArgs e)
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



        private void comboFaixaEtaria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
