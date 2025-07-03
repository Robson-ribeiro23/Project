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
using Acelera2025.Controllers;

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
            var email = UsuarioControllers.loggedUser != null ? UsuarioControllers.loggedUser.Email : EmpresaControllers.loggedCompany.Email;
            List<NotificacaoModels> notificacoes = NotificacaoCache.ObterNotificacoes(email);

            panelNotificacao.Controls.Clear();
            foreach (var notificacao in notificacoes)
            {
                CreateNotCard(notificacao);
            }
        }

        private void CreateNotCard(NotificacaoModels notificacao)
        {
            PessoaModels user= null;
            if (UsuarioControllers.HasUserByEmail(notificacao.EmailDeQuemSeguiu))
            { 
                user = UsuarioControllers.ListarTodos().Where(u => u.Email == notificacao.EmailDeQuemSeguiu).ToList()[0]; 
            }

            if (EmpresaControllers.HasCompanyByEmail(notificacao.EmailDeQuemSeguiu))
            {
                user = EmpresaControllers.ListarTodos().Where(u => u.Email == notificacao.EmailDeQuemSeguiu).ToList()[0];
            }

            if (user == null) { return; }

            CardNotificacao card = new CardNotificacao(user, notificacao.TipoDeNot, notificacao.Contexto);
            panelNotificacao.Controls.Add(card);
        }
    }
}
