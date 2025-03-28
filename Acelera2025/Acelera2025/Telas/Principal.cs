using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Telas
{
    public partial class Principal: Form
    {
        public Principal()
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


        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panelEventosPerto_Paint(object sender, PaintEventArgs e)
        {

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

            button3.Width = larguraBotao;
            button3.Left = espaco;
            button3.Top = Math.Max(0, roundedPanel1.Top + (roundedPanel1.Height - button3.Height) / 2);
            button4.Width = larguraBotao;
            button4.Left = this.ClientSize.Width - larguraBotao - espaco;
            button4.Top = Math.Max(0, roundedPanel1.Top + (roundedPanel1.Height - button4.Height) / 2);
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

            button12.Width = larguraBotao;
            button12.Left = espaco;
            button12.Top = Math.Max(0, roundedPanel6.Top + (roundedPanel6.Height - button12.Height) / 2);
            button13.Width = larguraBotao;
            button13.Left = this.ClientSize.Width - larguraBotao - espaco;
            button13.Top = Math.Max(0, roundedPanel6.Top + (roundedPanel6.Height - button12.Height) / 2);
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPicture1_Click(object sender, EventArgs e)
        {

        }

        private void panelEventosPerto_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void superiorRoundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}
