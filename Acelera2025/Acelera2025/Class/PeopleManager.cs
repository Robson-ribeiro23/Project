using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Class
{
    internal class PeopleManager
    {
        public static PeopleManager Instance { get; private set; }

        private ArrayList peopleDB = new ArrayList();
        public Person myself;

        public PeopleManager()
        {
            Instance = this;
        }

        public ArrayList GetPeopleDB()
        {
            return peopleDB;
        }

        public void AddPerson(Person person)
        {
            person.SetIndex(peopleDB.Count);
            peopleDB.Add(person);
        }

        public void InativarPessoa(Person person)
        {
            person.SetActivity(true); // true = inativo
        }

        public Person BuscarPorEmailSenha(string email, string senha)
        {
            foreach (Person p in peopleDB)
            {
                if (p.GetEmail() == email && p.GetPassword() == senha && !p.IsInactive())
                {
                    return p;
                }
            }
            return null;
        }
    }
}