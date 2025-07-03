using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Acelera2025.Models;

namespace Acelera2025.Controllers
{
    public class EmpresaControllers
    {
        private static List<EmpresaModels> listaEmpresas = new List<EmpresaModels>();
        public static EmpresaModels loggedCompany;

        private bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool Cadastrar(EmpresaModels empresa)
        {
            if (string.IsNullOrWhiteSpace(empresa.Nome) ||
                string.IsNullOrWhiteSpace(empresa.CNPJ) ||
                string.IsNullOrWhiteSpace(empresa.Telefone) ||
                string.IsNullOrWhiteSpace(empresa.Cidade) ||
                string.IsNullOrWhiteSpace(empresa.Email) ||
                string.IsNullOrWhiteSpace(empresa.Senha) ||
                string.IsNullOrWhiteSpace(empresa.ConfirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return false;
            }

            if (listaEmpresas.Any(e => e.CNPJ == empresa.CNPJ))
            {
                MessageBox.Show("Já existe uma empresa com este CNPJ.");
                return false;
            }


            if (!EmailValido(empresa.Email))
            {
                MessageBox.Show("E-mail em formato inválido.");
                return false;
            }

            if (listaEmpresas.Any(e => e.Email == empresa.Email))
            {
                MessageBox.Show("Já existe uma empresa com este Email.");
                return false;
            }

            if (empresa.Senha != empresa.ConfirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return false;
            }

            empresa.CNPJ = new string(empresa.CNPJ.Where(char.IsDigit).ToArray());

            
            if (listaEmpresas.Any(e => e.CNPJ == empresa.CNPJ))
            {
                MessageBox.Show("Já existe uma empresa com este CNPJ.");
                return false;
            }

            empresa.Tipo = "Empresa";
            listaEmpresas.Add(empresa);
            return true;
        }

        public EmpresaModels Login(string cnpj, string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(cnpj) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha CNPJ, e-mail e a senha.");
                return null;
            }

            if (!EmailValido(email))
            {
                MessageBox.Show("E-mail em formato inválido.");
                return null;
            }

            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            var empresa = listaEmpresas.FirstOrDefault(e =>
                e.CNPJ == cnpj &&
                e.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase) &&
                e.Senha == senha
            );

            if (empresa == null)
            {
                MessageBox.Show("CNPJ, E-mail ou senha inválidos.");
                return null;
            }

            loggedCompany = empresa;
            return empresa;
        }

        public static List<EmpresaModels> ListarTodos()
        {
            return listaEmpresas;
        }

        public static bool HasCompanyByEmail(string email)
        {
            return listaEmpresas.Any(u => u.Email == email);
        }
    }
}

