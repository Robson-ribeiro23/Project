using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Class
{
    internal class Person
    {
        private int id;
        private string name;
        private string cpf;
        private string email;
        private string password;
        private DateTime birthday;
        private bool isInactive = false;

        public Person(string name, string cpf, string email, string password, DateTime birthday)
        {
            this.name = name;
            this.cpf = cpf;
            this.email = email;
            this.password = password;
            this.birthday = birthday;
        }

        public void SetIndex(int id)
        {
            this.id = id;
        }

        public void SetActivity(bool isInactive)
        {
            this.isInactive = isInactive;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPassword()
        {
            return password;
        }

        public bool IsInactive()
        {
            return isInactive;
        }

        public string GetName()
        {
            return name;
        }

        public string GetCPF()
        {
            return cpf;
        }

        public DateTime GetBirthday()
        {
            return birthday;
        }

        public int GetId()
        {
            return id;
        }
    }
}