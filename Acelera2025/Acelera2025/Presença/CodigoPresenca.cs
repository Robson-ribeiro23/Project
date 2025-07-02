using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Presença
{
    public class CodigoPresenca
    {
        public string Codigo { get; set; }
        public DateTime ValidoAte { get; set; }
        public bool JaUsado { get; set; }

        public CodigoPresenca(string codigo, TimeSpan duracao)
        {
            Codigo = codigo;
            ValidoAte = DateTime.Now.Add(duracao);
            JaUsado = false;
        }

        public bool EstaValido()
        {
            return !JaUsado && DateTime.Now <= ValidoAte;
        }
    }
}
