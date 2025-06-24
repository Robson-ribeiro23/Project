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

namespace Acelera2025.Views
{
    public partial class CardComentarios: UserControl
    {
            private ComentariosModels comentario;
            private string usuario; 
            public event Action OnCurtidaAlterada;
            private PostagemControllers controller;
        public CardComentarios(ComentariosModels comentario, string usuarioAtual)
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

                AtualizarBotaoCurtida();
            }

            private void AtualizarBotaoCurtida()
            {
                int totalCurtidas = comentario.Curtidas.Count;
                bool usuarioCurtiu = comentario.Curtidas.Any(c => c.Usuario == usuario);

                btnCurtir.Text = $"{totalCurtidas} ♥";
                btnCurtir.ForeColor = usuarioCurtiu ? Color.Red : SystemColors.ControlText;
                btnCurtir.Font = new Font(btnCurtir.Font, usuarioCurtiu ? FontStyle.Bold : FontStyle.Regular);
            }

       

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCurtir_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarBotaoCurtida();
                OnCurtidaAlterada?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
