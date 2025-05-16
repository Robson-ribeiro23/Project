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
    public partial class CadastrarUsuario: Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Logar logar = new Logar();
            logar.Show();
            this.Hide();
        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            EntrarUsuario entrarUsuario = new EntrarUsuario();
            entrarUsuario.Show();
            this.Hide();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;
            string password = txtSenha.Text;
            DateTime birthday = DateTime.Now;
            
            Person person = new Person(name, cpf, email, password, birthday);

            if (PeopleManager.GetInstance().SearchByEmailAndPassword(email, password) == null)
            {
                PeopleManager.GetInstance().AddPerson(person);

                this.Close();
                CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
                cadastrarUsuario.Show();

                MessageBox.Show("Usuário cadastrado!");
            } else
            {
                MessageBox.Show("Email já cadastrado!");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
