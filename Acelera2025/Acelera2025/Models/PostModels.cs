using Acelera2025.Models;
using System;
using System.Collections.Generic;

public class PostModels
    {
    public PessoaModels Usuario { get; set; }
    public string Texto { get; set; }
    public DateTime Data { get; set; }
    public List<string> Imagens { get; set; }
    public string Video { get; set; }
    public List<CurtidasModels> Curtidas { get; set; } = new List<CurtidasModels>();
    public List<ComentariosModels> Comentarios { get; set; } = new List<ComentariosModels>();

    public PostModels(PessoaModels usuario, string texto, List<string> imagens, string video)
    {
        Usuario = usuario;
        Texto = texto;
        Imagens = imagens;
        Video = video;
        Data = DateTime.Now;
    }
}

