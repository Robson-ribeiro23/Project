using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera2025.Controllers;

namespace Acelera2025.Views
{
    public partial class CardPostTexto: UserControl
    {
        private PostModels postagem;
        public CardPostTexto(PostModels postagem)
        {
            InitializeComponent();

            lblNome.Text = postagem.Usuario.Nome;
            lblTexto.Text = postagem.Texto;
            lblData.Text = postagem.Data.ToString("dd/MM/yyyy HH:mm");
           
        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCurtir_Click(object sender, EventArgs e)
        {

        }
    }
}
