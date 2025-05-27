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
        private static PeopleManager Instance;

        private ArrayList peopleDB = new ArrayList();
        public Person myself;

        public static PeopleManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new PeopleManager();
            }
            return Instance;
        }

        public void Logout()
        {
            myself = null;
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

        public void DeactivatePerson(Person person)
        {
            person.SetActivity(true); // true = inativo
        }

        public Person SearchByEmailAndPassword(string email, string password)
        {
            foreach (Person p in peopleDB)
            {
                if (p.GetEmail() == email && p.GetPassword() == password && !p.IsInactive())
                {
                    return p;
                }
            }
            return null;
        }
    }
}