using System;
using System.Collections.Generic;
public class ComentariosModels
    {
    public string Usuario { get; set; }
    public string Texto { get; set; }
    public DateTime Data { get; set; }
    
    public List<CurtidasModels> Curtidas { get; set; } = new List<CurtidasModels>();

    public ComentariosModels(string usuario, string texto)
    {
        Usuario = usuario;
        Texto = texto;
        Data = DateTime.Now;
    }
}
