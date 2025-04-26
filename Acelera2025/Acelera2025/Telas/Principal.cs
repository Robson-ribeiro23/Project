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
    public partial class Principal: Form
    {
        private bool panelVisivel = false;
        public Principal()
        {
            InitializeComponent();
            panelCategorias.Resize += PanelCategorias_Resize;
            panelEventosPerto.Resize += PanelEventosPerto_Resize;
            panelEventosOnline.Resize += PanelEventosOnline_Resize;

            btnNome1.LinkClicked += new LinkLabelLinkClickedEventHandler(AbrirTelaEventos);
            btnNome2.LinkClicked += new LinkLabelLinkClickedEventHandler(AbrirTelaEventos);
            btnNome3.LinkClicked += new LinkLabelLinkClickedEventHandler(AbrirTelaEventos);
            btnNome4.LinkClicked += new LinkLabelLinkClickedEventHandler(AbrirTelaEventos);

            btnNomeEventoOnline4.LinkClicked += new LinkLabelLinkClickedEventHandler(AbrirTelaEventos);
            btnNomeEventoOnline3.LinkClicked += new LinkLabelLinkClickedEventHandler(AbrirTelaEventos);
            btnNomeEventoOnline2.LinkClicked += new LinkLabelLinkClickedEventHandler(AbrirTelaEventos);
            btnNomeEventoOnline1.LinkClicked += new LinkLabelLinkClickedEventHandler(AbrirTelaEventos);

            PicEventoPerto4.Click += AbrirTelaEventosPic;
            PicEventoPerto3.Click += AbrirTelaEventosPic;
            PicEventoPerto2.Click += AbrirTelaEventosPic;
            PicEventoPerto1.Click += AbrirTelaEventosPic;

            picEventoOnline3.Click += AbrirTelaEventosPic;
            picEventoOnline2.Click += AbrirTelaEventosPic;
            picEventoOnline1.Click += AbrirTelaEventosPic;
            picEventoOnline4.Click += AbrirTelaEventosPic;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelCategorias_Resize(null, null);
            PanelEventosPerto_Resize(null, null);
            PanelEventosOnline_Resize(null, null);
            panelMeusEventos.Visible = false;

        }


        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panelEventosPerto_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PanelEventosPerto_Resize(object sender, EventArgs e)
        {
            int espaco = 20;
            int larguraBotao = 50;
            int larguraDisponivel = Math.Max(0, panelEventosPerto.ClientSize.Width - (2 * larguraBotao) - (5 * espaco));

            int larguraPainel = larguraDisponivel / 4;

            roundedPanel1.Width = roundedPanel2.Width = roundedPanel3.Width = roundedPanel4.Width = larguraPainel;

            roundedPanel1.Left = larguraBotao + espaco;
            roundedPanel2.Left = roundedPanel1.Right + espaco;
            roundedPanel3.Left = roundedPanel2.Right + espaco;
            roundedPanel4.Left = roundedPanel3.Right + espaco;

            btnAntEventoPerto.Width = larguraBotao;
            btnAntEventoPerto.Left = espaco;
            btnAntEventoPerto.Top = Math.Max(0, roundedPanel1.Top + (roundedPanel1.Height - btnAntEventoPerto.Height) / 2);
            btnProxEventoPerto.Width = larguraBotao;
            btnProxEventoPerto.Left = this.ClientSize.Width - larguraBotao - espaco;
            btnProxEventoPerto.Top = Math.Max(0, roundedPanel1.Top + (roundedPanel1.Height - btnProxEventoPerto.Height) / 2);
        }

        private void PanelCategorias_Resize(object sender, EventArgs e)
        {
            int espaco = 110;
            int larguraBotao = 60;
            int larguraDisponivel = Math.Max(0, panelCategorias.ClientSize.Width - (5 * espaco) - (2 * larguraBotao));
            int larguraPainel = Math.Max(50, larguraDisponivel / 5);

            int totalLarguraBotoes = (5 * larguraPainel) + (4 * espaco);
            int deslocamentoInicial = Math.Max(0, (panelCategorias.ClientSize.Width - totalLarguraBotoes) / 2);

            int posicaoBotao = 0;
            foreach (Control control in panelCategorias.Controls)
            {
                if (control is Button btn)
                {
                    btn.Width = larguraPainel;
                    btn.Left = deslocamentoInicial + posicaoBotao * (larguraPainel + espaco);
                    btn.Top = Math.Max(0, (panelCategorias.Height - btn.Height) / 2);
                    btn.BackgroundImageLayout = ImageLayout.Zoom;


                    string labelName = "label" + (posicaoBotao + 1);
                    Label label = panelCategorias.Controls.OfType<Label>().FirstOrDefault(l => l.Name == labelName);

                    if (label != null)
                    {
                        label.Left = btn.Left + (btn.Width - label.Width) / 2;
                        label.Top = btn.Bottom + 10;
                    }

                    posicaoBotao++;
                }
            }
        }

        private void PanelEventosOnline_Resize(object sender, EventArgs e)
        {

            int espaco = 20;
            int larguraBotao = 50;
            int larguraDisponivel = Math.Max(0, this.ClientSize.Width - (2 * larguraBotao) - (5 * espaco));

            int larguraPainel = larguraDisponivel / 4;

            roundedPanel6.Width = roundedPanel7.Width = roundedPanel8.Width = roundedPanel9.Width = larguraPainel;

            roundedPanel6.Left = larguraBotao + espaco;
            roundedPanel7.Left = roundedPanel6.Right + espaco;
            roundedPanel8.Left = roundedPanel7.Right + espaco;
            roundedPanel9.Left = roundedPanel8.Right + espaco;

            btnAntEventosOnline.Width = larguraBotao;
            btnAntEventosOnline.Left = espaco;
            btnAntEventosOnline.Top = Math.Max(0, roundedPanel6.Top + (roundedPanel6.Height - btnAntEventosOnline.Height) / 2);
            btnProxEventosOnline.Width = larguraBotao;
            btnProxEventosOnline.Left = this.ClientSize.Width - larguraBotao - espaco;
            btnProxEventosOnline.Top = Math.Max(0, roundedPanel6.Top + (roundedPanel6.Height - btnAntEventosOnline.Height) / 2);
        }
        private void AbrirTelaEventos(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaEvento telaEvento = new TelaEvento();
            telaEvento.Show();
            this.Hide();
        }
        private void AbrirTelaEventosPic(object sender, EventArgs e)
        {
            TelaEvento tela = new TelaEvento();
            tela.Show();
            this.Hide();
        }



        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPicture1_Click(object sender, EventArgs e)
        {
            TelaEvento tela = new TelaEvento();
            tela.Show();
            this.Hide();
        }

        private void panelEventosPerto_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void superiorRoundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrganizarEvento organizarEvento = new OrganizarEvento();
            organizarEvento.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
            
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void roundedPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            EventosCriados eventosCriados = new EventosCriados();
            eventosCriados.Show();
            this.Hide();
        }

        private void superiorRoundedPic5_Click(object sender, EventArgs e)
        {

        }

        private void circularPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void circularPanel_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            this.Hide();
        }

        private void panelCategorias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
