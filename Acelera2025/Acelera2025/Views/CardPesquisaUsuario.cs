using Acelera2025.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Telas
{
    public partial class CardPesquisaUsuario: UserControl
    {
        public CardPesquisaUsuario()
        {
            InitializeComponent();
        }

        public CardPesquisaUsuario(UsuarioModels usuario)
        {
            InitializeComponent();

            lblNome.Text = usuario.Nome;
            

            if (!string.IsNullOrEmpty(usuario.CaminhoFoto) && File.Exists(usuario.CaminhoFoto))
            {
                picPerfil.Image = Image.FromFile(usuario.CaminhoFoto);
            }
        }


        public void DefinirDados(PessoaModels usuario)
        {
            lblNome.Text = usuario.Nome;
            if (!string.IsNullOrEmpty(usuario.CaminhoFoto) && File.Exists(usuario.CaminhoFoto))
            {
                picPerfil.Image = Image.FromFile(usuario.CaminhoFoto);
            }
        }

        private void CardPesquisaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
