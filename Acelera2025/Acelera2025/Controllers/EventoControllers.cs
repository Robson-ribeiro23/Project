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
        //MessageBox.Show("Evento criado com sucesso!");
        return true;
    }

    public List<EventoModels> ListarTodos()
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
        var evento = BuscarPorNome(nome);
        if (evento != null)
        {
            listaEventos.Remove(evento);
            MessageBox.Show("Evento removido com sucesso!");
            return true;
        }

        MessageBox.Show("Evento não encontrado.");
        return false;
    }
}