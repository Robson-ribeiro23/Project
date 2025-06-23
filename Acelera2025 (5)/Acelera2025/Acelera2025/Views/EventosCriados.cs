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
    public partial class EventosCriados: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;

        public EventosCriados(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }
        
        private void EventosCriados_Load(object sender, EventArgs e)
        {

            AtualizarListaDeEventos();

            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;


            this.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(this.Width - cardPerfil.Width - 20, 50);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel1.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            comboEventosCriados.Items.Clear();
            var eventos = new EventoControllers().ListarTodos();

            foreach (var evento in eventos)
            {
                comboEventosCriados.Items.Add(evento.NomeEvento);
            }

            if (comboEventosCriados.Items.Count > 0)
            {
                comboEventosCriados.SelectedIndex = 0;
            }
        }

        private void cbEventosCriados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pega o nome do evento que foi selecionado no ComboBox
            string nomeSelecionado = comboEventosCriados.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(nomeSelecionado)) return;

            // Procura o evento usando o nome
            EventoModels evento = new EventoControllers().BuscarPorNome(nomeSelecionado);
            if (evento == null) return;

            // Preenche os controles da tela com os dados do evento
            lblNomeEvento.Text = evento.NomeEvento;
            lblData.Text = evento.Data.ToString("dd/MM/yyyy");
            lblHora.Text = evento.Horario;
            lblCategorias.Text = evento.Categoria;
            lblPresencialOnline.Text = evento.IsPresencial ? "Presencial" : "Online";
            lblLimiteParticipantes.Text = evento.LimiteParticipantes.ToString();
            lblFaixaEtaria.Text = evento.FaixaEtaria;
            txtDescricao.Text = evento.Descricao;
            
        }

        private void AtualizarListaDeEventos()
        {
            comboEventosCriados.Items.Clear();

            var eventos = new EventoControllers().ListarTodos();

            if (eventos != null && eventos.Count > 0)
            {
                foreach (var evento in eventos)
                {
                    comboEventosCriados.Items.Add(evento.NomeEvento);
                }

                comboEventosCriados.SelectedIndex = 0; // Seleciona o primeiro automaticamente
            }
            else
            {
                comboEventosCriados.Items.Add("Nenhum evento encontrado.");
            }
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

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void btnEventosIngressados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosIngressados(this.usuario);
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

        private void PicEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
