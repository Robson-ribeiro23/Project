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
            video.Ctlcontrols.pause();
            this.postagem = postagem;

            ConfigurarBotaoCurtir();
            AtualizarContadorCurtidas();
        }

        private void ConfigurarBotaoCurtir()
        {
            bool curtido = postagem.Curtidas.Any(c => c.Usuario == postagem.Usuario.Nome);
            btnCurtir.ForeColor = curtido ? Color.Red : Color.Gray;

            btnCurtir.Click += (s, e) => {
                CurtirPostagem();
            };
        }
        private void CurtirPostagem()
        {
            var curtidaExistente = postagem.Curtidas.FirstOrDefault(c => c.Usuario == postagem.Usuario.Nome);

            if (curtidaExistente != null)
            {
                postagem.Curtidas.Remove(curtidaExistente);
                btnCurtir.ForeColor = Color.Gray;
            }
            else
            {
                postagem.Curtidas.Add(new CurtidasModels(postagem.Usuario.Nome));

                btnCurtir.ForeColor = Color.Red;
            }
            AtualizarContadorCurtidas();
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
            ConfigurarBotaoCurtir();
        }
        private void AtualizarContadorCurtidas()
        {
            var controller = new PostagemControllers();
            lblCurtidas.Text = controller.ObterTotalCurtidas(postagem).ToString() + " curtidas";

        }

    }
}
