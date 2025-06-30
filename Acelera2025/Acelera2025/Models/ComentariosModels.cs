using System;
using System.Collections.Generic;

public class ComentariosModels
{
    public string EmailUsuario { get; set; }  // Identificador único (email)
    public string Texto { get; set; }
    public DateTime Data { get; set; }

    public ComentariosModels(string emailUsuario, string texto)
    {
        EmailUsuario = emailUsuario;
        Texto = texto;
        Data = DateTime.Now;
    }
}