using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class CadastrarEmpresaEndereço : Form
    {
        public CadastrarEmpresaEndereço()
        {
            InitializeComponent();
           // panel2.Resize += panel2_Resize;
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void roundedPanel1_Resize(object sender, EventArgs e)
        {

        }

        /*private void panel2_Resize(object sender, EventArgs e)
        {
            int margemHorizontal = 200;
            int larguraDisponivel = Math.Max(0, panel2.ClientSize.Width - 2 * margemHorizontal);

            roundedPanel1.Width = larguraDisponivel;

            roundedPanel1.Left = (panel2.ClientSize.Width - roundedPanel1.Width) / 2;
            roundedPanel1.Top = (panel2.ClientSize.Height - roundedPanel1.Height) / 2;
        }*/

        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            EntrarEmpresa entrarEmpresa = new EntrarEmpresa();
            entrarEmpresa.Show();
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OpcaoLogin logar = new OpcaoLogin();
            logar.Show();
            this.Hide();
        }

        
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            //Principal principal = new Principal();
            //principal.Show();
            //this.Hide();
        }


        private void CadastrarEmpresaEndereço_Load(object sender, EventArgs e)
        {
            string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO",
                     "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR",
                     "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

            comboUF.Items.AddRange(estados);
        }
    }
}

