using System.Collections.Generic;

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

    public List<EventoModels> GetSubbedEvents()
    {
        return EventosIncritos;
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
