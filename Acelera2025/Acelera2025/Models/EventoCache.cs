using System.Collections.Generic;
using System.Linq;

public static class EventoCache
{
    private static List<EventoModels> eventos = new List<EventoModels>();

    public static void Adicionar(EventoModels evento)
    {
        eventos.Add(evento);
    }

    public static EventoModels ObterUltimoEvento()
    {
        return eventos.LastOrDefault();
    }

    public static List<EventoModels> ListarTodos()
    {
        return eventos;
    }

    public static void Limpar()
    {
        eventos.Clear();
    }
}
