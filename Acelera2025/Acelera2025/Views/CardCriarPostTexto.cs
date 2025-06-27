using Ac;
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
using Ac;


namespace Acelera2025.Telas
{
    public partial class CardCriarPostTexto: UserControl
    {
        public event EventHandler OnPostCriado;
        private PessoaModels usuario;
        public CardCriarPostTexto(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

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
        }

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
