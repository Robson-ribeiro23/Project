using Ac;
using Ac;
using Acelera2025.Controllers;
using Acelera2025.Telas;
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
    public partial class CardCriarPostImagem: UserControl
    {
        public event EventHandler OnPostCriado;
        private PessoaModels usuario;
        private List<string> imagensSelecionadas = new List<string>();
        public CardCriarPostImagem(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                PicPerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }

        private void btnPostar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTexto.Text))
            {
                MessageBox.Show("O texto da postagem não pode estar vazio.");
                return;
            }

            var controller = new PostagemControllers();
            var postCriado = controller.CriarPost(this.usuario, txtTexto.Text, imagensSelecionadas);

            if (postCriado != null)
            {
                this.Parent.Controls.Remove(this);
                OnPostCriado?.Invoke(this, EventArgs.Empty);
                txtTexto.Clear();
                MessageBox.Show("Postagem de imagens criada com sucesso!");
            }
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

        private void picPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
