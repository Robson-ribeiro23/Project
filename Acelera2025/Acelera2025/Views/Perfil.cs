using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ac;
using Acelera2025.Models;
using Acelera2025.Telas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        private PessoaModels loggedUser;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        private UsuarioModels usuarioVisualizado; 
        


        public Perfil(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblNomeUsuario.Text = usuario.Nome;
            loggedUser = UsuarioControllers.loggedUser;
            this.usuarioVisualizado = (UsuarioModels)usuario;




            lblNomeUsuario.Text = usuario.Nome;
            lblNumSeguidores.Text = usuarioVisualizado.Seguidores.Count.ToString();

            if (!string.IsNullOrEmpty(this.usuarioVisualizado.CaminhoFoto) && File.Exists(this.usuarioVisualizado.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuarioVisualizado.CaminhoFoto);
                picPerfil.Image = Image.FromFile(this.usuarioVisualizado.CaminhoFoto);
            }

            btnSeguir.Text = loggedUser.EstaSeguindo(usuarioVisualizado) ? "Seguindo" : "Seguir";

            if (loggedUser != null && !string.IsNullOrEmpty(loggedUser.CaminhoFoto) && File.Exists(loggedUser.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(loggedUser.CaminhoFoto);
            }
            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picPerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            if (loggedUser == null) { return; }

            roundedPanel10.Visible = false;
            cardPerfil = new CardPerfil(loggedUser);
            cardPerfil.Visible = false;
            cardEditarPerfil = new CardEditarPerfil(loggedUser);
            cardEditarPerfil.Visible = false;
            
            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width-20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            panel1.Controls.Add(cardEditarPerfil);
            cardEditarPerfil.Left = (this.ClientSize.Width - cardEditarPerfil.Width) / 2;
            cardEditarPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardEditarPerfil.Top = (this.ClientSize.Height - cardEditarPerfil.Height) / 2;
            cardEditarPerfil.DadosAtualizados += AtualizarDadosUsuario;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel1.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            btnLapis.Visible = usuarioVisualizado.Email == loggedUser.Email;
            btnSeguir.Visible = usuarioVisualizado.Email != loggedUser.Email;
            labelSeguir.Visible = usuarioVisualizado.Email != loggedUser.Email;
            btnEntrarEmContato.Visible = usuarioVisualizado.Email != loggedUser.Email;
            labelEntrarEmContato.Visible = usuarioVisualizado.Email != loggedUser.Email;

            LoadAllEvents();
            LoadAllPosts();
        }

        private void LoadAllEvents()
        {
            // mais recentes primeiro
            List<EventoModels> subbedEvents = usuario.GetSubbedEvents()
                .OrderByDescending(e => e.Data).ToList();
            List<EventoModels> ownedEvents = usuario.GetOwnedEvents()
                .OrderByDescending(e => e.Data).ToList();

            panelParticipacoes.Controls.Clear();
            panelEventosCriados.Controls.Clear();

            foreach (EventoModels evento in subbedEvents)
            {
                panelParticipacoes.Controls.Add(CreateEventCard(evento));
                panelParticipacoes.Controls.SetChildIndex(panelParticipacoes.Controls[panelParticipacoes.Controls.Count - 1], 0);
            }

            foreach (EventoModels evento in ownedEvents)
            {
                panelEventosCriados.Controls.Add(CreateEventCard(evento));
                panelEventosCriados.Controls.SetChildIndex(panelEventosCriados.Controls[panelEventosCriados.Controls.Count - 1], 0);
            }
        }

        private void AtualizarDadosUsuario(PessoaModels usuario)
        {
            if (!string.IsNullOrEmpty(usuario.CaminhoFoto) && File.Exists(usuario.CaminhoFoto))
            {
                picPerfil.Image = Image.FromFile(usuario.CaminhoFoto);
                picturePerfil.Image = Image.FromFile(usuario.CaminhoFoto);
            }

            lblNomeUsuario.Text = usuario.Nome;
            lblNumSeguidores.Text = usuarioVisualizado.Seguidores.Count.ToString();
        }

        private CardEvento CreateEventCard(EventoModels evento)
        {
            CardEvento card = new CardEvento();

            if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
            {
                card.PicEvento.Image = Image.FromFile(evento.CaminhoImagem);
            }
            card.PicEvento.Cursor = Cursors.Hand;
            card.PicEvento.Click += (sender, e) =>
            {
                Navegador.IrParaTelaEventos(usuario, evento);
            };

            card.lblNomeEvento.Text = evento.NomeEvento;
            card.lblDataHora.Text = evento.Data.ToString("dd/MM/yyyy") + (string.IsNullOrEmpty(evento.Horario) ? "" : " " + evento.Horario);
            card.lblLocal.Text = evento.Local;
            card.lblRua.Text = evento.Rua;

            if (evento.IsPresencial)
                card.lblCidadeEstado.Text = evento.Cidade;
            else
                card.lblCidadeEstado.Text = "Online";

            return card;
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            roundedPanel10.Visible = panelVisivel;
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaOrganizarEventos(this.loggedUser);
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaAjuda(this.loggedUser);
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaSobreNos(this.loggedUser);
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaHome(this.loggedUser);
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void btnLapis_Click(object sender, EventArgs e)
        {
            cardEditarPerfilVisivel = !cardEditarPerfilVisivel;
            cardEditarPerfil.Visible = cardEditarPerfilVisivel;
            cardEditarPerfil.BringToFront();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.loggedUser);
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            cardPainelDeNotificacoesVisivel = !cardPainelDeNotificacoesVisivel;
            cardPainelDeNotificacoes.Visible = cardPainelDeNotificacoesVisivel;
            cardPainelDeNotificacoes.BringToFront();
        }

        private void btnFeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.loggedUser);
        }

        private void picPerfil_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosIngressados(this.loggedUser);
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosCriados(this.loggedUser);
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            // Proibir que o usuário siga a si mesmo
            if (loggedUser.Email == usuarioVisualizado.Email)
            {
                MessageBox.Show("Você não pode seguir a si mesmo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool seguindo = loggedUser.SeguirOuDeixarDeSeguir(usuarioVisualizado);

            labelSeguir.Text = seguindo ? "Seguindo" : "Seguir";
            lblNumSeguidores.Text = usuarioVisualizado.Seguidores.Count.ToString();

            // Adicionar notificação ao usuário seguido
            if (seguindo)
            {
                var context = new Dictionary<string, object>();
                context["perfil"] = loggedUser;
                NotificacaoModels notificacao = new NotificacaoModels(usuarioVisualizado.Email, "onBeFollowed", context);
                NotificacaoCache.AdicionarNotificacao(usuarioVisualizado.Email, notificacao);

                /* Você pode implementar lógica no botão para ir ao perfil
                card.btnVerNotificacao.Click += (s, args) =>
                {
                    Navegador.IrParaPerfilUsuario(loggedUser); // ou outra lógica
                };

                // Adicionar ao painel de notificações
                if (cardPainelDeNotificacoes != null)
                {
                    var painel = cardPainelDeNotificacoes.Controls
                        .OfType<FlowLayoutPanel>()
                        .FirstOrDefault();

                    if (painel != null)
                        painel.Controls.Add(card);
                }*/
            }
        }
        private void LoadAllPosts()
        {
            var postagensUsuario = usuario.Postagens;

            foreach (var post in postagensUsuario)
            {
                UserControl cardPost = null;

                if (post.Video != null)
                {
                    cardPost = new CardPostVideo(post, usuario);
                }
                else if (post.Imagens != null && post.Imagens.Count > 0)
                {
                    cardPost = new CardPostImagem(post, usuario);
                }
                else
                {
                    cardPost = new CardPostTexto(post, usuario);
                }
                cardPost.AutoSize = false;
                cardPost.Margin = new Padding(0, 0, 0, 10);
                panelPosts.Controls.Add(cardPost);
                panelPosts.Controls.SetChildIndex(cardPost, 0); // Para exibir o mais novo no topo
            }
        }
        private void btnEntrarEmContato_Click(object sender, EventArgs e)
        {
            string email = usuario.Email;
            string assunto = Uri.EscapeDataString("Contato via Connecta");
            string corpo = Uri.EscapeDataString("Olá, gostaria de entrar em contato com você.");
            string mailto = $"mailto:{email}?subject={assunto}&body={corpo}";

            System.Diagnostics.Process.Start(mailto);
        }

        private void superiorRoundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
