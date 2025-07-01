using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ac;
using Acelera2025.Models;
using Acelera2025.Telas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Acelera2025.Views
{
    public partial class Pesquisa : Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        private UsuarioControllers usuarioController = new UsuarioControllers();
        private EventoControllers eventoController = new EventoControllers();


        public Pesquisa(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaHome(this.usuario);
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;


            gradientPanel2.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(gradientPanel2.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel1.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel2.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO",
                     "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR",
                     "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

            string[] categorias = { "Tecnologia", "Saúde", "Educação", "Festivais", "Música", "Artes",
                "Dança", "Ciências", "Competições e Concursos", "Espiritualidade", "Exposições e Feiras",
                "Festas", "Esportes", "Sociedade", "Gastronomia", "Empreendedorismo", "Entretenimento",
                "Voluntariado", "Meio Ambiente" , "Hobbies" };



            comboUF.Items.AddRange(estados);
            comboFiltrarBusca.Items.Add("Eventos");
            comboFiltrarBusca.Items.Add("Empresas");
            comboFiltrarBusca.Items.Add("Pessoas");
            comboFiltrarBusca.SelectedIndex = 0;
            comboCategoria.Items.AddRange(categorias);
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaSobreNos(this.usuario);
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaAjuda(this.usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            refreshSearch();
        }

        private void refreshSearch()
        {
            string termo = txtPesquisa.Text.Trim().ToLower();

            flowLayoutPanelResultados.Controls.Clear();

            if (comboFiltrarBusca.SelectedItem.ToString() == "Pessoas")
            {
                showUsers(termo);
            }
            else if (comboFiltrarBusca.SelectedItem.ToString() == "Eventos")
            {
                showEvents(termo);
            }
        }

        private void showUsers(string termo)
        {
            // Obtem todos os usuários
            var usuarios = usuarioController.ListarTodos();

            // Filtra os usuários
            var usuariosFiltrados = usuarios
                .Where(u =>
                (string.IsNullOrEmpty(termo) || !string.IsNullOrEmpty(u.Nome) && u.Nome.ToLower().Contains(termo))
                ).ToList();

            foreach (var usuario in usuariosFiltrados)
            {
                if (usuario == UsuarioControllers.loggedUser) continue;
                CardPesquisaUsuario card = new CardPesquisaUsuario();
                card.DefinirDadosUsuario(usuario);
                flowLayoutPanelResultados.Controls.Add(card);
            }
        }

        private void showEvents(string termo)
        {
            var eventos = eventoController.ListarTodos();

            var eventosFiltrados = eventos
                .Where(e =>
                    (string.IsNullOrEmpty(termo) || !string.IsNullOrEmpty(e.NomeEvento) && e.NomeEvento.ToLower().Contains(termo)) &&
                    (comboCategoria.SelectedItem == null || e.Categoria == comboCategoria.SelectedItem.ToString())
                ).ToList(); // Apenas retorna os eventos por nome se termo tiver algum valor e por categoria se também tiver valor

            foreach (var evento in eventosFiltrados)
            {
                CardPesquisaUsuario card = new CardPesquisaUsuario();
                card.ForçarUsuario(UsuarioControllers.loggedUser);
                card.DefinirDadosEvento(evento);
                flowLayoutPanelResultados.Controls.Add(card);
            }
        }

        private void btnPequisar_Click(object sender, EventArgs e)
        {

        }

        private void btnEventosIngressados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosIngressados(this.usuario);
        }

        private void btnEventosCriados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosCriados(this.usuario);
        }
    }
}
