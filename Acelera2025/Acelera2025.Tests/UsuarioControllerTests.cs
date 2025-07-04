using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera2025.Models;

namespace Acelera2025.Tests
{
    internal class UsuarioControllerTests
    {
    }
}

public class UsuarioControllersTests
{
    
    public void Cadastrar_DeveRetornarFalse_QuandoCamposObrigatoriosNaoPreenchidos()
    {
        var controller = new UsuarioControllers();
        var usuario = new UsuarioModels(); // vazio

        var resultado = controller.Cadastrar(usuario);

        Assert.IsFalse(resultado);
    }

    
    public void Cadastrar_DeveRetornarFalse_QuandoEmailInvalido()
    {
        var controller = new UsuarioControllers();
        var usuario = new UsuarioModels
        {
            Nome = "João",
            Tipo = "Cliente",
            Email = "emailinvalido",
            Cidade = "SP",
            Telefone = "12345678",
            CPF = "11122233344",
            DataNascimento = "01/01/2000",
            Senha = "123",
            ConfirmarSenha = "123"
        };

        var resultado = controller.Cadastrar(usuario);

        Assert.IsFalse(resultado);
    }

    
    public void Cadastrar_DeveRetornarTrue_QuandoUsuarioValido()
    {
        var controller = new UsuarioControllers();
        var usuario = new UsuarioModels
        {
            Nome = "Maria",
            Tipo = "Cliente",
            Email = "maria@email.com",
            Cidade = "RJ",
            Telefone = "12345678",
            CPF = "12345678900",
            DataNascimento = "02/02/1990",
            Senha = "abc",
            ConfirmarSenha = "abc"
        };

        var resultado = controller.Cadastrar(usuario);

        Assert.IsTrue(resultado);
    }

    
    public void Login_DeveRetornarUsuario_QuandoCredenciaisForemValidas()
    {
        var controller = new UsuarioControllers();
        var usuario = new UsuarioModels
        {
            Nome = "Carlos",
            Tipo = "Cliente",
            Email = "carlos@email.com",
            Cidade = "BA",
            Telefone = "999999999",
            CPF = "55566677788",
            DataNascimento = "03/03/1995",
            Senha = "senha123",
            ConfirmarSenha = "senha123"
        };

        controller.Cadastrar(usuario);
        var logado = controller.Login("carlos@email.com", "senha123");

        Assert.IsNotNull(logado);
        Assert.AreEqual("Carlos", logado.Nome);
    }
}
