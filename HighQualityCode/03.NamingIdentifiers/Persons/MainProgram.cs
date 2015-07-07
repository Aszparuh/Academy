namespace Persons
{
    using System;

    using Persons.Models;

    class MainProgram
    {
        static void Main(string[] args)
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