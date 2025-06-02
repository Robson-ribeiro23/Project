using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera2025.Class;

namespace Acelera2025.Telas
{
    public partial class CardPerfil: UserControl
    {
        public event EventHandler FecharTelaSolicitado;

        private string TipoUsuario;
        public CardPerfil(string tipoUsuario)
        {

            InitializeComponent();
            TipoUsuario = tipoUsuario;
        }

        private void CardPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TipoUsuario == "empresa")
            {
                PerfilEmpresa perfil = new PerfilEmpresa();
                perfil.Show();

                FecharTelaSolicitado?.Invoke(this, EventArgs.Empty);

            }
            else if(TipoUsuario == "usuario")
            {
                Perfil perfil = new Perfil();
                perfil.Show();

                FecharTelaSolicitado?.Invoke(this, EventArgs.Empty);
            }

        }

        private void btnSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PeopleManager manager = PeopleManager.GetInstance();
            manager.Logout();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                PrincipalInicial principal = new PrincipalInicial();
                principal.Show();
                parentForm.Close();
            }
        }

        private void picPerfil_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
