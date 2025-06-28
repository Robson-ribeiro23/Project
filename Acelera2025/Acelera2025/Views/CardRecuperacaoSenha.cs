using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;
using Ac;

namespace Acelera2025.Views
{
    public partial class CardRecuperacaoSenha: UserControl
    {
        public event EventHandler FecharTelaSolicitado;
        String codigoGerado;
        public CardRecuperacaoSenha()
        {
            InitializeComponent();
            panelNovaSenha.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CardRecuperacaoSenha_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReceberCodigo_Click(object sender, EventArgs e)
        {
            codigoGerado = GerarCodigoNumerico(6);
            Console.WriteLine($"Código gerado: {codigoGerado}");

            try
            {
                var fromAddress = new MailAddress("dairohelp@gmail.com", "Recuperação Senha");
                var toAddress = new MailAddress(txtEmail.Text.Trim(), "Destinatário");
                const string fromPassword = "tkep pwkn tsor voas";
                const string subject = "Código de Recuperação Connecta";
                string body = "Ola," + "Seu código de recuperação de senha é:"+ codigoGerado;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    MessageBox.Show("E-mail enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
       
       
         static string GerarCodigoNumerico(int tamanho)
        {
            Random random = new Random();
            string codigo = string.Empty;
            for (int i = 0; i < tamanho; i++)
            {
                codigo += random.Next(0, 10);
            }
            return codigo;
            
        } 
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Trim().Equals(codigoGerado, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Código correto");
                panelNovaSenha.Visible = true;
            }
            else
            {
                MessageBox.Show("Código incorreto digitado");
            }
        }
        private void btnFechar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaLoginUsuario();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            var usuarioController = new UsuarioControllers();
            string email = txtEmail.Text;
            string confirmarSenha = txtSenha.Text;

            bool sucesso = usuarioController.AtualizarSenha(email, confirmarSenha);
            if (sucesso)
            {
              Navegador.IrParaLoginUsuario();
            }
        
    }
}
    
}
