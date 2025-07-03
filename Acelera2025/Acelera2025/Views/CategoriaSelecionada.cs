using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ac;
using Acelera2025.Telas;

namespace Acelera2025.Views
{
    public partial class CategoriaSelecionada: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        private string categoria;

        public CategoriaSelecionada(PessoaModels usuario, string categoria, Image imagem)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.categoria = categoria;

            if (imagem != null)
            {
                picture.Image = imagem;
            }
            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }

        private void CategoriaSelecionada_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;

            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel1.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            lblNomeCategoria.Text = categoria;
            panelEventosCategoria.Controls.Clear();
            showEvents();
        }

        private void showEvents()
        {
            var eventos = EventoControllers.ListarTodos();
            var eventosFiltrados = eventos.Where(e => e.Categoria == categoria).ToList();

            foreach (var evento in eventosFiltrados)
            {
                CardPesquisaUsuario card = new CardPesquisaUsuario();
                card.ForçarUsuario(UsuarioControllers.loggedUser);
                card.DefinirDadosEvento(evento);
                panelEventosCategoria.Controls.Add(card);
            }
        }

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaAjuda(this.usuario);
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaSobreNos(this.usuario);
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosIngressados(this.usuario);
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosCriados(this.usuario);
        }

        private void btnOrganizadorEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaOrganizarEventos(this.usuario);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.usuario);
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaHome(this.usuario);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaCategorias(this.usuario);
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
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
    }
}
