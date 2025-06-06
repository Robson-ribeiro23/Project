using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Class
{
    internal class Empresa
    {
        private int id;
        private string nome;
        private string cnpj;
        private string telefone;
        private string email;
        private string senha;
        private bool isInactive = false;

        public Empresa(string nome, string cnpj, string telefone, string email, string senha)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.telefone = telefone;
            this.email = email;
            this.senha = senha;
        }

        public void SetIndex(int id)
        {
            this.id = id;
        }

        public void SetActivity(bool isInactive)
        {
            this.isInactive = isInactive;
        }

        public int GetId()
        {
            return id;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCNPJ()
        {
            return cnpj;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetSenha()
        {
            return senha;
        }

        public bool IsInactive()
        {
            return isInactive;
        }
    }
}