using Acelera2025.Model;
using Acelera2025.Service;
using System.Collections.Generic;
using System;

namespace MeuSistema.Controller
{
    public class UsuarioController
    {
        private UsuarioService usuarioService = new UsuarioService();

        public UsuarioModel CadastrarUsuario(string nome, string email, DateTime dataNascimento, string senha)
        {
            UsuarioModel novoUsuario = new UsuarioModel
            {
                Nome = nome,
                Email = email,
                DataNascimento = dataNascimento,
                Senha = senha
            };

            return usuarioService.Cadastrar(novoUsuario);
        }

        public UsuarioModel LoginUsuario(string email, string senha)
        {
            return usuarioService.Login(email, senha);
        }

        public List<UsuarioModel> ListarUsuarios()
        {
            return usuarioService.Listar();
        }
    }
}
