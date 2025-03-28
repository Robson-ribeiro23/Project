using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025
{
    public partial class PrincipalInicial: Form
    {
        public PrincipalInicial()
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

        private void circularPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPicture1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void superiorRoundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

        }

        private void circularButton4_Click(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
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


        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Logar logar = new Logar();
            logar.Show();
            this.Hide();
        }

        private void panelEventosPerto_Paint(object sender, PaintEventArgs e)
        {

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
        private void panelEventosOnline_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
        }


    



