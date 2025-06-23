using System;

public class EventoModels
{
    public string NomeEvento { get; set; }
    public DateTime Data { get; set; }
    public string Categoria { get; set; }
    public string Horario { get; set; }
    public bool IsPresencial { get; set; }
    public int LimiteParticipantes { get; set; }
    public string FaixaEtaria { get; set; }
    public string Descricao { get; set; }
    public bool PermitePatrocinio { get; set; }

    public EventoModels() { }

    public EventoModels(string nomeEvento, DateTime data, string categoria, string horario, bool isPresencial,
                        int limiteParticipantes, string faixaEtaria, string descricao, bool permitePatrocinio)
    {
        NomeEvento = nomeEvento;
        Data = data;
        Categoria = categoria;
        Horario = horario;
        IsPresencial = isPresencial;
        LimiteParticipantes = limiteParticipantes;
        FaixaEtaria = faixaEtaria;
        Descricao = descricao;
        PermitePatrocinio = permitePatrocinio;
    }

    public override string ToString()
    {
        return $"Evento: {NomeEvento}, Data: {Data.ToShortDateString()}, Horário: {Horario}, Categoria: {Categoria}, " +
               $"Tipo: {(IsPresencial ? "Presencial" : "Online")}, Limite: {LimiteParticipantes}, " +
               $"Faixa Etária: {FaixaEtaria}, Patrocínio: {(PermitePatrocinio ? "Sim" : "Não")}\nDescrição: {Descricao}";
    }
}