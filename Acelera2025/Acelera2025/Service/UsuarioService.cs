using Acelera2025.Model;
using System.Collections.Generic;

namespace Acelera2025.Service
{
    public class UsuarioService
    {
        private static List<UsuarioModel> usuarios = new List<UsuarioModel>();
        private static int proximoId = 1;

        public UsuarioModel Cadastrar(UsuarioModel usuario)
        {
            usuario.Id = proximoId++;
            usuarios.Add(usuario);
            return usuario;
        }
        public UsuarioModel Login(string email, string senha)
        {
            return usuarios.Find(u => u.Email == email && u.Senha == senha);
        }

        public List<UsuarioModel> Listar()
        {
            return usuarios;
        }
    }
}
