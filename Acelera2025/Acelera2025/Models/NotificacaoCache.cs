using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Models
{
    public static class NotificacaoCache
    {
        private static Dictionary<string, List<NotificacaoModels>> notificacoes = new Dictionary<string, List<NotificacaoModels>>();

        public static void AdicionarNotificacao(string emailDestino, NotificacaoModels notificacao)
        {
            if (!notificacoes.ContainsKey(emailDestino))
                notificacoes[emailDestino] = new List<NotificacaoModels>();

            notificacoes[emailDestino].Add(notificacao);
        }

        public static List<NotificacaoModels> ObterNotificacoes(string emailDestino)
        {
            if (!notificacoes.ContainsKey(emailDestino))
                return new List<NotificacaoModels>();

            return notificacoes[emailDestino];
        }
    }
}
