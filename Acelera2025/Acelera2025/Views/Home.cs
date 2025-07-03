using Ac;
using Acelera2025.Models;
using Acelera2025.Telas;
using iTextSharp.text.pdf.events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;




namespace Acelera2025.Views
{
    public partial class Home: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;

        private List<PictureBox> pictureBoxes;
        private List<Label> labelDatas;
        private List<Label> labelHoras;
        private List<LinkLabel> btnNomes;
        private List<Label> CidadeUfs;

        private List<PictureBox> pictureBoxesOnline;
        private List<Label> labelDatasOnline;
        private List<Label> labelHorasOnline;
        private List<LinkLabel> btnNomesOnline;
        private List<Label> CidadeUfsOnline;

        private List<PictureBox> pictureCarrosseis;
        public Home(PessoaModels usuario)
        {
            InitializeComponent();



            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }

            panelCategorias.Resize += PanelCategorias_Resize;
            panelEventosPerto.Resize += PanelEventosPerto_Resize;
            panelEventosOnline.Resize += PanelEventosOnline_Resize;


        }
        private void Principal_Load(object sender, EventArgs e)
        {
            PanelCategorias_Resize(null, null);
            PanelEventosPerto_Resize(null, null);
            PanelEventosOnline_Resize(null, null);
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;


            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            panel2.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel2.Width - cardPerfil.Width - 20, 0);
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel2.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPainelDeNotificacoes.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            CarregarNotificacoes();

            pictureBoxes = new List<PictureBox> { PicEventoPerto1, PicEventoPerto2, PicEventoPerto3, PicEventoPerto4 };
            labelDatas = new List<Label> { lblData1, lblData2, lblData3, lblData4 };
            labelHoras = new List<Label> { lblHora1, lblHora2, lblHora3, lblHora4 };
            btnNomes = new List<LinkLabel> { btnNome1, btnNome2, btnNome3, btnNome4 };
            CidadeUfs = new List<Label> { lblCidadeUf1, lblCidadeUf2, lblCidadeUf3, lblCidadeUf4 };

            pictureBoxesOnline = new List<PictureBox> { picEventoOnline1, picEventoOnline2, picEventoOnline3, picEventoOnline4 };
            labelDatasOnline = new List<Label> { lblDataOnline1, lblDataOnline2, lblDataOnline3, lblDataOnline4 };
            labelHorasOnline = new List<Label> { lblHoraOnline1, lblHoraOnline2, lblHoraOnline3, lblHoraOnline4 };
            btnNomesOnline = new List<LinkLabel> { btnNomeEventoOnline1, btnNomeEventoOnline2, btnNomeEventoOnline3, btnNomeEventoOnline4 };
            CidadeUfsOnline = new List<Label> {Online1, Online2, Online3, Online4 };

            pictureCarrosseis = new List<PictureBox> { picCarrossel };

            CarregarEventosRecentes();
            CarregarEventosOnline();
            CarregarEventosProximos();
        }

        int paginaAtual = 0;

        private void CarregarEventosRecentes()
        {
           
            int eventosPorPagina = 3;
            List<EventoModels> eventos = EventoCache.ListarTodos();

            var eventosOrdenados = EventoCache.ListarTodos()
                                       .OrderByDescending(e => e.Data)
                                       .Take(20)
                                       .ToList();

            int inicio = paginaAtual * eventosPorPagina;

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                int indexEvento = inicio + i;

                if (indexEvento < eventosOrdenados.Count)
                {
                    var evento = eventosOrdenados[indexEvento];

                    labelDatas[i].Text = evento.Data.ToShortDateString();
                    labelHoras[i].Text = evento.Horario;
                    btnNomes[i].Text = evento.NomeEvento;
                    
                    if (evento.IsPresencial)
                        CidadeUfs[i].Text = $"{evento.Cidade} - {evento.Estado}";
                    else
                        CidadeUfs[i].Text = "Online";


                    if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
                        pictureBoxes[i].Image = Image.FromFile(evento.CaminhoImagem);
                    else
                        pictureBoxes[i].Image = null;

                    pictureBoxes[i].Tag = evento;
                    btnNomes[i].Tag = evento;

                    pictureBoxes[i].Click -= Evento_Click;
                    pictureBoxes[i].Click += Evento_Click;

                    btnNomes[i].LinkClicked -= Evento_LinkClicked;
                    btnNomes[i].LinkClicked += Evento_LinkClicked;
                }
                else
                {
                    labelDatas[i].Text = "";
                    labelHoras[i].Text = "";
                    btnNomes[i].Text = "";
                    pictureBoxes[i].Image = null;
                    CidadeUfs[i].Text = "";
                    pictureBoxes[i].Tag = null;
                    btnNomes[i].Tag = null;

                    pictureBoxes[i].Click -= Evento_Click;
                    btnNomes[i].LinkClicked -= Evento_LinkClicked;
                }
            }

            // Habilita/Desabilita os botões de navegação
            btnAntEventoPerto.Enabled = paginaAtual > 0;
            btnProxEventoPerto.Enabled = (paginaAtual + 1) * eventosPorPagina < eventos.Count;
        }
        private void btnProxEventoPerto_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            CarregarEventosRecentes();
        }

        private void btnAntEventoPerto_Click(object sender, EventArgs e)
        {
            paginaAtual--;
            CarregarEventosRecentes();
        }
        private void CarregarEventosOnline()
        {
            
            int eventosPorPagina = 3;
            List<EventoModels> eventos = EventoCache.ListarTodos();

            var eventosOnline = EventoCache.ListarTodos()
                                           .Where(e => !e.IsPresencial) 
                                           .OrderByDescending(e => e.Data)
                                           .Take(20)
                                           .ToList();

            int inicio = paginaAtual * eventosPorPagina;

            for (int i = 0; i < pictureBoxesOnline.Count; i++)
            {
                int indexEvento = inicio + i;

                if (indexEvento < eventosOnline.Count)
                {
                    var evento = eventosOnline[indexEvento];

                    labelDatasOnline[i].Text = evento.Data.ToShortDateString();
                    labelHorasOnline[i].Text = evento.Horario;
                    btnNomesOnline[i].Text = evento.NomeEvento;
                    CidadeUfsOnline[i].Text = "Online";

                    if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
                        pictureBoxesOnline[i].Image = Image.FromFile(evento.CaminhoImagem);
                    else
                        pictureBoxesOnline[i].Image = null;

                    pictureBoxesOnline[i].Tag = evento;
                    btnNomesOnline[i].Tag = evento;

                    pictureBoxesOnline[i].Click -= Evento_Click;
                    pictureBoxesOnline[i].Click += Evento_Click;

                    btnNomesOnline[i].LinkClicked -= Evento_LinkClicked;
                    btnNomesOnline[i].LinkClicked += Evento_LinkClicked;
                }
                else
                {
                    labelDatasOnline[i].Text = "";
                    labelHorasOnline[i].Text = "";
                    btnNomesOnline[i].Text = "";
                    CidadeUfsOnline[i].Text = "";
                    pictureBoxesOnline[i].Image = null;

                    pictureBoxesOnline[i].Tag = null;
                    btnNomesOnline[i].Tag = null;

                    pictureBoxesOnline[i].Click -= Evento_Click;
                    btnNomesOnline[i].LinkClicked -= Evento_LinkClicked;
                }
            }

            btnAntEventosOnline.Enabled = paginaAtual > 0;
            btnProxEventosOnline.Enabled = (paginaAtual + 1) * eventosPorPagina < eventosOnline.Count;
        }

        private void btnProxEventosOnline_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            CarregarEventosOnline();
        }

        private void btnAntEventosOnline_Click(object sender, EventArgs e)
        {
            paginaAtual--;
            CarregarEventosOnline();
        }

        private void CarregarEventosProximos()
        {
            int eventosPorPagina = 1;
            List<EventoModels> eventos = EventoCache.ListarTodos();

            var eventosMaisProximos = EventoCache.ListarTodos()
            .Where(e => e.Data >= DateTime.Today)       // só eventos de hoje em diante
            .OrderBy(e => e.Data)                        // data mais próxima primeiro
            .Take(6)                                    
            .ToList();


            int inicio = paginaAtual * eventosPorPagina;
            int limite = Math.Min(pictureBoxes.Count, pictureCarrosseis.Count);

            for (int i = 0; i < limite ; i++)
            {
                int indexEvento = inicio + i;

                if (indexEvento < eventosMaisProximos.Count)
                {
                    var evento = eventosMaisProximos[indexEvento];

                    if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
                        pictureCarrosseis[i].Image = Image.FromFile(evento.CaminhoImagem);
                    else
                        pictureCarrosseis[i].Image = null;

                    pictureCarrosseis[i].Tag = evento;

                    pictureCarrosseis[i].Click -= Evento_Click;
                    pictureCarrosseis[i].Click += Evento_Click;

                }
                else
                {
                    pictureCarrosseis[i].Image = null;

                    pictureCarrosseis[i].Tag = null;

                    pictureCarrosseis[i].Click -= Evento_Click;
                }
            }

            btnAntEventosOnline.Enabled = paginaAtual > 0;
            btnProxEventosOnline.Enabled = (paginaAtual + 1) * eventosPorPagina < eventosMaisProximos.Count;
        }

        private void btnAntCarrossel_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 0)
            {
                paginaAtual--;
                CarregarEventosProximos();
            }
        }

        private void btnProxCarrossel_Click(object sender, EventArgs e)
        {

                    paginaAtual++;
                    CarregarEventosProximos();

        }
        private void PicEvento_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pic && pic.Tag is EventoModels evento)
            {
                Navegador.IrParaTelaEventos(this.usuario, evento);
                
            }
        }

        private void PanelEventosPerto_Resize(object sender, EventArgs e)
        {
            int espaco = 20;
            int larguraBotao = 50;
            int larguraDisponivel = Math.Max(0, panelEventosPerto.ClientSize.Width - (2 * larguraBotao) - (5 * espaco));

            int larguraPainel = larguraDisponivel / 4;

            roundedPanel1.Width = roundedPanel2.Width = roundedPanel3.Width = roundedPanel4.Width = larguraPainel;

            roundedPanel1.Left = larguraBotao + espaco;
            roundedPanel2.Left = roundedPanel1.Right + espaco;
            roundedPanel3.Left = roundedPanel2.Right + espaco;
            roundedPanel4.Left = roundedPanel3.Right + espaco;

            btnAntEventoPerto.Width = larguraBotao;
            btnAntEventoPerto.Left = espaco;
            btnAntEventoPerto.Top = Math.Max(0, roundedPanel1.Top + (roundedPanel1.Height - btnAntEventoPerto.Height) / 2);
            btnProxEventoPerto.Width = larguraBotao;
            btnProxEventoPerto.Left = this.ClientSize.Width - larguraBotao - espaco;
            btnProxEventoPerto.Top = Math.Max(0, roundedPanel1.Top + (roundedPanel1.Height - btnProxEventoPerto.Height) / 2);
        }

        private void PanelCategorias_Resize(object sender, EventArgs e)
        {
            int espaco = 110;
            int larguraBotao = 60;
            int larguraDisponivel = Math.Max(0, panelCategorias.ClientSize.Width - (5 * espaco) - (2 * larguraBotao));
            int larguraPainel = Math.Max(50, larguraDisponivel / 5);

            int totalLarguraBotoes = (5 * larguraPainel) + (4 * espaco);
            int deslocamentoInicial = Math.Max(0, (panelCategorias.ClientSize.Width - totalLarguraBotoes) / 2);

            int posicaoBotao = 0;
            foreach (Control control in panelCategorias.Controls)
            {
                if (control is Button btn)
                {
                    btn.Width = larguraPainel;
                    btn.Left = deslocamentoInicial + posicaoBotao * (larguraPainel + espaco);
                    btn.Top = Math.Max(0, (panelCategorias.Height - btn.Height) / 2);
                    btn.BackgroundImageLayout = ImageLayout.Zoom;


                    string labelName = "label" + (posicaoBotao + 1);
                    Label label = panelCategorias.Controls.OfType<Label>().FirstOrDefault(l => l.Name == labelName);

                    if (label != null)
                    {
                        label.Left = btn.Left + (btn.Width - label.Width) / 2;
                        label.Top = btn.Bottom + 10;
                    }

                    posicaoBotao++;
                }
            }
        }

        private void CarregarNotificacoes()
        {
            return;
            /*
            var lista = NotificacaoCache.ObterNotificacoes(usuario.Email); 

            var painel = cardPainelDeNotificacoes.Controls
                .OfType<FlowLayoutPanel>()
                .FirstOrDefault();

            if (painel != null)
            {
                painel.Controls.Clear(); 

                foreach (var notif in lista)
                {
                    var card = new CardNotificacao();
                    card.lblTitulo.Text = $"{notif.NomeDeQuemSeguiu} começou a te seguir!";

                    card.btnVerNotificacao.Click += (s, args) =>
                    {
                        var seguidor = UsuarioControllers.ListarTodos()
                            .FirstOrDefault(u => u.Email == notif.EmailDeQuemSeguiu);

                        if (seguidor != null)
                            Navegador.IrParaPerfilUsuario(seguidor);
                    };

                    painel.Controls.Add(card);
                }
            }*/
        }


        private void Evento_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pic && pic.Tag is EventoModels evento)
            {
                Navegador.IrParaTelaEventos(this.usuario, evento);
            }
        }

        private void Evento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is LinkLabel link && link.Tag is EventoModels evento)
            {
                Navegador.IrParaTelaEventos(this.usuario, evento);
            }
        }

        private void PanelEventosOnline_Resize(object sender, EventArgs e)
        {

            int espaco = 20;
            int larguraBotao = 50;
            int larguraDisponivel = Math.Max(0, this.ClientSize.Width - (2 * larguraBotao) - (5 * espaco));

            int larguraPainel = larguraDisponivel / 4;

            roundedPanel6.Width = roundedPanel7.Width = roundedPanel8.Width = roundedPanel9.Width = larguraPainel;

            roundedPanel6.Left = larguraBotao + espaco;
            roundedPanel7.Left = roundedPanel6.Right + espaco;
            roundedPanel8.Left = roundedPanel7.Right + espaco;
            roundedPanel9.Left = roundedPanel8.Right + espaco;

            btnAntEventosOnline.Width = larguraBotao;
            btnAntEventosOnline.Left = espaco;
            btnAntEventosOnline.Top = Math.Max(0, roundedPanel6.Top + (roundedPanel6.Height - btnAntEventosOnline.Height) / 2);
            btnProxEventosOnline.Width = larguraBotao;
            btnProxEventosOnline.Left = this.ClientSize.Width - larguraBotao - espaco;
            btnProxEventosOnline.Top = Math.Max(0, roundedPanel6.Top + (roundedPanel6.Height - btnAntEventosOnline.Height) / 2);

            
        }
        private void picCarrosel_Click(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void btnEventosCriados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosCriados(this.usuario);
        }

        private void btnMeusEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaAjuda(this.usuario);
        }

        private void OrganizarEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaOrganizarEventos(this.usuario);
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaSobreNos(this.usuario);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.usuario);
        }

        private void btnVerMaisCategorias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaCategorias(this.usuario);
        }

        private void btnNome1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void btnNome2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void btnNome3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void btnNome4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void btnNomeEventoOnline1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void btnNomeEventoOnline2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void btnNomeEventoOnline3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void btnNomeEventoOnline4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void PicEventoPerto1_DoubleClick(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void PicEventoPerto2_Click(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void PicEventoPerto3_Click(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void PicEventoPerto4_Click(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void picEventoOnline1_Click(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void picEventoOnline2_Click(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void picEventoOnline3_Click(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void picEventoOnline4_Click(object sender, EventArgs e)
        {
            Navegador.IrParaTelaEventos(this.usuario);
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaHome(this.usuario);
        }

        private void btnEventosIngressados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosIngressados(this.usuario);
        }

        private void btnContato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string destinatario = "dairohelp@dominio.com";

            string url = $"mailto:{destinatario}?";

            System.Diagnostics.Process.Start(url);
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
        // Botões
        private void btnCarrossel1_Click(object sender, EventArgs e)
        {
            paginaAtual = 0;
            CarregarEventosProximos();
        }

        private void btnCarrossel2_Click(object sender, EventArgs e)
        {
            paginaAtual = 1;
            CarregarEventosProximos();
        }

        private void btnCarrossel3_Click(object sender, EventArgs e)
        {
            paginaAtual = 2;
            CarregarEventosProximos();
        }

        private void btnCarrossel4_Click(object sender, EventArgs e)
        {
            paginaAtual = 3;
            CarregarEventosProximos();
        }

        private void btnCarrossel5_Click(object sender, EventArgs e)
        {
            paginaAtual = 4;
            CarregarEventosProximos();
        }

        private void btnCarrossel6_Click(object sender, EventArgs e)
        {
            paginaAtual = 5;
            CarregarEventosProximos();
        }

    }
}
