using System;

    public class CurtidasModels
    {
    public string Usuario { get; set; }
    public DateTime Data { get; set; }

    public CurtidasModels(string usuario)
    {
        Usuario = usuario;
        Data = DateTime.Now;
    }
}

