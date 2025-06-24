using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ac;

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

            var post = new PostModels(
                usuario: this.usuario,
                texto: txtTexto.Text,
                imagens: null,
                video: videoSelecionado[0]
            )
            {
                Data = DateTime.Now,
                Curtidas = new List<CurtidasModels>(),
                Comentarios = new List<ComentariosModels>()
            };


            if (this.usuario.Postagens == null)
                this.usuario.Postagens = new List<PostModels>();


            this.usuario.Postagens.Add(post);

            this.Parent.Controls.Remove(this);
            OnPostCriado?.Invoke(this, EventArgs.Empty);

            txtTexto.Clear();
            MessageBox.Show("Postagem de imagens criada com sucesso!");
        }

        private void btnFechar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.usuario);
        }
    }
}
