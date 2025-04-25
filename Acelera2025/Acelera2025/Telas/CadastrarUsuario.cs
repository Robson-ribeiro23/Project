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
    public partial class CadastrarUsuario: Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Logar logar = new Logar();
            logar.Show();
            this.Hide();
        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            EntrarUsuario entrarUsuario = new EntrarUsuario();
            entrarUsuario.Show();
            this.Hide();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

            //Principal principal = new Principal();
            //principal.Show();
            //this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
