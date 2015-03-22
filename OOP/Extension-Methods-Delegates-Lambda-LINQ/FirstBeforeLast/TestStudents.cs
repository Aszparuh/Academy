namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FirstBeforeLast.Models;

    class TestStudents
    {
        static void Main()
        {
            var testStudents = new List<Student>();
            testStudents.Add(new Student("Anton", "Ivanov", 25));
            testStudents.Add(new Student("Ivan", "Atansov", 23));
            testStudents.Add(new Student("Georgi", "Asenov", 23));
            testStudents.Add(new Student("Peter", "Zlatev", 25));

            var firstBeforeLast = testStudents.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            Console.WriteLine(string.Join(Environment.NewLine, firstBeforeLast));
        }
    }
}