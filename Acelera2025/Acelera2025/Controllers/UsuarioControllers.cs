﻿using Acelera2025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class UsuarioControllers
{
    private static List<UsuarioModels> listaUsuarios = new List<UsuarioModels>();
    public static UsuarioModels loggedUser;

    private bool EmailValido(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    public bool Cadastrar(UsuarioModels usuario)
    {
        if (string.IsNullOrWhiteSpace(usuario.Nome) ||
            string.IsNullOrWhiteSpace(usuario.Email) ||
            string.IsNullOrWhiteSpace(usuario.Cidade) ||
            string.IsNullOrWhiteSpace(usuario.CPF) ||
            string.IsNullOrWhiteSpace(usuario.DataNascimento) ||
            string.IsNullOrWhiteSpace(usuario.Senha) ||
            string.IsNullOrWhiteSpace(usuario.ConfirmarSenha))
        {
            MessageBox.Show("Preencha todos os campos obrigatórios.");
            return false;
        }

        if (listaUsuarios.Any(u => u.CPF == usuario.CPF))
        {
            MessageBox.Show("Já existe um usuário com este CPF.");
            return false;
        }

        if (!EmailValido(usuario.Email))
        {
            MessageBox.Show("E-mail em formato inválido.");
            return false;
        }

        if (listaUsuarios.Any(u => u.Email == usuario.Email))
        {
            MessageBox.Show("Já existe um usuário com este Email.");
            return false;
        }

        if (usuario.Senha != usuario.ConfirmarSenha)
        {
            MessageBox.Show("As senhas não coincidem.");
            return false;
        }

        usuario.Tipo = "Usuario";
        listaUsuarios.Add(usuario);
        MessageBox.Show("Usuário cadastrado com sucesso!");
        return true;
    }

    public static List <UsuarioModels> ListarTodos()
    {
        return listaUsuarios;
    }

    public static bool HasUserByEmail(string email)
    {
        return listaUsuarios.Any(u => u.Email == email);
    }

    public UsuarioModels Login(string email, string senha)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
        {
            MessageBox.Show("Preencha o e-mail e a senha.");
            return null;
        }

        if (!EmailValido(email))
        {
            MessageBox.Show("E-mail em formato inválido.");
            return null;
        }

        var usuario = listaUsuarios.FirstOrDefault(u =>
            u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
            u.Senha == senha
        );

        if (usuario == null)
        {
            MessageBox.Show("E-mail ou senha inválidos.");
            return null;
        }

        loggedUser = usuario;
        return usuario;
    }

    public bool AtualizarSenha(string email, string novaSenha)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(novaSenha))
        {
            MessageBox.Show("Preencha todos os campos obrigatórios.");
            return false;
        }

        if (!EmailValido(email))
        {
            MessageBox.Show("E-mail em formato inválido.");
            return false;
        }

        var usuario = listaUsuarios.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        if (usuario == null)
        {
            MessageBox.Show("Usuário não encontrado.");
            return false;
        }
        usuario.Senha = novaSenha;
        MessageBox.Show("Senha atualizada com sucesso!");
        return true;
    }
}