using Ac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;






namespace Acelera2025.Views
{


    public partial class EnviarEmail : UserControl
    {
        private EventoModels evento;
        private PessoaModels usuario;
        private string emailDonoEvento;

        public EnviarEmail(EventoModels evento, PessoaModels usuario, string emailDonoEvento)
        {
            InitializeComponent();
            this.evento = evento;
            EmailDoDono.Text = emailDonoEvento;
            this.emailDonoEvento = emailDonoEvento;
            this.usuario = usuario;


        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text.Trim();
            string mensagem = txtTexto.Text.Trim();

            if (string.IsNullOrEmpty(assunto) || string.IsNullOrEmpty(mensagem))
            {
                MessageBox.Show("Preencha todos os campos antes de enviar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var remetente = new MailAddress("dairohelp@gmail.com", "Contato Patrocínio");
                var destinatario = new MailAddress(emailDonoEvento);
                const string senha = "tkep pwkn tsor voas"; // usar senha de app do Gmail

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(remetente.Address, senha),
                    Timeout = 20000
                };

                using (var email = new MailMessage(remetente, destinatario)
                {
                    Subject = assunto,
                    Body = $"Mensagem de patrocínio enviada por {usuario.Nome} ({usuario.Email}):\n\n{mensagem}"
                })
                {
                    smtp.Send(email);
                    MessageBox.Show("Proposta de patrocínio enviada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Parent.Controls.Remove(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void fechar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
