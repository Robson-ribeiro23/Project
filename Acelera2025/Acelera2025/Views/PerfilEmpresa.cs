using Ac;
using Acelera2025.Models;
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
    public partial class PerfilEmpresa: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
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
            this.usuario = usuario;
            this.loggedUser = UsuarioControllers.loggedUser;

            if (usuario is EmpresaModels empresaCasted)
            {
                this.empresa = empresaCasted;
                
                this.empresaVisualizada = empresaCasted;
            }
        }
        private void PerfilEmpresa_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;

            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;


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

            if (usuario is EmpresaModels empresa)
            {
                lblNomeEmpresa.Text = empresa.Nome;


                if (!string.IsNullOrEmpty(empresa.CaminhoFoto) && File.Exists(empresa.CaminhoFoto))
                {
                    picturePerfil.Image = Image.FromFile(empresa.CaminhoFoto);
                }
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

        private void btnLapis_Click(object sender, EventArgs e)
        {
            if (usuario is EmpresaModels empresa)
            {
                cardEditarPerfilEmpresa.PreencherDados(empresa); 
                cardEditarPerfilEmpresaVisivel = !cardEditarPerfilEmpresaVisivel;
                cardEditarPerfilEmpresa.Visible = cardEditarPerfilEmpresaVisivel;
                cardEditarPerfilEmpresa.BringToFront();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.usuario);
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
            Navegador.IrParaOrganizarEventos(this.usuario);
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.usuario);
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
