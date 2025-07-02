using System;
using System.Collections.Generic;

namespace Acelera2025.Utils
{
    public class DadosCodigo
    {
        public int ResgatesRestantes { get; set; }
        public DateTime ValidoAte { get; set; }
    }

    public static class ControleDePresencas
    {
        private static readonly Dictionary<string, DadosCodigo> codigosAtivos = new Dictionary<string, DadosCodigo>();


        public static void RegistrarCodigo(string codigo, int resgatesPermitidos, DateTime validoAte)
        {
            codigosAtivos[codigo] = new DadosCodigo
            {
                ResgatesRestantes = resgatesPermitidos,
                ValidoAte = validoAte
            };
        }

        public static bool ValidarCodigo(string codigo)
        {
            if (codigosAtivos.TryGetValue(codigo, out DadosCodigo dados))
            {
                if (DateTime.Now <= dados.ValidoAte && dados.ResgatesRestantes > 0)
                {
                    dados.ResgatesRestantes--;
                    return true;
                }
            }
            return false;
        }

        public static int ConsultarResgatesRestantes(string codigo)
        {
            return codigosAtivos.TryGetValue(codigo, out DadosCodigo dados)
                ? dados.ResgatesRestantes
                : 0;
        }
    }
}