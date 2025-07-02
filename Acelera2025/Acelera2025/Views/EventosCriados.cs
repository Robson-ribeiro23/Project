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
        }

        public void AtualizarListaDeEventos()
        {
            comboEventosCriados.Items.Clear();

            // Supondo que você tenha o usuário logado em this.usuario.Email
            string emailUsuarioLogado = this.usuario.Email;

            List<EventoModels> eventos = EventoControllers.ListarTodos();

            // FILTRA apenas os eventos do usuário logado
            var eventosDoUsuario = eventos
            .Where(e => e.UsuarioEmail == emailUsuarioLogado)
            .ToList();

            if (eventosDoUsuario.Count > 0)
            {
                foreach (var evento in eventosDoUsuario)
                {
                    comboEventosCriados.Items.Add(evento.NomeEvento);
                }

                comboEventosCriados.SelectedIndex = 0;
            }
            else
            {
                comboEventosCriados.Items.Add("Nenhum evento encontrado");
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

        private void comboEventosCriados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeSelecionado = comboEventosCriados.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(nomeSelecionado)) return;

            EventoModels evento = new EventoControllers().BuscarPorNome(nomeSelecionado);
            if (evento == null || evento.UsuarioEmail != this.usuario.Email) return;

            lblNomeEvento.Text = evento.NomeEvento;
            lblData.Text = evento.Data.ToString("dd/MM/yyyy");
            lblHora.Text = evento.Horario;
            lblCategorias.Text = evento.Categoria;
            lblPresencialOnline.Text = evento.IsPresencial ? "Presencial" : "Online";
            lblLimiteParticipantes.Text = evento.LimiteParticipantes.ToString();
            lblFaixaEtaria.Text = evento.FaixaEtaria;
            txtDescricao.Text = evento.Descricao;

            // Novos dados
            lblNomeLocal.Text = evento.Local;

            lblEndereco.Text = $"{evento.Rua}, {evento.Numero}, {evento.Bairro}";
            lblCidadeEstado.Text = $"{evento.Cidade} - {evento.Estado}";
            lblCEP.Text = evento.CEP;
            lblLinkReuniao.Text = evento.IsPresencial ? "Evento presencial" : evento.LinkReuniao;
            panelPresencial.Visible = evento.IsPresencial;
            panelOnline.Visible = !evento.IsPresencial;
            lblParticipantes.Text = evento.GetUserList().Count().ToString();
            
            // Atualização
            txtNomeEvento.Text = evento.NomeEvento;
            data.Value = evento.Data;
            data.Text = evento.Data.ToString("dd/MM/yyyy");
            txtHora.Text = evento.Horario;
            txtLink.Text = evento.LinkReuniao;
            txtParticipantes.Text = evento.LimiteParticipantes.ToString();
            txtNovaDescricao.Text = evento.Descricao;
            txtNomeLocal.Text = evento.Local;
            txtRua.Text = evento.Rua;
            txtNumero.Text = evento.Numero;
            txtCEP.Text = evento.CEP;
            txtBairro.Text = evento.Bairro;

            if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
            {
                using (var imgTemp = Image.FromFile(evento.CaminhoImagem))
                {
                    PicImagemEvento.Image = new Bitmap(imgTemp);
                }
                PicImagemEvento.SizeMode = PictureBoxSizeMode.Zoom; 
            }
            else
            {
                PicImagemEvento.Image = null; 
            }

            lblLinkReuniao.Text = evento.IsPresencial ? "Evento presencial" : evento.LinkReuniao;
            presencial.Visible = evento.IsPresencial;
            online.Visible = !evento.IsPresencial;

            // Obtém a quantidade de participantes e o limite
            int qtdParticipantes = evento.GetUserList().Count();
            int limite = evento.LimiteParticipantes;

            // Evita divisão por zero
            double porcentagem = (limite > 0) ? (qtdParticipantes * 100.0 / limite) : 0;

            // Baixo rendimento: menor que 40%
            if (porcentagem < 40)
            {
                picBaixoRendimento.BorderColor = Color.Blue;
                picBaixoRendimento.BorderSize = 3;
                label6.ForeColor = Color.Red;
            }
            else
            {
                picBaixoRendimento.BorderSize = 0;
                picMedioRendimento.BorderSize = 0;
                picAltoRendimento.BorderSize = 0;

                // Medio rendimento: de 40% a 60%
                if (porcentagem >= 40 && porcentagem <= 60)
                {
                    picMedioRendimento.BorderColor = Color.Orange;
                    picMedioRendimento.BorderSize = 3;
                    label8.ForeColor = Color.Orange;
                }
                // Alto rendimento: acima de 60%
                else if (porcentagem > 60)
                {
                    picAltoRendimento.BorderColor = Color.Green;
                    picAltoRendimento.BorderSize = 3;
                    label9.ForeColor = Color.Green;
                }
            }

            if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
            {
                using (var imgTemp = Image.FromFile(evento.CaminhoImagem))
                {
                    PicEvento.Image = new Bitmap(imgTemp);
                }
                PicEvento.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                PicEvento.Image = null;
            }

            panelParticipantes.Controls.Clear();
            foreach (UsuarioModels u in evento.GetUserList()) 
            { 
                CreateSubbedCard(u);
            }
        }

        private void CreateSubbedCard(UsuarioModels u)
        {
            CardParticipantes card = new CardParticipantes();
            
            card.lblNome.Text = u.Nome;
            card.SetImage(u.CaminhoFoto);

            panelParticipantes.Controls.Add(card);
        }

        private void btnOrganizarEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaOrganizarEventos(this.usuario);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.usuario);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nomeSelecionado = comboEventosCriados.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(nomeSelecionado) || nomeSelecionado == "Nenhum evento encontrado")
            {
                MessageBox.Show("Selecione um evento para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca o evento pelo nome
            EventoModels evento = new EventoControllers().BuscarPorNome(nomeSelecionado);
            if (evento == null || evento.UsuarioEmail != this.usuario.Email)
            {
                MessageBox.Show("Evento não encontrado ou você não tem permissão para atualizá-lo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            evento.NomeEvento = txtNomeEvento.Text;
            evento.Data = data.Value;
            evento.Horario = txtHora.Text;
            evento.LimiteParticipantes = int.TryParse(txtParticipantes.Text, out int limite) ? limite : evento.LimiteParticipantes;
            evento.Descricao = txtNovaDescricao.Text;
            evento.Local = txtNomeLocal.Text;
            evento.Rua = txtRua.Text;
            evento.Numero = txtNumero.Text;
            evento.CEP = txtCEP.Text;
            evento.Bairro = txtBairro.Text;
            evento.LinkReuniao = txtLink.Text;

            EventoControllers eventoController = new EventoControllers();
            eventoController.EditarEvento(
                evento.NomeEvento,
                evento.Data,
                evento.Horario,
                evento.LinkReuniao,
                evento.LimiteParticipantes,
                evento.Descricao,
                evento.Local,
                evento.Rua,
                evento.Numero,
                evento.CEP,
                evento.Bairro,
                evento.CaminhoImagem
            );

            MessageBox.Show("Evento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarListaDeEventos();
            comboEventosCriados.SelectedItem = evento.NomeEvento;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeSelecionado = comboEventosCriados.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(nomeSelecionado) || nomeSelecionado == "Nenhum evento encontrado")
            {
                MessageBox.Show("Selecione um evento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca o evento pelo nome
            EventoModels evento = new EventoControllers().BuscarPorNome(nomeSelecionado);
            if (evento == null || evento.UsuarioEmail != this.usuario.Email)
            {
                MessageBox.Show("Evento não encontrado ou você não tem permissão para excluí-lo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"Tem certeza que deseja excluir o evento '{evento.NomeEvento}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            // Remove o evento
            EventoControllers eventoController = new EventoControllers();
            bool sucesso = eventoController.RemoverEvento(evento.NomeEvento);

            if (sucesso)
            {
                MessageBox.Show("Evento excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListaDeEventos();
                // Limpa os campos de detalhes
                lblNomeEvento.Text = "";
                lblData.Text = "";
                lblHora.Text = "";
                lblCategorias.Text = "";
                lblPresencialOnline.Text = "";
                lblLimiteParticipantes.Text = "";
                lblFaixaEtaria.Text = "";
                txtDescricao.Text = "";
                lblNomeLocal.Text = "";
                lblEndereco.Text = "";
                lblCidadeEstado.Text = "";
                lblCEP.Text = "";
                lblLinkReuniao.Text = "";
                lblParticipantes.Text = "";
                txtNomeEvento.Text = "";
                txtHora.Text = "";
                txtLink.Text = "";
                txtParticipantes.Text = "";
                txtNovaDescricao.Text = "";
                txtNomeLocal.Text = "";
                txtRua.Text = "";
                txtNumero.Text = "";
                txtCEP.Text = "";
                txtBairro.Text = "";
                PicImagemEvento.Image = null;
                PicEvento.Image = null;
                panelParticipantes.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao excluir o evento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

