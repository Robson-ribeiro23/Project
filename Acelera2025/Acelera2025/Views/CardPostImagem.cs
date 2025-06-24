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
    public partial class CardPostImagem: UserControl
    {
        private PostModels postagem;
        public CardPostImagem(PostModels postagem)
        {
            InitializeComponent();
            this.postagem = postagem;
            lblNome.Text = postagem.Usuario.Nome;
            lblTexto.Text = postagem.Texto;
            lblData.Text = postagem.Data.ToString("dd/MM/yyyy HH:mm");
            if (postagem.Imagens != null && postagem.Imagens.Count > 0)
            {
                picPost1.Image = Image.FromFile(postagem.Imagens[0]);
            }
            if (postagem.Imagens != null && postagem.Imagens.Count > 0)
            {
                picPost2.Image = Image.FromFile(postagem.Imagens[1]);
            }

            ConfigurarBotaoCurtir();
            AtualizarContadorCurtidas();
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
            var curtidaExistente = postagem.Curtidas.FirstOrDefault(c => c.Usuario == postagem.Usuario.Nome);

            if (curtidaExistente != null)
            {
                postagem.Curtidas.Remove(curtidaExistente);
                btnCurtir.ForeColor = Color.Gray;
            }
            else
            {
                postagem.Curtidas.Add(new CurtidasModels(postagem.Usuario.Nome));

                btnCurtir.ForeColor = Color.Red;
            }
            AtualizarContadorCurtidas();
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
    }
}
