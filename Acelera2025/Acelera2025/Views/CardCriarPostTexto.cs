using Ac;
using Ac;
using Acelera2025.Controllers;
using Acelera2025.Telas;
using Acelera2025.Views;
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
    public partial class CardCriarPostTexto: UserControl
    {
        private Feed feed;
        private PessoaModels usuario;

        public event EventHandler OnPostCriado;
        
        public CardCriarPostTexto(PessoaModels usuario, Feed feed)
        {
            InitializeComponent();
            this.usuario = usuario;           
            this.feed = feed;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picFotoPerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }

        }

        private void btnPostar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTexto.Text))
            {
                MessageBox.Show("O texto da postagem não pode estar vazio.");
                return;
            }

            // Cria a postagem e registra globalmente
            var controller = new PostagemControllers();
            var postCriado = controller.CriarPost(this.usuario, txtTexto.Text);

            if (postCriado != null)
            {


                feed.CarregarPostagensNoFeed();
                this.Parent.Controls.Remove(this);
                OnPostCriado?.Invoke(this, EventArgs.Empty);
                txtTexto.Clear();
                MessageBox.Show("Postagem de texto criada com sucesso!");
            }
        }

        /* private void btnPostar_Click(object sender, EventArgs e)
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
             MessageBox.Show("Postagem de texto criada com sucesso!");
         } */

        private void btnFechar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.usuario);
        }

        private void picPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
