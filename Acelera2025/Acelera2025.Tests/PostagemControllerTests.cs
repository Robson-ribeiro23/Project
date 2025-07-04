using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera2025.Controllers;
using Acelera2025.Models;

namespace Acelera2025.Tests
{
    public class PostagemControllerTests
    {
        
        public void CriarPost_DeveCriarNovaPostagem_QuandoDadosForemValidos()
        {
           
            var controller = new PostagemControllers();
            var usuario = new UsuarioModels { Nome = "Bruno" };

            var texto = "Essa é uma nova postagem.";
            var imagens = new List<string>();
            var video = "video1.mp4";

            var resultado = controller.CriarPost(usuario, texto, imagens, video);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(usuario, resultado.Usuario);
            Assert.AreEqual(texto, resultado.Texto);
            Assert.AreEqual(0, resultado.Imagens.Count);
            Assert.AreEqual(video, resultado.Video);
            Assert.IsTrue(resultado.Data <= DateTime.Now);

        }


        public void CriarPost_DeveRetornarNull_QuandoUsuarioForNull()
        {
            
            var controller = new PostagemControllers();
            PessoaModels usuario = null;
            var texto = "Postagem inválida";

            var resultado = controller.CriarPost(usuario, texto);

            Assert.Null(resultado);
        }

        
        public void CriarPost_DeveRetornarNull_QuandoTextoEstiverVazio()
        {
            var controller = new PostagemControllers();
            var usuario = new UsuarioModels { Nome = "Bruno" };
            var texto = " ";

            var resultado = controller.CriarPost(usuario, texto);

            Assert.Null(resultado);
        }

        
        public void CriarPost_DeveRetornarNull_QuandoNaoHouverMidia()
        {
            var controller = new PostagemControllers();
            var usuario = new UsuarioModels { Nome = "Bruno" };
            var texto = "Postagem sem mídia.";

            var resultado = controller.CriarPost(usuario, texto, new List<string>(), null);

            Assert.Null(resultado);
        }

        
        public void CriarPost_DeveRetornarNull_QuandoMaisDe2ImagensForemEnviadas()
        {
            var controller = new PostagemControllers();
            var usuario = new UsuarioModels { Nome = "Bruno" };
            var texto = "Tentando enviar muitas imagens.";
            var imagens = new List<string> { "img1.png", "img2.png", "img3.png" };

            var resultado = controller.CriarPost(usuario, texto, imagens);

            Assert.Null(resultado);
        }
    }
}
