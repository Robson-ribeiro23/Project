using Acelera2025.Telas;
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
    public partial class Logar : Form
    {
        public Logar()
        {
            InitializeComponent();
            panel1.Resize += panel1_Resize;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Resize(object sender, EventArgs e)
        {
            int espaco = 45;
            int larguraBotao = 100;
            int larguraDisponivel = Math.Max(0, panel1.ClientSize.Width - (2 * larguraBotao) - (3 * espaco));
            int larguraPainel = larguraDisponivel / 2;

            roundedPanel1.Width = roundedPanel2.Width = larguraPainel;
            roundedPanel1.Left = larguraBotao + espaco;
            roundedPanel2.Left = roundedPanel1.Right + espaco;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            EntrarEmpresa entrarEmpresa= new EntrarEmpresa();
            entrarEmpresa.Show();
            this.Hide();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrarUsuario_Click(object sender, EventArgs e)
        {
            EntrarUsuario entrarUsuario = new EntrarUsuario();
            entrarUsuario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrincipalInicial principal = new PrincipalInicial();
            principal.Show();
            this.Hide();
        }
    }
}
