using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera2025.Models;

namespace Acelera2025.Telas
{
    public partial class CardPainelDeNotificacoes: UserControl
    {
        public CardPainelDeNotificacoes()
        {
            InitializeComponent();
        }

        private void CardPainelDeNotificacoes_Load(object sender, EventArgs e)
        {
            List<NotificacaoModels> notificacoes = NotificacaoCache.ObterNotificacoes(UsuarioControllers.loggedUser.Email);

            panelNotificacao.Controls.Clear();
            foreach (var notificacao in notificacoes)
            {
                CreateNotCard(notificacao);
            }
        }

        private void CreateNotCard(NotificacaoModels notificacao)
        {
            UsuarioModels user = UsuarioControllers.ListarTodos().Where(u => u.Email == notificacao.EmailDeQuemSeguiu).ToList()[0];
            CardNotificacao card = new CardNotificacao(user, notificacao.TipoDeNot, notificacao.Contexto);
            panelNotificacao.Controls.Add(card);
        }
    }
}
