using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ac;
using Acelera2025.Controllers;
using Acelera2025.Models;

namespace Acelera2025.Telas
{
    public partial class CardNotificacao: UserControl
    {
        private PessoaModels usuario, loggedUser;
        private string type;
        public Dictionary<string, object> contexto;


        public CardNotificacao(PessoaModels usuario, string type, Dictionary<string, object> context) 
        {
            InitializeComponent();
            this.loggedUser = UsuarioControllers.loggedUser != null ? (PessoaModels)UsuarioControllers.loggedUser : (PessoaModels)EmpresaControllers.loggedCompany;
            this.usuario = usuario;
            this.type = type;
            this.contexto = context;
        }

        private void CardNotificacao_Load(object sender, EventArgs e)
        {
            PessoaModels u = (PessoaModels)contexto["perfil"];


            switch (type)
            {
                case "onBeFollowed":
                    lblTitulo.Text = u.Nome + " passou a seguir você!";
                    break;
                case "onAccountPosted":
                    lblTitulo.Text = u.Nome + " lançou uma postagem!";
                    break;
                case "onAccountEvent":
                    lblTitulo.Text = u.Nome + " criou um novo evento!";
                    break;
                case "onEventFollowed":
                    lblTitulo.Text = u.Nome + " se inscreveu no seu evento!";
                    break;
            }
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerNotificacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (type)
            {
                case "onBeFollowed":
                    Navegador.IrParaPerfilUsuario((UsuarioModels)contexto["perfil"]);
                    break;
                case "onAccountPosted":
                    Navegador.IrParaPerfilUsuario((UsuarioModels)contexto["perfil"]);
                    break;
                case "onAccountEvent":
                    Navegador.IrParaTelaEventos(loggedUser, (EventoModels)contexto["evento"]);
                    break;
                case "onEventFollowed":
                    Navegador.IrParaTelaEventos(loggedUser, (EventoModels)contexto["evento"]);
                    break;
            }
        }
    }
}
