using Ac;
using Acelera2025.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class Inicio: Form
    {
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

        public Inicio()
        {
            InitializeComponent();
            panelCategorias.Resize += PanelCategorias_Resize;
            panelEventosPerto.Resize += PanelEventosPerto_Resize;
            panelEventosOnline.Resize += PanelEventosOnline_Resize;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            PanelCategorias_Resize(null, null);
            PanelEventosPerto_Resize(null, null);
            PanelEventosOnline_Resize(null, null);


            pictureBoxes = new List<PictureBox> { PicEventoPerto1, PicEventoPerto2, PicEventoPerto3, PicEventoPerto4 };
            labelDatas = new List<Label> { lblData1, lblData2, lblData3, lblData4 };
            labelHoras = new List<Label> { lblHora1, lblHora2, lblHora3, lblHora4 };
            btnNomes = new List<LinkLabel> { btnNome1, btnNome2, btnNome3, btnNome4 };
            CidadeUfs = new List<Label> { lblCidadeUf1, lblCidadeUf2, lblCidadeUf3, lblCidadeUf4 };

            pictureBoxesOnline = new List<PictureBox> { picOnline1, picOnline2, picOnline3, picOnline4 };
            labelDatasOnline = new List<Label> { dataOnline1, dataOnline2, dataOnline3, dataOnline4};
            labelHorasOnline = new List<Label> { horaOnline1, horaOnline2, horaOnline3, horaOnline4 };
            btnNomesOnline = new List<LinkLabel> { nomeOnline1, nomeOnline2, nomeOnline3, nomeOnline4 };
            CidadeUfsOnline = new List<Label> { online1, online2, online3, online4 };

            pictureCarrosseis = new List<PictureBox> { picCarrossel };

            CarregarEventosRecentes();
            CarregarEventosOnline();
            //CarregarEventosProximos();

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

                }
            }

            // Habilita/Desabilita os botões de navegação
            btnAntPerto.Enabled = paginaAtual > 0;
            btnProxPerto.Enabled = (paginaAtual + 1) * eventosPorPagina < eventos.Count;
        }

        private void btnAntPerto_Click(object sender, EventArgs e)
        {
            paginaAtual--;
            CarregarEventosRecentes();
        }

        private void btnProxPerto_Click(object sender, EventArgs e)
        {
            paginaAtual++;
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
                }
            }

            btnAntOnline.Enabled = paginaAtual > 0;
            btnProxOnline.Enabled = (paginaAtual + 1) * eventosPorPagina < eventosOnline.Count;
        }

        private void btnAntOnline_Click(object sender, EventArgs e)
        {
            paginaAtual--;
            CarregarEventosOnline();
        }

        private void btnProxOnline_Click(object sender, EventArgs e)
        {
            paginaAtual++;
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

            for (int i = 0; i < limite; i++)
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

                }
                else
                {
                    pictureCarrosseis[i].Image = null;

                    pictureCarrosseis[i].Tag = null;

                }
            }

            btnAntEmAlta.Enabled = paginaAtual > 0;
            btnProxEmAlta.Enabled = (paginaAtual + 1) * eventosPorPagina < eventosMaisProximos.Count;
        }


        private void btnProxEmAlta_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            CarregarEventosProximos();
        }

        private void btnAntEmAlta_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 0)
            {
                paginaAtual--;
                CarregarEventosProximos();
            }
        }

        private void PanelEventosPerto_Resize(object sender, EventArgs e)
        {
            int espaco = 20;
            int larguraBotao = 50;
            int larguraDisponivel = Math.Max(0, this.ClientSize.Width - (2 * larguraBotao) - (5 * espaco));

            int larguraPainel = larguraDisponivel / 4;

            roundedPanel1.Width = roundedPanel2.Width = roundedPanel3.Width = roundedPanel4.Width = larguraPainel;

            roundedPanel1.Left = larguraBotao + espaco;
            roundedPanel2.Left = roundedPanel1.Right + espaco;
            roundedPanel3.Left = roundedPanel2.Right + espaco;
            roundedPanel4.Left = roundedPanel3.Right + espaco;

            btnAntPerto.Width = larguraBotao;
            btnAntPerto.Left = espaco;
            btnAntPerto.Top = Math.Max(0, roundedPanel1.Top + (roundedPanel1.Height - btnAntPerto.Height) / 2);
            btnProxPerto.Width = larguraBotao;
            btnProxPerto.Left = this.ClientSize.Width - larguraBotao - espaco;
            btnProxPerto.Top = Math.Max(0, roundedPanel1.Top + (roundedPanel1.Height - btnProxPerto.Height) / 2);
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

            btnAntOnline.Width = larguraBotao;
            btnAntOnline.Left = espaco;
            btnAntOnline.Top = Math.Max(0, roundedPanel6.Top + (roundedPanel6.Height - btnAntOnline.Height) / 2);
            btnProxOnline.Width = larguraBotao;
            btnProxOnline.Left = this.ClientSize.Width - larguraBotao - espaco;
            btnProxOnline.Top = Math.Max(0, roundedPanel6.Top + (roundedPanel6.Height - btnAntOnline.Height) / 2);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Navegador.IrParaOpcaoLogin();
        }

        private void btnContato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string destinatario = "dairohelp@dominio.com";

            string url = $"mailto:{destinatario}?";

            System.Diagnostics.Process.Start(url);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paginaAtual = 0;
            CarregarEventosProximos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            paginaAtual = 1;
            CarregarEventosProximos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            paginaAtual = 2;
            CarregarEventosProximos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            paginaAtual = 3;
            CarregarEventosProximos();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            paginaAtual = 4;
            CarregarEventosProximos();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            paginaAtual = 5;
            CarregarEventosProximos();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string email = "dairohel@gmail.com";
            string assunto = Uri.EscapeDataString("Contato via Connecta");
            string mailto = $"mailto:{email}?subject={assunto}";

            System.Diagnostics.Process.Start(mailto);
        }
    }
 }


    



