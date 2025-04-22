using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Class
{
    internal class PeopleManager
    {
        public static PeopleManager Instance { get; set; }

        private List<Person> peopleDB = new List<Person>();
        public Person myself;

        public PeopleManager() {
            Instance = new PeopleManager();
        }

        public List<Person> GetPeople()
        {
            return peopleDB;
        }

        public void AddPerson(Person person)
        {
            peopleDB.Add(person);
        }

        public void RemovePerson(Person person) {
            int index = peopleDB.IndexOf(person);
            
        }
    }
}
