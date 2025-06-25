using System;
using System.Drawing;
using System.Windows.Forms;
using Ac;
using System.IO;
using Acelera2025.Telas;

namespace Acelera2025.Views
{
    public partial class Perfil: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private CardEditarPerfil cardEditarPerfil;
        private bool cardPerfilVisivel = false;
        private bool cardEditarPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;

        public Perfil(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblNomeUsuario.Text = usuario.Nome;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
                picPerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }
        private void Perfil_Load(object sender, EventArgs e)
        {
            roundedPanel10.Visible = false;
            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;
            cardEditarPerfil = new CardEditarPerfil(this.usuario);
            cardEditarPerfil.Visible = false;
            

            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width-20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            panel1.Controls.Add(cardEditarPerfil);
            cardEditarPerfil.Left = (this.ClientSize.Width - cardEditarPerfil.Width) / 2;
            cardEditarPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardEditarPerfil.Top = (this.ClientSize.Height - cardEditarPerfil.Height) / 2;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel1.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            cardEditarPerfilVisivel = usuario == UsuarioControllers.loggedUser;
            btnLapis.Visible = cardEditarPerfilVisivel;
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            roundedPanel10.Visible = panelVisivel;
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaOrganizarEventos(this.usuario);
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaAjuda(this.usuario);
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaSobreNos(this.usuario);
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaHome(this.usuario);
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void btnLapis_Click(object sender, EventArgs e)
        {
            if (usuario != UsuarioControllers.loggedUser) return;
            cardEditarPerfilVisivel = !cardEditarPerfilVisivel;
            cardEditarPerfil.Visible = cardEditarPerfilVisivel;
            cardEditarPerfil.BringToFront();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.usuario);
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            cardPainelDeNotificacoesVisivel = !cardPainelDeNotificacoesVisivel;
            cardPainelDeNotificacoes.Visible = cardPainelDeNotificacoesVisivel;
            cardPainelDeNotificacoes.BringToFront();
        }

        private void btnFeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.usuario);
        }

        private void picPerfil_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
