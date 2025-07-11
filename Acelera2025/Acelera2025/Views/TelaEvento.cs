﻿using Ac;
using Acelera2025.Models;
using Acelera2025.Presença;
using Acelera2025.Telas;
using Acelera2025.Utils;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class TelaEvento : Form
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
                btnCategoria.Text = evento.Categoria;
                btnPresencialOnline.Text = evento.IsPresencial ? "Presencial" : "Online";
                lblData.Text = evento.Data.ToString("dd/MM/yyyy");
                lblHora.Text = evento.Horario;
                lblNomeLocal.Text = evento.IsPresencial ? evento.Local : "Online";

                if (evento.IsPresencial)
                {
                    lblRua.Text = $"{evento.Rua}, {evento.Numero} - {evento.Bairro}";
                    lblCidadeUf.Text = $"{evento.Cidade} - {evento.Estado}";
                    lblCep.Text = evento.CEP;
                }
                else
                {
                    lblRua.Text = "";
                    lblCidadeUf.Text = "";
                    lblCep.Text = "";

                 
                }
                if (!evento.IsPresencial && !string.IsNullOrEmpty(evento.LinkReuniao))
                {
                    linkDoEvento.Text = evento.LinkReuniao;
                    linkDoEvento.Links.Clear();
                    linkDoEvento.Links.Add(0, evento.LinkReuniao.Length, evento.LinkReuniao);
                    linkDoEvento.Visible = true;
                }
                else
                {
                    linkDoEvento.Visible = false;
                }



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


            string emailDono = evento.UsuarioEmail;

            if (enviarEmail == null)
            {
                enviarEmail = new EnviarEmail(evento, usuario, emailDono);
                enviarEmail.Visible = false;
                this.Controls.Add(enviarEmail);
                enviarEmail.Dock = DockStyle.Fill;
            }

            enviarEmailVisivel = !enviarEmailVisivel;
            enviarEmail.Visible = enviarEmailVisivel;
            enviarEmail.BringToFront();
        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            if (usuario is EmpresaModels)
            {
                MessageBox.Show("Você não pode se inscrever em um evento como empresa.");
                return;
            }

            if (evento.criador == usuario)
            {
                MessageBox.Show("Você não pode se inscrever no seu próprio evento.");
                return;
            }

            var context = new Dictionary<string, object>();
            context["perfil"] = usuario;
            context["evento"] = evento;
            NotificacaoModels notificacao = new NotificacaoModels(evento.criador.Email, "onEventFollowed", context);
            NotificacaoCache.AdicionarNotificacao(evento.criador.Email, notificacao);

            evento.SubscribeUser((UsuarioModels)usuario);
            Navegador.IrParaEventosIngressados(usuario);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string codigoDigitado = txtCodigo.Text.Trim().ToUpper();

            bool valido = ControleDePresencas.ValidarCodigo(codigoDigitado);

            if (valido) { 
                MessageBox.Show("Presença confirmada!");
            GerarCertificado();
        }
            else{
                MessageBox.Show("Código inválido, expirado ou sem resgates disponíveis.");
            }
        }

        private void GerarCertificado()
        {
            string modeloPDF = "certificado.pdf";
            string novoPDF = $"certificadoConclusao_{evento.NomeEvento}.pdf";

            using (PdfReader reader = new PdfReader(modeloPDF))
            using (FileStream fs = new FileStream(novoPDF, FileMode.Create, FileAccess.Write))
            using (PdfStamper stamper = new PdfStamper(reader, fs))
            {
                PdfContentByte cb = stamper.GetOverContent(1);
                BaseFont fonte = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                cb.BeginText();
                cb.SetFontAndSize(fonte, 16);
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Certificamos que " + usuario.Nome, 420, 290, 0);
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "participou do evento " + evento.NomeEvento, 420, 260, 0);
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "na data e hora: " + evento.Data, 420, 230, 0);
                cb.EndText();
                stamper.FormFlattening = true;
            }

            if (File.Exists(novoPDF))
            {
                Process.Start(new ProcessStartInfo(novoPDF) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Erro: O arquivo PDF não foi criado.");
            }
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            if (usuario == null || evento == null || evento.criador == null)
            {
                MessageBox.Show("Erro ao seguir usuário. Dados incompletos.");
                return;
            }

            // Impedir seguir a si mesmo
            if (usuario.Email == evento.criador.Email)
            {
                MessageBox.Show("Você não pode seguir a si mesmo.");
                return;
            }

            // Alterna entre seguir e deixar de seguir
            bool seguindo = usuario.SeguirOuDeixarDeSeguir(evento.criador);

            labelSeguir.Text = seguindo ? "Seguindo" : "Seguir";

            if (seguindo)
            {
                var context = new Dictionary<string, object>();
                context["perfil"] = usuario;
                NotificacaoModels notificacao = new NotificacaoModels(evento.criador.Email, "onBeFollowed", context);
                NotificacaoCache.AdicionarNotificacao(evento.criador.Email, notificacao);
            }
        }

        private void lblDescricao_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkDoEvento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;

            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao abrir o link: " + ex.Message);
                }
            }
        }
    }
}
