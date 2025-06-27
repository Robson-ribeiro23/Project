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
using Acelera2025.Views;

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
    }
}
