using Ac;
using Acelera2025.Telas;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class Feed: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        private CardCriarPostTexto cardCriarPostTexto;
        private bool cardCriarPostTextoVisivel = false;
        private PostModels postagem;
        private CardCriarPostImagem cardCriarPostImagem;
        private bool cardCriarPostImagemVisivel = false;
        private CardCriarPostVideo cardCriarPostVideo;
        private bool cardCriarPostVideoVisivel = false;
        public Feed(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }


            CarregarPostagensNoFeed();
        }

        private void Feed_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;

            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel1.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;


            cardCriarPostTexto = new CardCriarPostTexto(this.usuario);
            cardCriarPostTexto.Visible = false;
            this.Controls.Add(cardCriarPostTexto);
            cardCriarPostTexto.Left = (this.ClientSize.Width - cardCriarPostTexto.Width) / 2;
            cardCriarPostTexto.Top = (this.ClientSize.Height - cardCriarPostTexto.Height) / 2;

            cardCriarPostImagem = new CardCriarPostImagem(this.usuario);
            cardCriarPostImagem.Visible = false;
            this.Controls.Add(cardCriarPostImagem);
            cardCriarPostImagem.Left = (this.ClientSize.Width - cardCriarPostImagem.Width) / 2;
            cardCriarPostImagem.Top = (this.ClientSize.Height - cardCriarPostImagem.Height) / 2;


            cardCriarPostVideo = new CardCriarPostVideo(this.usuario);
            cardCriarPostVideo.Visible = false;
            this.Controls.Add(cardCriarPostVideo);
            cardCriarPostVideo.Left = (this.ClientSize.Width - cardCriarPostVideo.Width) / 2;
            cardCriarPostVideo.Top = (this.ClientSize.Height - cardCriarPostVideo.Height) / 2;

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

        private void btnOrganizarEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaOrganizarEventos(this.usuario);
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

        private void btnFeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.usuario);
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaAjuda(this.usuario);
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaSobreNos(this.usuario);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.usuario);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cardCriarPostTextoVisivel= !cardCriarPostTextoVisivel;
            cardCriarPostTexto.Visible = cardCriarPostTextoVisivel;
            cardCriarPostTexto.BringToFront();
        }

        public void CarregarPostagensNoFeed()
        {
            //flowLayoutPanel1.Controls.Clear();

            var postagensOrdenadas = usuario.Postagens?
                                      .OrderByDescending(p => p.Data)
                                      .ToList();
            if (postagensOrdenadas != null)
            {
                foreach (var postagem in postagensOrdenadas)
                {
                    var cardPostTexto = new CardPostTexto(postagem);
                    var cardPostImagem = new CardPostImagem(postagem);
                    //cardPost.Margin = new Padding(10);
                    //cardPost.Width = flowLayoutPanel1.Width - 25; 
                    
                    cardPostTexto.BringToFront();
                    flowLayoutPanel1.Controls.Add(cardPostTexto);
                    cardPostImagem.BringToFront();
                    flowLayoutPanel1.Controls.Add(cardPostImagem);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardCriarPostTextoVisivel = !cardCriarPostTextoVisivel;
            cardCriarPostTexto.Visible = cardCriarPostTextoVisivel;
            cardCriarPostTexto.BringToFront();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cardCriarPostImagemVisivel = !cardCriarPostImagemVisivel;
            cardCriarPostImagem.Visible = cardCriarPostImagemVisivel;
            cardCriarPostImagem.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cardCriarPostImagemVisivel = !cardCriarPostImagemVisivel;
            cardCriarPostImagem.Visible = cardCriarPostImagemVisivel;
            cardCriarPostImagem.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cardCriarPostVideoVisivel = !cardCriarPostVideoVisivel;
            cardCriarPostVideo.Visible = cardCriarPostVideoVisivel;
            cardCriarPostVideo.BringToFront();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cardCriarPostVideoVisivel = !cardCriarPostVideoVisivel;
            cardCriarPostVideo.Visible = cardCriarPostVideoVisivel;
            cardCriarPostVideo.BringToFront();
        }
    }

    }

