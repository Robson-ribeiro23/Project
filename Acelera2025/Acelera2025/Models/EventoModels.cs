using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

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
    public string CaminhoImagem { get; set; } 
    public string UsuarioEmail { get; set; }
    public string NomeLocal { get; set; }
    public string Rua { get; set; }
    public string NumeroEndereco { get; set; }
    public string Bairro { get; set; }
    public string CEP { get; set; }
    public string Cidade { get; set; }

    public EventoModels() { }

    public EventoModels(
    string nomeEvento, DateTime data, string categoria, string horario, bool isPresencial,
    int limiteParticipantes, string faixaEtaria, string descricao, bool permitePatrocinio,
    string caminhoImagem, string email,
    string nomeLocal, string rua, string numeroEndereco, string bairro, string cep, string cidade)
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
        CaminhoImagem = caminhoImagem;
        UsuarioEmail = email;

        NomeLocal = nomeLocal;
        Rua = rua;
        NumeroEndereco = numeroEndereco;
        Bairro = bairro;
        CEP = cep;
        Cidade = cidade;

    }

    public static class EventoCache
    {
        public static List<EventoModels> EventosCriados { get; private set; } = new List<EventoModels>();

        public static void Adicionar(EventoModels evento)
        {
            EventosCriados.Add(evento);
        }
    }

    public override string ToString()
    {
        return $"Evento: {NomeEvento}, Data: {Data.ToShortDateString()}, Horário: {Horario}, Categoria: {Categoria}, " +
               $"Tipo: {(IsPresencial ? "Presencial" : "Online")}, Limite: {LimiteParticipantes}, " +
               $"Faixa Etária: {FaixaEtaria}, Patrocínio: {(PermitePatrocinio ? "Sim" : "Não")}\nDescrição: {Descricao}";
    }
}