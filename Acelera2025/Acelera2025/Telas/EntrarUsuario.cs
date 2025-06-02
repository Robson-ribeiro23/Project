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
                /*Principal p = new Principal();
           p.Show();
           this.Hide();*/
            }
            else
            {
               
                MessageBox.Show("Email ou senha incorretos!");
            }

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

        private void EntrarUsuario_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
        }

        private void btnRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Principal p = new Principal();
            p.Show();
            this.Hide();*/
        }
    }
}
