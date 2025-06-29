using Ac;
using Acelera2025.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Drawing;

namespace Acelera2025.Views
{
    public partial class CadastrarUsuario : Form
    {
        private UsuarioControllers controllerUsuario = new UsuarioControllers();
        private const int MAX_CARACTERES_NOME = 100;

        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {
            btnMostrarSenha.Image = Properties.Resources.icons8_hide_24_1;
            btnMostrarSenhaConfirmar.Image = Properties.Resources.icons8_hide_24_1;

            // Configuração inicial dos labels de validação da senha (opcional)
            lblMaiuscula.ForeColor = Color.Red;
            lblNumero.ForeColor = Color.Red;
            lblTamanhoSenha.ForeColor = Color.Red;

            string[] nomes = { "a", "b", "c", "d", "e" };

            for (int i = 0; i < nomes.Length; i++)
            {
                string four = new string(i.ToString()[0], 4);
                string three = new string(i.ToString()[0], 3);
                string two = new string(i.ToString()[0], 2);

                var user = new UsuarioModels
                {
                    Tipo = "usuario",
                    Nome = nomes[i],
                    Email = nomes[i] + "@gmail.com",
                    Cidade = "Cruzeiro",
                    CPF = $"{three}.{three}.{three}-{two}",
                    DataNascimento = $"{two}/{two}/{four}",
                    Senha = i.ToString(),
                    ConfirmarSenha = i.ToString(),
                    CaminhoFoto = @"C:\Programming\C#\university\Acelera2025\Acelera2025\Pictures\avatar_padrao.png"
                };

                controllerUsuario.Cadastrar(user);
            }

            var usuario = new UsuarioModels
            {
                Tipo = "usuario",
                Nome = "v",
                Email = "v@gmail.com",
                Cidade = "Cruzeiro",
                CPF = "999.999.999-99",
                DataNascimento = "99/99/9999",
                Senha = "9",
                ConfirmarSenha = "9",
                CaminhoFoto = @"C:\Programming\C#\university\Acelera2025\Acelera2025\Pictures\avatar_padrao.png"
            };

            if (controllerUsuario.Cadastrar(usuario))
            {
                Navegador.IrParaLoginUsuario();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaOpcaoLogin();
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

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string texto = new string(txtCpf.Text.Where(char.IsDigit).ToArray());

            if (char.IsControl(e.KeyChar))
                return;

            texto += e.KeyChar;

            if (texto.Length > 11)
            {
                e.Handled = true;
                return;
            }

            string formatado = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (i == 3 || i == 6)
                    formatado += ".";
                else if (i == 9)
                    formatado += "-";

                formatado += texto[i];
            }

            e.Handled = true;

            txtCpf.Text = formatado;

            txtCpf.SelectionStart = txtCpf.Text.Length;
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string texto = new string(txtData.Text.Where(char.IsDigit).ToArray());

            if (char.IsControl(e.KeyChar))
                return;

            texto += e.KeyChar;

            if (texto.Length > 8)
            {
                e.Handled = true;
                return;
            }

            string formatado = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (i == 2 || i == 4)
                    formatado += "/";

                formatado += texto[i];
            }

            e.Handled = true;

            txtData.Text = formatado;
            txtData.SelectionStart = txtData.Text.Length;
        }

        private void CadastrarUsuario_Click(object sender, EventArgs e)
        {
            // Validações
            if (!ValidarNome(txtNome.Text))
            {
                MessageBox.Show("Nome inválido. Verifique se não está vazio e não ultrapassa o limite de caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (!ValidarCPF(txtCpf.Text))
            {
                MessageBox.Show("CPF inválido. Verifique o número digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpf.Focus();
                return;
            }

            if (!ValidarDataNascimento(txtData.Text))
            {
                MessageBox.Show("Data de nascimento inválida. Verifique se está no formato correto (DD/MM/AAAA) e não é uma data futura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtData.Focus();
                return;
            }

            if (!ValidarSenha(txtSenha.Text))
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra maiúscula, um número e ter no mínimo 8 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarSenha.Focus();
                return;
            }

            var usuario = new UsuarioModels
            {
                Tipo = "usuario",
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Cidade = txtCidade.Text.Trim(),
                CPF = new string(txtCpf.Text.Where(char.IsDigit).ToArray()), // Armazena apenas números
                DataNascimento = txtData.Text,
                Senha = txtSenha.Text,
                ConfirmarSenha = txtConfirmarSenha.Text,
                CaminhoFoto = @"C:\Programming\C#\university\Acelera2025\Acelera2025\Pictures\avatar_padrao.png"
            };

            if (controllerUsuario.Cadastrar(usuario))
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            txtCpf.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
            txtData.Text = "";

            // Resetar os labels de validação da senha
            lblMaiuscula.ForeColor = Color.Red;
            lblNumero.ForeColor = Color.Red;
            lblTamanhoSenha.ForeColor = Color.Red;
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

        private void btnEntrarUsuario_Click(object sender, EventArgs e)
        {
            Navegador.IrParaLoginUsuario();
        }

        // Métodos de validação
        private bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Regex para validar formato de e-mail
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private bool ValidarNome(string nome)
        {
           
            if (string.IsNullOrWhiteSpace(nome))
                return false;

           
            var partesNome = nome.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (partesNome.Length < 2)
            {
                MessageBox.Show("Por favor, digite seu nome completo (pelo menos nome e sobrenome).",
                              "Nome incompleto",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            if (nome.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c) && !"áéíóúâêîôûãõàèìòùäëïöüçÁÉÍÓÚÂÊÎÔÛÃÕÀÈÌÒÙÄËÏÖÜÇ".Contains(c)))
            {
                MessageBox.Show("O nome deve conter apenas letras e espaços.",
                              "Caracteres inválidos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }


            foreach (var parte in partesNome)
            {
                if (parte.Length < 2)
                {
                    MessageBox.Show("Cada parte do nome deve ter pelo menos 2 caracteres.",
                                  "Nome inválido",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return false;
                }
            }

           
            const int MAX_CARACTERES_NOME = 100;
            if (nome.Length > MAX_CARACTERES_NOME)
            {
                MessageBox.Show($"O nome não pode ter mais de {MAX_CARACTERES_NOME} caracteres.",
                               "Nome muito longo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarSenha(string senha)
        {
            const int MIN_CARACTERES_SENHA = 8;
            return !string.IsNullOrWhiteSpace(senha) &&
                   senha.Length >= MIN_CARACTERES_SENHA &&
                   senha.Any(char.IsUpper) &&
                   senha.Any(char.IsDigit);
        }

        private bool ValidarDataNascimento(string dataStr)
        {
            if (string.IsNullOrWhiteSpace(dataStr))
                return false;

            if (!DateTime.TryParseExact(dataStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
                return false;

           
            return dataNascimento <= DateTime.Today &&
                   dataNascimento <= DateTime.Today.AddYears(-12);
        }

        private bool ValidarCPF(string cpf)
        {
           
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

         
            if (cpf.Length != 11)
                return false;

           
            if (cpf.Distinct().Count() == 1)
                return false;

            
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

           
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

          
            return int.Parse(cpf[9].ToString()) == digito1 &&
                   int.Parse(cpf[10].ToString()) == digito2;
        }

       
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length > 0)
            {
                bool temMaiuscula = txtSenha.Text.Any(char.IsUpper);
                bool temNumero = txtSenha.Text.Any(char.IsDigit);
                bool temTamanhoMinimo = txtSenha.Text.Length >= 8;

                lblMaiuscula.ForeColor = temMaiuscula ? Color.Green : Color.Red;
                lblNumero.ForeColor = temNumero ? Color.Green : Color.Red;
                lblTamanhoSenha.ForeColor = temTamanhoMinimo ? Color.Green : Color.Red;
            }
            else
            {
                lblMaiuscula.ForeColor = Color.Red;
                lblNumero.ForeColor = Color.Red;
                lblTamanhoSenha.ForeColor = Color.Red;
            }
        }

     
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
             
            const int MAX_CARACTERES_NOME = 100;
            if (txtNome.Text.Length > MAX_CARACTERES_NOME)
            {
                txtNome.Text = txtNome.Text.Substring(0, MAX_CARACTERES_NOME);
                txtNome.SelectionStart = MAX_CARACTERES_NOME;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}