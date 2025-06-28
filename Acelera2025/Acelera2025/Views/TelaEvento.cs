using Ac;
using Acelera2025.Telas;
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

namespace Acelera2025.Views
{
    public partial class TelaEvento: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        private EventoModels evento;
        private EnviarEmail enviarEmail;
        private bool enviarEmailVisivel = false;




        public TelaEvento(PessoaModels usuario, EventoModels evento)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.evento = evento;

            if (evento != null)
            {
                lblNomeEvento.Text = evento.NomeEvento;
                lblDescricao.Text = evento.Descricao;
                lblNomePublicador.Text = evento.UsuarioEmail;

                if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
                    picEvento.Image = Image.FromFile(evento.CaminhoImagem);
            }
            else
            {
                lblNomeEvento.Text = "Evento não selecionado";
                lblDescricao.Text = "";
                lblNomePublicador.Text = "";
            }

            if (!string.IsNullOrEmpty(usuario.CaminhoFoto) && File.Exists(usuario.CaminhoFoto))
                picturePerfil.Image = Image.FromFile(usuario.CaminhoFoto);
        }

        private void TelaEvento_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;


            panelPatrocinadores.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panelPatrocinadores.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panelPatrocinadores.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void Panel2_Resize(object sender, EventArgs e)
        {
            int espaco = 100;
            int margemLateral = 70;

            int larguraDisponivel = panel2.ClientSize.Width - (2 * margemLateral) - espaco;
            int larguraCadaElemento = larguraDisponivel / 2;

            int altura = panel2.ClientSize.Height;

            picEvento.Width = larguraCadaElemento;
            picEvento.Height = altura;
            picEvento.Left = margemLateral;
            picEvento.Top = 0;

            roundedPanel1.Width = larguraCadaElemento;
            roundedPanel1.Height = altura;
            roundedPanel1.Left = picEvento.Right + espaco;
            roundedPanel1.Top = 0;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaOrganizarEventos(this.usuario);
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
           Navegador.IrParaEventosCriados(this.usuario);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNomePublicador_Click(object sender, EventArgs e)
        {

        }

        private void btnPatrocinar_Click(object sender, EventArgs e)
        {

            if (!(usuario is EmpresaModels))
            {
                MessageBox.Show("Você precisa ser uma empresa para patrocinar.", "Acesso restrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enviarEmail == null)
            {
                enviarEmail = new EnviarEmail(evento, usuario);
                enviarEmail.Visible = false;
                this.Controls.Add(enviarEmail);
                enviarEmail.Dock = DockStyle.Fill;
            }

            enviarEmailVisivel = !enviarEmailVisivel;
            enviarEmail.Visible = enviarEmailVisivel;
            enviarEmail.BringToFront();
        }
    }
}
