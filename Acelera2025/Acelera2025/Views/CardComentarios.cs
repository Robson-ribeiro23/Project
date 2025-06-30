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
    public partial class CardComentarios: UserControl
    {
            private ComentariosModels comentario;
            private PessoaModels usuario; 
            public event Action OnCurtidaAlterada;
            private PostagemControllers controller;
        public CardComentarios(ComentariosModels comentario, PessoaModels usuario)
        {
            InitializeComponent();
            this.comentario = comentario;
            this.usuario = usuario;
            controller = new PostagemControllers();


            ConfigurarComentario();
        }

        private void ConfigurarComentario()
        {
            lblNome.Text = comentario.Usuario;
            lblTexto.Text = comentario.Texto;

            if (!string.IsNullOrEmpty(usuario.CaminhoFoto) && File.Exists(usuario.CaminhoFoto))
            {
                picPerfil.BackgroundImage = Image.FromFile(usuario.CaminhoFoto);
            }
            else
            {
                picPerfil.BackgroundImage = null; 
            }
        }


        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
