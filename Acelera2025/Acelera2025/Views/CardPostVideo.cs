﻿using System;
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

namespace Acelera2025.Views
{
    public partial class CardPostVideo : UserControl
    {
        private PessoaModels usuario;
        private PostModels postagem;
        private bool videoEmTelaCheia = false;


        public CardPostVideo(PostModels postagem, PessoaModels usuario)
        {
            InitializeComponent();
            this.postagem = postagem;
            this.usuario = usuario;
            lblNome.Text = postagem.Usuario.Nome;
            lblTexto.Text = postagem.Texto;
            lblData.Text = postagem.Data.ToString("dd/MM/yyyy HH:mm");
            video.settings.volume = 0;



            if (!string.IsNullOrEmpty(postagem.Video))
            {
                video.URL = postagem.Video;
                video.settings.volume = 0; 
                video.Visible = true;

           
            }



            if (!string.IsNullOrEmpty(postagem.Video))
            {
                video.URL = postagem.Video;
            }
            video.Ctlcontrols.pause();
            this.postagem = postagem;

            if (!string.IsNullOrEmpty(postagem.Usuario.CaminhoFoto) && File.Exists(postagem.Usuario.CaminhoFoto))
            {
                picFotoPerfil.Image = Image.FromFile(postagem.Usuario.CaminhoFoto);
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
            bool curtido = postagem.Curtidas.Any(c => c.Usuario == usuario.Nome);
            btnCurtir.ForeColor = curtido ? Color.Red : Color.Gray;

            btnCurtir.Click += (s, e) =>
            {
                CurtirPostagem();
            };
        }
        private void CurtirPostagem()
        {
            var curtidaExistente = postagem.Curtidas.FirstOrDefault(c => c.Usuario == usuario.Nome);

            if (curtidaExistente != null)
            {
                postagem.Curtidas.Remove(curtidaExistente);
                btnCurtir.ForeColor = Color.Gray;
            }
            else
            {
                postagem.Curtidas.Add(new CurtidasModels(usuario.Nome));

                btnCurtir.ForeColor = Color.Red;
            }
            AtualizarContadorCurtidas();
        }
        private void CardPostVideo_Load(object sender, EventArgs e)
        {
        }
        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
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
                controller.AdicionarComentario(postagem, usuario, textoComentario);
                txtComentarios.Clear();
                AtualizarComentarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void video_Enter(object sender, EventArgs e)
        {

        }

        private void btnExpandirVideo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(postagem.Video) && File.Exists(postagem.Video))
            {
                var telaCheia = new VideoTelaCheia(postagem.Video);
                telaCheia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vídeo não encontrado.");
            }
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
