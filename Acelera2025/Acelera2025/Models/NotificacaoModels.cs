using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Models
{
    public class NotificacaoModels
    {
        public string NomeDeQuemSeguiu { get; set; }
        public string EmailDeQuemSeguiu { get; set; }
        public DateTime Data { get; set; }

        public NotificacaoModels(string nome, string email)
        {
            NomeDeQuemSeguiu = nome;
            EmailDeQuemSeguiu = email;
            Data = DateTime.Now;
        }
    }
}
