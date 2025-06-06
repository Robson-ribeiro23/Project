using Ac;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class Inicio: Form
    {
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
    }
 }


    



