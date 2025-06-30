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
using Ac;
using Acelera2025.Telas;
using System.IO;
using Acelera2025.Models;
using System.Collections.Generic;

namespace Acelera2025.Views
{
    public partial class CardComentarios : UserControl
    {
        private ComentariosModels comentario;
        private PessoaModels usuario;

        public CardComentarios(ComentariosModels comentario)
        {
            InitializeComponent();
            this.comentario = comentario;
            

            ConfigurarComentario();
        }

        private void ConfigurarComentario()
        {
            // Criar instância do controller
            var controller = new UsuarioControllers();

            // Procurar o usuário no controller
            var pessoa = controller.ListarTodos()
                .FirstOrDefault(p => p.Email == comentario.EmailUsuario);

            lblNome.Text = pessoa != null ? pessoa.Nome : comentario.EmailUsuario;
            lblTexto.Text = comentario.Texto;

            if (pessoa != null && !string.IsNullOrEmpty(pessoa.CaminhoFoto) && File.Exists(pessoa.CaminhoFoto))
            {
                picPerfil.BackgroundImage = Image.FromFile(pessoa.CaminhoFoto);
            }
            else
            {
                picPerfil.BackgroundImage = null;
            }
        }



        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picPerfil_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
