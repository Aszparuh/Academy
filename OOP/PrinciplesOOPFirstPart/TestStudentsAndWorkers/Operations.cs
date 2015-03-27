namespace TestStudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentsAndWorkersLib.Models;

    class Operations
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Peter", "Toshev", 2.5));
            students.Add(new Student("Stoian", "Nedev", 3.5));
            students.Add(new Student("Peter", "Petrov", 4.5));
            students.Add(new Student("Hristo", "Ivanov", 1.5));
            students.Add(new Student("Tencho","Ushev", 3.5));
            students.Add(new Student("Soimil", "Georgiev", 3));
            students.Add(new Student("Nancho", "Kolev", 2.5));
            students.Add(new Student("Pencho", "Botev", 2.7));
            students.Add(new Student("Simeon", "Denkov", 4.6));
            students.Add(new Student("Martin", "Ganchev", 6));

            Console.WriteLine("Students sorted by grade:");
            var sortedSt =
                from student in students
                orderby student.Grade
                select student;
            foreach (var student in sortedSt)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Asen", "Tonev", 200, 6));
            workers.Add(new Worker("Todor", "Ivanov", 150, 5));
            workers.Add(new Worker("Georgi", "Hristov", 155, 7));
            workers.Add(new Worker("Vasil", "Mitev", 150.5, 4));
            workers.Add(new Worker("Teodora", "Petrova", 156, 8));
            workers.Add(new Worker("Kalina", "Ianeva", 156, 8));
            workers.Add(new Worker("Diana", "Koleva", 156, 8));
            workers.Add(new Worker("Petra", "Stoianova", 156, 8));
            workers.Add(new Worker("Dida", "Petrova", 156, 8));
            workers.Add(new Worker("Mladen", "Ianev", 156, 8));

            Console.WriteLine("Workers sorted by money earned per hour:");
            var sortedWorkers = workers.OrderBy(wk => wk.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();

            Console.WriteLine("All sorted by first and last name:");
            List<Human> allHumans = new List<Human>();
            allHumans.AddRange(students);
            allHumans.AddRange(workers);

            var sorted = allHumans.OrderBy(hm => hm.FirstName)
                                  .ThenBy(hm => hm.LastName);

            foreach (var human in sorted)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
                                                
        }
    }
}