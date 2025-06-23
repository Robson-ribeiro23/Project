using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Telas
{
    public partial class CardCriarPostTexto: UserControl
    {
        private PessoaModels usuario;
        public CardCriarPostTexto(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }

        private void btnPostar_Click(object sender, EventArgs e)
        {

            var post = new PostModels(
                this.usuario,
                txtTexto.Text,
                new List<string>(),
                null
            )
            {
                Data = DateTime.Now,
                Curtidas = new List<CurtidasModels>(),
                Comentarios = new List<ComentariosModels>()
            };

            if (this.usuario.Postagens == null)
            {
                this.usuario.Postagens = new List<PostModels>();

            }
            this.usuario.Postagens.Add(post);
        }
    }
}
