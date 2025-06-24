using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Views
{ 
    public partial class CardPostImagem: UserControl
    {
        private PostModels postagem;
        public CardPostImagem(PostModels postagem)
        {
            InitializeComponent();
            this.postagem = postagem;
            lblNome.Text = postagem.Usuario.Nome;
            lblTexto.Text = postagem.Texto;
            lblData.Text = postagem.Data.ToString("dd/MM/yyyy HH:mm");
            if (postagem.Imagens != null && postagem.Imagens.Count > 0)
            {
                picPost1.Image = Image.FromFile(postagem.Imagens[0]);
            }
            if (postagem.Imagens != null && postagem.Imagens.Count > 0)
            {
                picPost2.Image = Image.FromFile(postagem.Imagens[1]);
            }

        }

        private void btnCurtir_Click(object sender, EventArgs e)
        {

        }
    }
}
