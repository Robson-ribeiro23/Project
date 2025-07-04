﻿using Ac;
using Acelera2025.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class EventosIngressados: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        public EventosIngressados(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        } 

        private void EventosIngressados_Load(object sender, EventArgs e)
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

            LoadAllEvents();
            LoadEventosOnline();
        }

        private void LoadAllEvents()
        {
            List<EventoModels> eventoList = usuario.GetSubbedEvents();

            foreach (EventoModels evento in eventoList) 
            {
                CreateEventCard(evento);
            }
        }

        private void CreateEventCard(EventoModels evento)
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


            panelInscricoes.Controls.Add(card);
        }
        private void LoadEventosOnline()
        {
            List<EventoModels> eventoOnlineList = usuario.GetSubbedEvents();
            foreach (EventoModels evento in eventoOnlineList)
            {
                if (!evento.IsPresencial)
                {
                    CreateEventoOnlineLink(evento);
                }
            }
        }
        private void CreateEventoOnlineLink(EventoModels evento)
        {
            CardTransmissãoOnline card = new CardTransmissãoOnline();

            card.lblNomeEvento.Text = evento.NomeEvento;
            card.lblDataHora.Text = evento.Data.ToString("dd/MM/yyyy") + (string.IsNullOrEmpty(evento.Horario) ? "" : " " + evento.Horario);

            card.btnCopiarLink.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(evento.LinkReuniao))
                {
                    Clipboard.SetText(evento.LinkReuniao);
                    MessageBox.Show("Link copiado para a área de transferência!", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Este evento não possui link de transmissão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            panelOnline.Controls.Add(card);
            card.BringToFront();
            panelOnline.Refresh();
            card.Visible = true;
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

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void btnOrganizarEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnEventosCriados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosCriados(this.usuario);
        }

        private void cardBaixarCertificado1_Load(object sender, EventArgs e)
        {

        }
    }
}
