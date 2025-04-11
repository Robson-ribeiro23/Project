using System;

namespace Acelera2025
{
    public class Enterprise
    {
        protected string nameE, cnpj, telefone, emailE, passwordE;

        public Enterprise()
        {

        }

        public void SetNameE(string nameE)
        {
            this.nameE = nameE;
        }
        public string GetNameE() { return this.nameE; }


        public void SetCnpj(string cnpj)
        {
            this.cnpj= cnpj;
        }
        public string GetCnpj() { return this.cnpj; }


        public void SetTelefone(string telefone)
        {
           this.telefone = telefone;
        }
         public string GetTelefone() { return this.telefone; }


        public void SetEmailE(string emailE)
        {
            this.emailE = emailE;
        }
        public string GetEmailE() { return this.emailE; }


        public void SetPasswordE(string passwordE)
        {
            this.passwordE = passwordE;
        }
        public string GetPasswordE() { return this.passwordE; }


    }
}
