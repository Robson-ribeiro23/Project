using Acelera2025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class EventoControllers
{
    private static List<EventoModels> listaEventos = new List<EventoModels>();

    public bool CriarEvento(EventoModels evento)
    {
        // Validação de campos obrigatórios
        if (string.IsNullOrWhiteSpace(evento.NomeEvento) ||
            string.IsNullOrWhiteSpace(evento.Horario) ||
            string.IsNullOrWhiteSpace(evento.Categoria) ||
            string.IsNullOrWhiteSpace(evento.FaixaEtaria) ||
            string.IsNullOrWhiteSpace(evento.Descricao))
        {
            MessageBox.Show("Preencha todos os campos obrigatórios.");
            return false;
        }

        if (evento.Data < DateTime.Today)
        {
            MessageBox.Show("A data do evento não pode ser anterior à data atual.");
            return false;
        }

        if (evento.LimiteParticipantes <= 0)
        {
            MessageBox.Show("O limite de participantes deve ser maior que zero.");
            return false;
        }

        // Adiciona à lista
        listaEventos.Add(evento);
        MessageBox.Show("Evento criado com sucesso!");
        return true;
    }

    public static List<EventoModels> ListarTodos()
    {
        return listaEventos;
    }

    public EventoModels BuscarPorNome(string nome)
    {
        return listaEventos.FirstOrDefault(e =>
            e.NomeEvento.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }

    public bool RemoverEvento(string nome)
    {
        var evento = listaEventos.FirstOrDefault(e => e.NomeEvento == nome);
        if (evento != null)
        {
            // Remove o evento da lista de inscritos de cada usuário
            var inscritos = evento.GetUserList();
            foreach (var usuario in inscritos)
            {
                usuario.UnsubscribeToEvent(evento);
            }

            // Remove o evento da lista de eventos criados do criador
            evento.criador?.GetOwnedEvents()?.Remove(evento);

            // Remove o evento da lista global de eventos
            listaEventos.Remove(evento);

            // Remove o evento de todas as listas estáticas globais, se existirem
            if (EventoModels.EventoCache.EventosCriados != null)
            {
                EventoModels.EventoCache.EventosCriados.Remove(evento);
            }


            return true;
        }
        return false;
    }

    public bool EditarEvento(
        string nomeEvento,
        DateTime data,
        string horario,
        string linkReuniao,
        int limiteParticipantes,
        string descricao,
        string local,
        string rua,
        string numero,
        string cep,
        string bairro,
        string caminhoImagem)
    {
        EventoModels evento = BuscarPorNome(nomeEvento);
        if (evento == null)
            return false;

        evento.Data = data;
        evento.Horario = horario;
        evento.LinkReuniao = linkReuniao;
        evento.LimiteParticipantes = limiteParticipantes;
        evento.Descricao = descricao;
        evento.Local = local;
        evento.Rua = rua;
        evento.Numero = numero;
        evento.CEP = cep;
        evento.Bairro = bairro;
        evento.CaminhoImagem = caminhoImagem;

        return true;
    }
}