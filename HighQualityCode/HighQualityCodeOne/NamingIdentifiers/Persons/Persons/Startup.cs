using System;
using System.Collections.Generic;
using Persons.Models;

namespace Persons
{
    public class Startup
    {
        public static void Main()
        {
            var list = new List<Person>();
            var factory = new PersonFactory();

            for (int i = 0; i < 30; i++)
            {
                var person = factory.CreatePerson(i);
                list.Add(person);
            }

            foreach (var person in list)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.Gender);
                Console.WriteLine();
            }
        }
    }
}
