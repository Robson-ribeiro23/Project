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
        public CardPerfil()
        {
            InitializeComponent();
        }

        private void CardPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();

            FecharTelaSolicitado?.Invoke(this, EventArgs.Empty);
        }

        private void btnSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PeopleManager manager = PeopleManager.GetInstance();
            manager.Logout();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                EntrarUsuario loginForm = new EntrarUsuario();
                loginForm.Show();
                parentForm.Close();
            }
        }
    }
}
