
using System;

namespace Acelera2025
{
    public class Person
    {
        protected string name, cpf, email, password;

        public Person()
        {

        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName() { return this.name; }

        public void SetCPF(string cpf)
        {
            this.cpf = cpf;
        }
        public string GetCPF() { return this.cpf; }

        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail() { return this.email; }

        public void SetPassword(string password)
        {
            this.password = password;
        }
        public string GetPassword() { return this.password; }

    }
}
