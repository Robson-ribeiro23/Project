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
        private List<Label> lblCidades;





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
            lblCidades = new List<Label> { lblCidadeUf1 , lblCidadeUf2, lblCidadeUf3, lblCidadeUf4 };
            var btnNomesOnline = new List<LinkLabel> { btnNomeEventoOnline1, btnNomeEventoOnline2, btnNomeEventoOnline3, btnNomeEventoOnline4 };
            var lblDatasOnline = new List<Label> { lblDataOnline1, lblDataOnline2, lblDataOnline3, lblDataOnline4 };
            var lblHorasOnline = new List<Label> { lblHoraOnline1, lblHoraOnline2, lblHoraOnline3, lblHoraOnline4 };



            List<EventoModels> eventos = EventoCache.ListarTodos()
           .Where(evento => !(evento.GetType().GetProperty("Excluido") != null &&
                      (bool)evento.GetType().GetProperty("Excluido").GetValue(evento)))
           .ToList();

            var eventosOnline = eventos.Where(a => !a.IsPresencial).ToList();
            var eventosPresenciais = eventos.Where(a => a.IsPresencial).ToList();

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                if (i < eventosPresenciais.Count)
                {
                    var evento = eventosPresenciais[i];

                    btnNomes[i].Text = evento.NomeEvento;
                    labelDatas[i].Text = evento.Data.ToShortDateString();
                    labelHoras[i].Text = evento.Horario;
                    lblCidades[i].Text = $"{evento.Cidade} - {evento.Estado}";

                    if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
                    {
                        pictureBoxes[i].Image = Image.FromFile(evento.CaminhoImagem);
                        pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBoxes[i].Image = null;
                    }
                }
                else
                {
                    btnNomes[i].Text = "";
                    labelDatas[i].Text = "";
                    labelHoras[i].Text = "";
                    lblCidades[i].Text = "";
                    pictureBoxes[i].Image = null;
                }
            }

            for (int i = 0; i < btnNomesOnline.Count; i++)
            {
                if (i < eventosOnline.Count)
                {
                    var evento = eventosOnline[i];

                    lblDatasOnline[i].Text = evento.Data.ToShortDateString();
                    lblHorasOnline[i].Text = evento.Horario;
                    btnNomesOnline[i].Text = evento.NomeEvento;
                    btnNomesOnline[i].Tag = evento;

                    //btnNomesOnline[i].LinkClicked -= EventoOnline_LinkClicked;
                    //btnNomesOnline[i].LinkClicked += EventoOnline_LinkClicked;
                }
                else
                {
                    lblDatasOnline[i].Text = "";
                    lblHorasOnline[i].Text = "";
                    btnNomesOnline[i].Text = "";
                    btnNomesOnline[i].Tag = null;

                   // btnNomesOnline[i].LinkClicked -= EventoOnline_LinkClicked;
                }
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

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnFeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void superiorRoundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }


    



