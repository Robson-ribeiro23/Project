using System;
using System.Collections.Generic;
public class ComentariosModels
    {
    public string Usuario { get; set; }
    public string Texto { get; set; }
    public DateTime Data { get; set; }
    

    public ComentariosModels(string usuario, string texto)
    {
        Usuario = usuario;
        Texto = texto;
        Data = DateTime.Now;
    }
}
