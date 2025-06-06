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
using Ac;

namespace Acelera2025.Views
{
    public partial class CardPerfil: UserControl
    {
        public event EventHandler FecharTelaSolicitado;

        private PessoaModels TipoUsuario;
        public CardPerfil(PessoaModels usuario)
        {

            InitializeComponent();
            TipoUsuario = usuario;
            
        }

        private void CardPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TipoUsuario.Tipo == "empresa")
            {
                Navegador.IrParaPerfilEmpresa(TipoUsuario);
            }
            else if(TipoUsuario.Tipo == "usuario")
            {
                Navegador.IrParaPerfilUsuario(TipoUsuario);

            }

        }

        private void btnSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PeopleManager manager = PeopleManager.GetInstance();
            manager.Logout();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                //PrincipalInicial principal = new PrincipalInicial();
                //principal.Show();
                //parentForm.Close();
            }
        }

        private void picPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
