namespace Persons
{
    using System;

    using Persons.Models;

    public class MainProgram
    {
        public static void Main()
        {
            int maleId = 222222;
            int femaleId = 222221;

            var firstPerson = PersonsGenerator.CreatePerson(maleId);
            var secondPerson = PersonsGenerator.CreatePerson(femaleId);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}