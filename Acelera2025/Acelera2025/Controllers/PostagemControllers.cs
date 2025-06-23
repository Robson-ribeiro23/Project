using Acelera2025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Controllers
{
    public class PostagemControllers
    {
        private static List<PostModels> listaPostagens = new List<PostModels>();

        public PostModels CriarPost(PessoaModels usuario, string texto, List<string> imagens = null, string video = null)
        {
            if (usuario == null)
            {
                MessageBox.Show("Usuário não pode ser nulo.");
                return null;
            }
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("O texto da postagem não pode ser vazio.");
                return null;
            }
            if (string.IsNullOrWhiteSpace(texto) && (imagens == null || imagens.Count == 0) && video == null)
            {
                MessageBox.Show("A postagem deve conter texto, fotos ou vídeo.");
                return null;
            }
            if (imagens != null && imagens.Count > 2)
            {
                MessageBox.Show("Não é possível adicionar mais de 2 imagens.");
                return null;
            }

            var novaPostagem = new PostModels(usuario, texto, imagens, video);
            listaPostagens.Add(novaPostagem);
            usuario.Postagens.Add(novaPostagem);

            return novaPostagem;
        }

        public List<PostModels> ListarPostagens()
        {
            // Data mais recente primeiro
            return listaPostagens.OrderByDescending(p => p.Data).ToList();
        }
        public List<PostModels> ListarPostagensPorUsuario(PessoaModels usuario)
        {
            return listaPostagens.Where(p => p.Usuario == usuario)
                                .OrderByDescending(p => p.Data)
                                .ToList();
        }

        public ComentariosModels AdicionarComentario(PostModels postagem, PessoaModels usuario, string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("O comentário não pode estar vazio.");
                return null;
            }
            var novoComentario = new ComentariosModels(usuario.Nome, texto);
            postagem.Comentarios.Add(novoComentario);
            return novoComentario;
        }

        public CurtidasModels AdicionarCurtidaPostagem(PostModels postagem, PessoaModels usuario)
        {
            if (postagem.Curtidas.Any(c => c.Usuario == usuario.Nome))
            {
                MessageBox.Show("Você já curtiu esta postagem.");
                return null;
            }
            var novaCurtida = new CurtidasModels(usuario.Nome);
            postagem.Curtidas.Add(novaCurtida);
            return novaCurtida;
        }
        public CurtidasModels AdicionarCurtidaComentario(ComentariosModels comentario, PessoaModels usuario)
        {
            if (comentario.Curtidas.Any(c => c.Usuario == usuario.Nome))
            {
                MessageBox.Show("Você já curtiu este comentário.");
                return null;
            }
            var novaCurtida = new CurtidasModels(usuario.Nome);
            comentario.Curtidas.Add(novaCurtida);
            return novaCurtida;
        }

        public bool RemoverCurtidaPostagem(PostModels postagem, PessoaModels usuario)
        {
            var curtida = postagem.Curtidas.FirstOrDefault(c => c.Usuario == usuario.Nome);
            if (curtida != null)
            {
                postagem.Curtidas.Remove(curtida);
                return true;
            }
            return false;
        }
    }
}
