using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acelera2025.Controllers;

namespace Acelera2025.Tests
{
    internal class EmpresaControllerTests
    {
    }
}

public class EmpresaControllersTests
{
    
    public void Cadastrar_DeveRetornarFalse_QuandoCamposObrigatoriosNaoPreenchidos()
    {
        var controller = new EmpresaControllers();
        var empresa = new EmpresaModels(); // vazio

        var resultado = controller.Cadastrar(empresa);

        Assert.IsFalse(resultado);
    }

    
    public void Cadastrar_DeveRetornarFalse_QuandoEmailInvalido()
    {
        var controller = new EmpresaControllers();
        var empresa = new EmpresaModels
        {
            Nome = "Empresa Teste",
            Tipo = "Fornecedor",
            Email = "emailinvalido",
            Cidade = "SP",
            Telefone = "12345678",
            CNPJ = "00011122233344",
            Senha = "empresa",
            ConfirmarSenha = "empresa"
        };

        var resultado = controller.Cadastrar(empresa);

        Assert.IsFalse(resultado);
    }

    
    public void Cadastrar_DeveRetornarTrue_QuandoEmpresaValida()
    {
        var controller = new EmpresaControllers();
        var empresa = new EmpresaModels
        {
            Nome = "Minha Empresa",
            Tipo = "Fornecedor",
            Email = "empresa@teste.com",
            Cidade = "MG",
            Telefone = "11223344",
            CNPJ = "00998877665544",
            Senha = "senhaemp",
            ConfirmarSenha = "senhaemp"
        };

        var resultado = controller.Cadastrar(empresa);

        Assert.IsTrue(resultado);
    }

    
    public void Login_DeveRetornarEmpresa_QuandoCredenciaisForemValidas()
    {
        var controller = new EmpresaControllers();
        var empresa = new EmpresaModels
        {
            Nome = "Tech Ltda",
            Tipo = "TI",
            Email = "tech@empresa.com",
            Cidade = "SC",
            Telefone = "45678912",
            CNPJ = "12345678000199",
            Senha = "segura123",
            ConfirmarSenha = "segura123"
        };

        controller.Cadastrar(empresa);
        var resultado = controller.Login("12345678000199", "tech@empresa.com", "segura123");

        Assert.IsNotNull(resultado);
        Assert.AreEqual("12345678900019", resultado.CNPJ);
        Assert.AreEqual("tech@empresa.com", resultado.Email);
    }
}
