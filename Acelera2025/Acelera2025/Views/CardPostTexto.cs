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
using System.IO;
using Ac;

namespace Acelera2025.Views
{
    public partial class CardPostTexto: UserControl
    {
        private PostModels postagem;
        private PessoaModels usuario;
        public CardPostTexto(PostModels postagem,PessoaModels usuario)
        {
            InitializeComponent();
            this.postagem = postagem;
            this.usuario = usuario;
            lblNome.Text = postagem.Usuario.Nome;
            lblTexto.Text = postagem.Texto;
            lblData.Text = postagem.Data.ToString("dd/MM/yyyy HH:mm");

            if (!string.IsNullOrEmpty(this.postagem.Usuario.CaminhoFoto) && File.Exists(this.postagem.Usuario.CaminhoFoto))
            {
                picFotoPerfil.Image = Image.FromFile(this.postagem.Usuario.CaminhoFoto);
            }

            ConfigurarBotaoCurtir();
            AtualizarContadorCurtidas();
            AtualizarComentarios();
        }

        private void AtualizarComentarios()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var comentario in postagem.Comentarios)
            {
                var card = new CardComentarios(comentario);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void ConfigurarBotaoCurtir()
        {
            bool curtido = postagem.Curtidas.Any(c => c.Usuario == postagem.Usuario.Nome);
            btnCurtir.ForeColor = curtido ? Color.Red : Color.Gray;

            btnCurtir.Click += (s, e) => {
                CurtirPostagem();
            };
        }

        private void CurtirPostagem()
        {
            var curtidaExistente = postagem.Curtidas.FirstOrDefault(c => c.Usuario == usuario.Nome);

            if (curtidaExistente != null)
            {
                postagem.Curtidas.Remove(curtidaExistente);
            }
            else
            {
                postagem.Curtidas.Add(new CurtidasModels(usuario.Nome));

                btnCurtir.ForeColor = Color.Red;
            }
            AtualizarContadorCurtidas();
        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCurtir_Click(object sender, EventArgs e)
        {
            ConfigurarBotaoCurtir();
        }

        private void AtualizarContadorCurtidas()
        {
            var controller = new PostagemControllers();
            lblCurtidas.Text = controller.ObterTotalCurtidas(postagem).ToString() + " curtidas";

        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            var textoComentario = txtComentarios.Text;
            var controller = new PostagemControllers();
            try
            {
                controller.AdicionarComentario(postagem, usuario , textoComentario);
                txtComentarios.Clear();
                AtualizarComentarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void picFotoPerfil_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPerfilUsuario(postagem.Usuario);
        }
    }
}
