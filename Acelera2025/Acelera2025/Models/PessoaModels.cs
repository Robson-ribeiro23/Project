using Acelera2025.Models;
using System.Collections.Generic;
using System.Linq;



public abstract class PessoaModels
{
    public string Tipo { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cidade { get; set; }
    public string Telefone { get; set; }
    public string Senha { get; set; }
    public string ConfirmarSenha { get; set; }
    public string CaminhoFoto { get; set; }
    public List<PostModels> Postagens { get; set; } = new List<PostModels>();

    protected List<EventoModels> EventosIncritos = new List<EventoModels>();
    public List<PessoaModels> Seguindo { get; set; } = new List<PessoaModels>();
    public List<PessoaModels> Seguidores { get; set; } = new List<PessoaModels>();

    public bool EstaSeguindo(PessoaModels outro)
    {
        return Seguindo.Any(u => u.Email == outro.Email);
    }

    public bool SeguirOuDeixarDeSeguir(PessoaModels outro)
    {
        if (EstaSeguindo(outro))
        {
            Seguindo.RemoveAll(u => u.Email == outro.Email);
            outro.Seguidores.RemoveAll(u => u.Email == this.Email);
            return false;
        }
        else
        {
            Seguindo.Add(outro);
            outro.Seguidores.Add(this);
            return true;
        }
    }

    public List<EventoModels> GetSubbedEvents()
    {
        return EventosIncritos;
    }

    public List<EventoModels> GetOwnedEvents()
    {
        List<EventoModels> allEvents = EventoControllers.ListarTodos();
        List<EventoModels> filteredEvents = allEvents.Where(e => e.criador.Email.Equals(Email)).ToList();
        return filteredEvents;
    }

    public void SubscribeToEvent(EventoModels evento) 
    {
        if (evento == null || EventosIncritos.Contains(evento)) { return; }
        EventosIncritos.Add(evento);
    }

    public void UnsubscribeToEvent(EventoModels evento)
    {
        if (evento != null || !EventosIncritos.Contains(evento)) { return; }
        EventosIncritos.Add(evento);
    }
}
