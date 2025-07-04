using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ac;
using Acelera2025.Controllers;
using Acelera2025.Models;
using Acelera2025.Telas;

namespace Acelera2025.Views
{
    public partial class PerfilEmpresa: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        private bool cardEditarPerfilEmpresaVisivel = false;
        private CardEditarPerfilEmpresa cardEditarPerfilEmpresa;
        private EmpresaModels empresa;
        private PessoaModels loggedUser;
        private EmpresaModels empresaVisualizada;

        public PerfilEmpresa(PessoaModels usuario)
        {
            InitializeComponent();
            this.loggedUser = UsuarioControllers.loggedUser != null ? (PessoaModels)UsuarioControllers.loggedUser : (PessoaModels)EmpresaControllers.loggedCompany;

            if (usuario is EmpresaModels empresaCasted)
            {
                this.empresa = empresaCasted;
                
                this.empresaVisualizada = empresaCasted;
            }

            btnSeguir.Text = loggedUser.EstaSeguindo(empresaVisualizada) ? "Seguindo" : "Seguir";

            if (loggedUser != null && !string.IsNullOrEmpty(loggedUser.CaminhoFoto) && File.Exists(loggedUser.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(loggedUser.CaminhoFoto);
            }
            if (!string.IsNullOrEmpty(this.empresa.CaminhoFoto) && File.Exists(this.empresa.CaminhoFoto))
            {
                picPerfilEmpresa.Image = Image.FromFile(this.empresa.CaminhoFoto);
            }
        }
        private void PerfilEmpresa_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil(this.loggedUser);
            cardPerfil.Visible = false;

            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;


            lblNomeEmpresa.Text = this.empresa.Nome;
            cardEditarPerfilEmpresa = new CardEditarPerfilEmpresa();
            cardEditarPerfilEmpresa.Visible = false;

            cardEditarPerfilEmpresa.DadosAtualizados += AtualizarDadosEmpresa;

            CarregarEndereco();


            panel1.Controls.Add(cardEditarPerfilEmpresa);
            cardEditarPerfilEmpresa.Left = (this.ClientSize.Width - cardEditarPerfilEmpresa.Width) / 2;
            cardEditarPerfilEmpresa.FecharTelaSolicitado += (s, args) => this.Close();
            cardEditarPerfilEmpresa.Top = (this.ClientSize.Height - cardEditarPerfilEmpresa.Height) / 2;


            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel1.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            LoadAllEvents();
            LoadAllPosts();
        }

        private void LoadAllEvents()
        {
            List<EventoModels> ownedEvents = empresa.GetOwnedEvents()
                .OrderByDescending(e => e.Data).ToList();

            panelEventosCriados.Controls.Clear();

            foreach (EventoModels evento in ownedEvents)
            {
                panelEventosCriados.Controls.Add(CreateEventCard(evento));
                panelEventosCriados.Controls.SetChildIndex(panelEventosCriados.Controls[panelEventosCriados.Controls.Count - 1], 0);
            }
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
                Navegador.IrParaTelaEventos(loggedUser, evento);
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

        private void LoadAllPosts()
        {
            var postagensUsuario = empresa.Postagens;

            foreach (var post in postagensUsuario)
            {
                UserControl cardPost = null;

                if (post.Video != null)
                {
                    cardPost = new CardPostVideo(post, empresa);
                }
                else if (post.Imagens != null && post.Imagens.Count > 0)
                {
                    cardPost = new CardPostImagem(post, empresa);
                }
                else
                {
                    cardPost = new CardPostTexto(post, empresa);
                }
                cardPost.AutoSize = false;
                cardPost.Margin = new Padding(0, 0, 0, 10);
                panelPosts.Controls.Add(cardPost);
                panelPosts.Controls.SetChildIndex(cardPost, 0);
            }
        }

        private void CarregarEndereco()
        {
            if (empresa != null)
            {
                lblEnderecoCompleto.Text = $"{empresa.Rua}, {empresa.Numero} - {empresa.Bairro}, {empresa.Cidade} - {empresa.UF} | CEP: {empresa.CEP}";

            }
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
            if (empresa.Email == loggedUser.Email)
            {
                cardEditarPerfilEmpresa.PreencherDados(empresa); 
                cardEditarPerfilEmpresaVisivel = !cardEditarPerfilEmpresaVisivel;
                cardEditarPerfilEmpresa.Visible = cardEditarPerfilEmpresaVisivel;
                cardEditarPerfilEmpresa.BringToFront();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.loggedUser);
        }

        private void AtualizarDadosEmpresa(EmpresaModels empresa)
        {
            if (!string.IsNullOrEmpty(empresa.CaminhoFoto) && File.Exists(empresa.CaminhoFoto))
            {
                using (var stream = new FileStream(empresa.CaminhoFoto, FileMode.Open, FileAccess.Read))
                {
                    picturePerfil.Image = Image.FromStream(stream);
                    picPerfilEmpresa.Image = Image.FromFile(empresa.CaminhoFoto);
                }
            }
        }


        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            cardPainelDeNotificacoesVisivel = !cardPainelDeNotificacoesVisivel;
            cardPainelDeNotificacoes.Visible = cardPainelDeNotificacoesVisivel;
            cardPainelDeNotificacoes.BringToFront();
        }

        private void btnOrganizarEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaOrganizarEventos(this.loggedUser);
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.loggedUser);
        }

        private void superiorRoundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            if (loggedUser == null || empresaVisualizada == null)
            {
                MessageBox.Show("Erro ao identificar usuários.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loggedUser.Email == empresaVisualizada.Email)
            {
                MessageBox.Show("Você não pode seguir a si mesmo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool seguindo = loggedUser.SeguirOuDeixarDeSeguir(empresaVisualizada);

            lblSeguir.Text = seguindo ? "Seguindo" : "Seguir";
            lblNumSeguidores.Text = empresaVisualizada.Seguidores.Count.ToString();

            if (seguindo)
            {
                var context = new Dictionary<string, object>();
                context["perfil"] = loggedUser;
                NotificacaoModels notificacao = new NotificacaoModels(empresaVisualizada.Email, "onBeFollowed", context);
                NotificacaoCache.AdicionarNotificacao(empresaVisualizada.Email, notificacao);
            }
        }
    }
}
