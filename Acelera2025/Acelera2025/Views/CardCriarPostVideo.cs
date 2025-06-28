using Ac;
using Acelera2025.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Telas
{
    public partial class CardCriarPostVideo: UserControl
    {
        public event EventHandler OnPostCriado;
        private PessoaModels usuario;
        private List<string> videoSelecionado= new List<string>();
        public CardCriarPostVideo(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            video.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picFotoPerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }

        private void btnSelecionarVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione um arquivo",
                Filter = "Vídeos|*.avi;*.flv;*.mp4;*.mov;*.wmv",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Arquivo escolhido: " + openFileDialog.FileName);
                string caminhoVideo = openFileDialog.FileName;

                if (videoSelecionado.Count == 0)
                {
                    videoSelecionado.Add(caminhoVideo);
                    video.URL = caminhoVideo;
                    video.Visible = true;

                    video.settings.volume = 0;
                }
            }
        }
        private void btnPostar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTexto.Text))
            {
                MessageBox.Show("O texto da postagem não pode estar vazio.");
                return;
            }

            if (videoSelecionado.Count == 0)
            {
                MessageBox.Show("Você precisa selecionar um vídeo.");
                return;
            }

            var controller = new PostagemControllers();
            var postCriado = controller.CriarPost(this.usuario, txtTexto.Text, null, videoSelecionado[0]);

            if (postCriado != null)
            {
                this.Parent.Controls.Remove(this);
                OnPostCriado?.Invoke(this, EventArgs.Empty);
                txtTexto.Clear();
                MessageBox.Show("Postagem de vídeo criada com sucesso!");
            }
        }

        private void btnFechar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.usuario);
        }

        private void picFotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
