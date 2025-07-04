using System;
using Acelera2025.Models;
using Acelera2025.Controllers;
using NUnit.Framework;

namespace Acelera2025.Tests
{
    public class EventoControllersTests
    {
        [Test]
        public void CriarEvento_DeveRetornarFalse_QuandoCamposObrigatoriosNaoPreenchidos()
        {
            var controller = new EventoControllers();
            var evento = new EventoModels(); // Evento vazio

            var resultado = controller.CriarEvento(evento);

            Assert.IsFalse(resultado);
        }

        [Test]
        public void CriarEvento_DeveRetornarFalse_QuandoDataForAnteriorHoje()
        {
            var controller = new EventoControllers();
            var evento = new EventoModels
            {
                NomeEvento = "Evento Passado",
                Data = DateTime.Today.AddDays(-1),
                Categoria = "Cultura",
                Horario = "10:00",
                IsPresencial = true,
                LimiteParticipantes = 50,
                FaixaEtaria = "18",
                Descricao = "Descrição",
                PermitePatrocinio = true,
                CaminhoImagem = "img.jpg",
                UsuarioEmail = "email@email.com"
            };


            var resultado = controller.CriarEvento(evento);

            Assert.IsFalse(resultado);
        }

        [Test]
        public void CriarEvento_DeveRetornarFalse_QuandoLimiteParticipantesForZero()
        {
            var controller = new EventoControllers();
            var evento = new EventoModels
            {
                NomeEvento = "Evento Zero",
                Data = DateTime.Today.AddDays(1),
                Categoria = "Cultura",
                Horario = "10:00",
                IsPresencial = true,
                LimiteParticipantes = 0,
                FaixaEtaria = "18",
                Descricao = "Descrição",
                PermitePatrocinio = true,
                CaminhoImagem = "img.jpg",
                UsuarioEmail = "email@email.com"
            };


            var resultado = controller.CriarEvento(evento);

            Assert.IsFalse(resultado);
        }

        [Test]
        public void CriarEvento_DeveRetornarTrue_QuandoEventoForValido()
        {
            var controller = new EventoControllers();
            var evento = new EventoModels
            {
                NomeEvento = "Evento Teste",
                Data = DateTime.Today.AddDays(1),
                Categoria = "Tecnologia",
                Horario = "18:00",
                IsPresencial = true,
                LimiteParticipantes = 100,
                FaixaEtaria = "18",
                Descricao = "Descrição completa do evento.",
                PermitePatrocinio = true,
                CaminhoImagem = "imagem.jpg",
                UsuarioEmail = "organizador@email.com"
            };


            var resultado = controller.CriarEvento(evento);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void BuscarEvento_DeveRetornarEvento_QuandoNomeExistir()
        {
            var controller = new EventoControllers();
            var evento = new EventoModels
            {
                NomeEvento = "Busca Evento",
                Data = DateTime.Today.AddDays(1),
                Categoria = "Educação",
                Horario = "14:00",
                IsPresencial = true,
                LimiteParticipantes = 30,
                FaixaEtaria = "18",
                Descricao = "Descrição teste.",
                PermitePatrocinio = false,
                CaminhoImagem = "img2.jpg",
                UsuarioEmail = "user@email.com"
            };

            controller.CriarEvento(evento);
            var resultado = controller.BuscarPorNome("Busca Evento");

            Assert.IsNotNull(resultado);
            Assert.AreEqual("Busca Evento", resultado.NomeEvento);
        }


        [Test]
        public void RemoverEvento_DeveRetornarTrue_QuandoEventoExistir()
        {
            var controller = new EventoControllers();
            var evento = new EventoModels
            {
                NomeEvento = "Remover Evento",
                Data = DateTime.Today.AddDays(2),
                Categoria = "Negócios",
                Horario = "09:00",
                IsPresencial = false,
                LimiteParticipantes = 200,
                FaixaEtaria = "25",
                Descricao = "Evento de remoção.",
                PermitePatrocinio = true,
                CaminhoImagem = "img3.jpg",
                UsuarioEmail = "teste@email.com"
            };

            controller.CriarEvento(evento);
            var resultado = controller.RemoverEvento("Remover Evento");

            Assert.IsTrue(resultado);
        }


        [Test]
        public void RemoverEvento_DeveRetornarFalse_QuandoEventoNaoExistir()
        {
            var controller = new EventoControllers();

            var resultado = controller.RemoverEvento("Evento Inexistente");

            Assert.IsFalse(resultado);
        }
    }
}

