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

            this.usuario = pessoa;

            lblNome.Text = pessoa != null ? pessoa.Nome : comentario.EmailUsuario;
            lblTexto.Text = comentario.Texto;

            if (pessoa != null && !string.IsNullOrEmpty(pessoa.CaminhoFoto) && File.Exists(pessoa.CaminhoFoto))
            {
                picPerfil.Image = Image.FromFile(pessoa.CaminhoFoto);
            }
            else
            {
                picPerfil.Image = null;
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            if( usuario != null)
            {
                Navegador.IrParaPerfilUsuario(usuario);
            }
            else
            {
                MessageBox.Show("Usuário não definido.");
            }
        }

        private void picPerfil_Click_1(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                Navegador.IrParaPerfilUsuario(usuario);
            }
            else
            {
                MessageBox.Show("Usuário não definido.");
            }
        }
    }
}
