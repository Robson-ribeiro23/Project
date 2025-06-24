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
    public partial class CardPostVideo: UserControl
    {
        private PostModels postagem;
        public CardPostVideo(PostModels postagem)
        {
            InitializeComponent();
            this.postagem = postagem;
            lblNome.Text = postagem.Usuario.Nome;
            lblTexto.Text = postagem.Texto;
            lblData.Text = postagem.Data.ToString("dd/MM/yyyy HH:mm");
            if (!string.IsNullOrEmpty(postagem.Video))
            {
                video.URL = postagem.Video;
            }

            this.postagem = postagem;
        }
        private void CardPostVideo_Load(object sender, EventArgs e)
        {
        }
        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            

        }

        private void btnCurtir_Click(object sender, EventArgs e)
        {

        }
    }
}
