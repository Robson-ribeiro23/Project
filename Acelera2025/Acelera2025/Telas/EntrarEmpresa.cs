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
    public partial class EntrarEmpresa: Form
    {
        public EntrarEmpresa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            CadastrarEmpresa cadastrarEmpresa = new CadastrarEmpresa();
            cadastrarEmpresa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logar logar = new Logar();
            logar.Show();
            this.Hide();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
