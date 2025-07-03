using Ac;
using Acelera2025.Telas;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class Categorias: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        string[] categorias = { "Tecnologia", "Saúde", "Educação", "Festivais", "Música", "Artes",
                "Dança", "Ciências", "Competições e Concursos", "Espiritualidade", "Exposições e Feiras",
                "Festas", "Esportes", "Sociedade", "Gastronomia", "Empreendedorismo", "Entretenimento",
                "Voluntariado", "Meio Ambiente" , "Hobbies" };

        public Categorias(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }

        private void Categorias_Load(object sender, EventArgs e)
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
            cardPainelDeNotificacoes.Location = new Point(gradientPanel2.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            var botoesOrdenados = roundedPanel2.Controls
            .OfType<CircularButton>()
            .OrderBy(b => b.Location.Y)    // primeiro por linha (vertical)
            .ThenBy(b => b.Location.X)     // depois por coluna (horizontal)
            .ToList();

            for (int i = 0; i < botoesOrdenados.Count && i < categorias.Count(); i++)
            {
                var btn = botoesOrdenados[i];
                btn.Name = $"CircularButton_{i}";
                btn.Tag = categorias[i]; // armazena o nome da categoria

                // define imagem do botão (você pode adaptar com ícones específicos)
                string caminhoImagem = $"ImagensCategorias\\{categorias[i]}.png";
                if (File.Exists(caminhoImagem))
                {
                    btn.Image = Image.FromFile(caminhoImagem);
                    btn.Tag = caminhoImagem; // opcional: armazena o caminho da imagem
                }

                btn.Click += CategoriaButton_Clicked;

            }
        }

        private void CategoriaButton_Clicked(object sender, EventArgs e)
        {
            if (sender is CircularButton btn)
            {
                // Obtém o índice pelo nome
                string[] parts = btn.Name.Split('_');
                int index = int.Parse(parts.Last());

                string categoriaSelecionada = categorias[index];

                // Recupera a imagem do botão
                Image imagemSelecionada = btn.Image;

                // Navega passando categoria e imagem
                Navegador.IrParaCategoriaSelecionada(usuario, categoriaSelecionada, imagemSelecionada);
            }
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaHome(this.usuario);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.usuario);
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

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void btnEventosIngressados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosIngressados(this.usuario);
        }

        private void btnEventosCriados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosCriados(this.usuario);
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {

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
