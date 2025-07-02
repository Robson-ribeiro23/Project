using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Models
{
    public class NotificacaoModels
    {
        public string EmailDeQuemSeguiu { get; set; }
        public string TipoDeNot {  get; set; }
        public Dictionary<string, object> Contexto { get; set; }
        public DateTime Data { get; set; }

        public NotificacaoModels(string email, string tipoDeNot, Dictionary<string, object> contexto = null)
        {
            EmailDeQuemSeguiu = email;
            Data = DateTime.Now;
            TipoDeNot = tipoDeNot;
            Contexto = contexto ?? new Dictionary<string, object>();
        }
    }
}
