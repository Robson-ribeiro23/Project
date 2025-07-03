using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Acelera2025.Views
{
    public partial class CardEditarPerfilEmpresa : UserControl
    {

        private EmpresaModels empresa;
        public event Action<EmpresaModels> DadosAtualizados;

        public event EventHandler FecharTelaSolicitado;

        public CardEditarPerfilEmpresa()
        {
            InitializeComponent();
            
        }

        public void PreencherDados(EmpresaModels empresa)
        {
            this.empresa = empresa;
            lblNome.Text = empresa.Nome;
            txtEmail.Text = empresa.Email;

            if (!string.IsNullOrEmpty(empresa.CaminhoFoto) && File.Exists(empresa.CaminhoFoto))
            {
                using (var stream = new FileStream(empresa.CaminhoFoto, FileMode.Open, FileAccess.Read))
                {
                    picPerfilEmpresa.Image = Image.FromStream(stream);
                }
            }
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string novoCaminho = dialog.FileName;
                empresa.CaminhoFoto = novoCaminho;

                if (File.Exists(novoCaminho))
                {
                    using (var stream = new FileStream(novoCaminho, FileMode.Open, FileAccess.Read))
                    {
                        picPerfilEmpresa.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text != empresa.Senha)
            {
                MessageBox.Show("Senha atual incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            empresa.Email = txtEmail.Text;

            if (!string.IsNullOrEmpty(txtNovaSenha.Text))
                empresa.Senha = txtNovaSenha.Text;

            // Notifica o formulário principal
            DadosAtualizados?.Invoke(empresa);

            MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
