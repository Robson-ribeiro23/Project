using System;
using System.Drawing;
using System.Windows.Forms;
using Ac;
using System.IO;

namespace Acelera2025.Views
{
    public partial class CardPerfil: UserControl
    {
        public event EventHandler FecharTelaSolicitado;

        private PessoaModels usuario;
        public CardPerfil(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblNome.Text = usuario.Nome;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }
        }

        private void CardPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.usuario.Tipo == "empresa")
            {
                //PerfilEmpresa perfil = new PerfilEmpresa();
                //perfil.Show();

                //FecharTelaSolicitado?.Invoke(this, EventArgs.Empty);
                Navegador.IrParaPerfilEmpresa(this.usuario);

            }
            else if(this.usuario.Tipo == "usuario")
            {
                //Perfil perfil = new Perfil();
                //perfil.Show();

                //FecharTelaSolicitado?.Invoke(this, EventArgs.Empty);
                Navegador.IrParaPerfilUsuario(this.usuario);
            }

        }

        private void btnSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaInicio();
        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
