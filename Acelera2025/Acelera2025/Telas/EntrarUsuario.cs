using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera2025.Class;

namespace Acelera2025.Telas
{
    public partial class EntrarUsuario: Form
    {
        public EntrarUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Logar logar = new Logar();
            logar.Show();
        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
            cadastrarUsuario.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtSenha.Text;

            if (PeopleManager.GetInstance().SearchByEmailAndPassword(email, password) != null)
            {
                this.Close();
                Principal principal = new Principal();
                principal.Show();
                MessageBox.Show("Logado com sucesso!");
            } else
            {
                this.Close();
                CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
                cadastrarUsuario.Show();
                MessageBox.Show("Usuário não cadastrado!");
            }

        }
    }
}
