using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Class
{
    internal class Person
    {
        private string name;
        private string cpf;
        private string email;
        private string password;
        private Date birthday;

        public Person(string name, string cpf, string email, string password, Date birthday) { 
            this.name = name;
            this.cpf = cpf;
            this.email = email;
            this.password = password;
            this.birthday = birthday;
        }
    }
}
