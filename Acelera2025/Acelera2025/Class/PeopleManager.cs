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
        public static PeopleManager Instance { get; set; }

        private ArrayList peopleDB = new ArrayList();
        public Person myself;

        public PeopleManager() {
            Instance = new PeopleManager();
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

        public void RemovePerson(Person person) {
            person.SetActivity(false);
        }
    }

}
