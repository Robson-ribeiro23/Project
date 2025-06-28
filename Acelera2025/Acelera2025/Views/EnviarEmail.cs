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

namespace Acelera2025.Views
{


    public partial class EnviarEmail : UserControl
    {
        private EventoModels evento;
        private PessoaModels usuario;

        public EnviarEmail(EventoModels evento, PessoaModels usuario)
        {
            InitializeComponent();
            this.evento = evento;
            EmailDoDono.Text = evento.UsuarioEmail;
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proposta de patrocínio enviada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fecha o controle
            this.Parent.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
