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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {
            string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO",
                     "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR",
                     "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

            comboUF.Items.AddRange(estados);
            txtSenha.PasswordChar = '*';
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;

            txtConfirmarSenha.PasswordChar = '*';
            btnMostrarSenhaConfirmar.Image = Properties.Resources.icons8_hide_24_1;
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

            if (PeopleManager.GetInstance().SearchByEmailAndPasswordAndCpf(cpf,email, password) == null)
            {
                PeopleManager.GetInstance().AddPerson(person);

                this.Close();
                EntrarUsuario login = new EntrarUsuario();
                login.Show();

                MessageBox.Show("Usuário cadastrado!");
            }
            
            else
            {
                MessageBox.Show("Usuario já cadastrado!");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
                btnMostrarSenha.Image = Properties.Resources.icons8_eye_30_1;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
            }
        }

        private void btnMostrarSenhaConfirmar_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.PasswordChar == '*')
            {
                txtConfirmarSenha.PasswordChar = '\0';
                btnMostrarSenhaConfirmar.Image = Properties.Resources.icons8_eye_30_1;
            }
            else
            {
                txtConfirmarSenha.PasswordChar = '*';
                btnMostrarSenhaConfirmar.Image = Properties.Resources.icons8_hide_24_1;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
