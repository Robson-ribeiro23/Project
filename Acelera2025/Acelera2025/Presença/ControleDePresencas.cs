using System.Collections.Generic;

namespace Acelera2025.Utils
{
    public static class ControleDePresencas
    {
        private static readonly HashSet<string> codigosValidos = new HashSet<string>();
        private static readonly HashSet<string> codigosUsados = new HashSet<string>();

        public static void RegistrarCodigo(string codigo)
        {
            codigosValidos.Add(codigo);
        }

        public static bool ValidarCodigo(string codigo)
        {
            if (codigosValidos.Contains(codigo) && !codigosUsados.Contains(codigo))
            {
                codigosUsados.Add(codigo);
                return true;
            }

            return false;
        }
    }
}