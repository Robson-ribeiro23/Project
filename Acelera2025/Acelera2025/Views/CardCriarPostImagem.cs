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
    public partial class CardCriarPostImagem: UserControl
    {
        public event EventHandler OnPostCriado;
        private PessoaModels usuario;
        private List<string> imagensSelecionadas = new List<string>();
        public CardCriarPostImagem(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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
                imagens: imagensSelecionadas,
                video: null
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

        private void btnSelecionarImagem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione um arquivo",
                Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp;*.gif",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Arquivo escolhido: " + openFileDialog.FileName);
                string caminhoImagem = openFileDialog.FileName;

                if (imagensSelecionadas.Count == 0)
                {
                    imagensSelecionadas.Add(caminhoImagem);
                    picImagem1.Image = Image.FromFile(caminhoImagem);
                    picImagem1.Visible = true;
                }
                else
                {
                    imagensSelecionadas.Add(caminhoImagem);
                    picImagem2.Image = Image.FromFile(caminhoImagem);
                    picImagem2.Visible = true;
                }
            }
        }

        private void btnSelecionarImagem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione um arquivo",
                Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp;*.gif",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Arquivo escolhido: " + openFileDialog.FileName);
                string caminhoImagem = openFileDialog.FileName;

                if (imagensSelecionadas.Count == 0)
                {
                    imagensSelecionadas.Add(caminhoImagem);
                    picImagem1.Image = Image.FromFile(caminhoImagem);
                    picImagem1.Visible = true;
                }
                else
                {
                    imagensSelecionadas.Add(caminhoImagem);
                    picImagem2.Image = Image.FromFile(caminhoImagem);
                    picImagem2.Visible = true;
                }
            }
        }

        private void btnFechar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.usuario);
        }
    }
}
