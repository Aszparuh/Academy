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
            testStudents.Add(new Student("Ivan", "Atansov", 28));
            testStudents.Add(new Student("Georgi", "Asenov", 23));
            testStudents.Add(new Student("Peter", "Zlatev", 22));
            testStudents.Add(new Student("Peter", "Stoianov", 17));
            testStudents.Add(new Student("Ivan", "Ivanov", 15));

            //var firstBeforeLast = testStudents.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            //Console.WriteLine(string.Join(Environment.NewLine, firstBeforeLast));

            //first before last using Linq query
            var firstBeforeLastQuery =
                from student in testStudents
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            Console.WriteLine("First before last using Linq query.");
            Console.WriteLine(string.Join(Environment.NewLine, firstBeforeLastQuery));

            //first name and last name of all students with age between 18 and 24.
            var studentsByAge =
                from student in testStudents
                where student.Age >= 18 && student.Age <= 24
                select student;
            Console.WriteLine();
            Console.WriteLine("Students with age between 18 and 24");
            Console.WriteLine(string.Join(Environment.NewLine, studentsByAge));

            //OrderStudents
            //Lambda
            var sortedByNamesDes = testStudents.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
            Console.WriteLine();
            Console.WriteLine("Students sorted descending by first than last name");
            foreach (var student in sortedByNamesDes)
            {
                Console.WriteLine(student);
            }

            //Linq
            var sortedByNameLinq =
                from student in testStudents
                orderby student.FirstName, student.LastName descending
                select student;
            Console.WriteLine();
            Console.WriteLine("Students sorted descending by first than last name using Linq query");
            foreach (var student in sortedByNamesDes)
            {
                Console.WriteLine(student);
            }

        }   
    }
}