
using System;
using System.Collections.Generic;

namespace Acelera2025
{
	public static class PeopleManager
	{
		private List<People> peopleDB;

		public void AddPerson(Person p)
		{
			peopleDB.Add(p);

		}
	}
}
