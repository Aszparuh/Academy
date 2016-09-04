using System;
using Persons.Types;

namespace Persons.Models
{
    public class PersonFactory
    {
        public Person CreatePerson(int id)
        {
            var person = new Person();

            if (id % 2 == 0)
            {
                person.Name = "John Dow";
                person.Age = 20;
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Jane Dow";
                person.Age = 20;
                person.Gender = Gender.Female;
            }

            return person;
        }
    }
}
