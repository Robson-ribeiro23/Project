using System;
using System.Security.Cryptography;
using System.Text;

namespace Acelera2025.Utils
{
    public static class GeradorDeCodigos
    {
        public static string Gerar(int tamanho = 8)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var bytes = new byte[tamanho];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            var resultado = new StringBuilder(tamanho);
            foreach (var b in bytes)
            {
                resultado.Append(caracteres[b % caracteres.Length]);
            }

            return resultado.ToString();
        }
    }
}