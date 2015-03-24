namespace StudentGroups
{
    /*Create a List<Student> with sample students. Select only the students that are from group number 2.
     Use LINQ query. Order the students by FirstName.*/

    /*Implement the previous using the same query expressed with extension methods.*/

    /*Extract all students that have email in abv.bg.
      Use string methods and LINQ.*/

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Operations
    {
        static void Main()
        {
            var someStudents = new List<Student>();
            someStudents.Add(new Student("Anton", "Penev", "2016125", "+359898444444", "wer@abv.bg", 1));
            someStudents.Add(new Student("Stoian", "Dimitrov", "2016145", "+359898333333", "wer@yahoo.com", 2));
            someStudents.Add(new Student("Peter", "Penev", "2016125", "+359898222222", "wer@gmail.com", 1));
            someStudents.Add(new Student("Simeon", "Slavov", "2018125", "+359898111111", "example@abv.bg", 2));
            someStudents.Add(new Student("Dimitar", "Lubenov", "2016345", "+359898555555", "qwerty@abv.bg", 1));
            someStudents.Add(new Student("Angel", "Atansov", "1216125", "+359898666666", "abvbgr@outlook.com", 1));
            someStudents.Add(new Student("Stoimil", "Goshev", "3116125", "+359898777777", "exampl2@abv.bg", 1));

            Console.WriteLine("All Students:");
            foreach (var student in someStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            var studentsFromGroupTwo =
                from student in someStudents
                where student.Group == 2
                orderby student.FirstName
                select student;

            Console.WriteLine("All students from group 2:");
            foreach (var student in studentsFromGroupTwo)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            var studentsFromGroupOne = someStudents.Where(st => st.Group == 1)
                                                   .OrderBy(st => st.FirstName);

            Console.WriteLine("All students from group 1:");
            foreach (var student in studentsFromGroupOne)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            var studentsWithAbvMail =
                from student in someStudents
                where student.Email.Substring(student.Email.IndexOf('@') + 1) == "abv.bg"
                select student;

            Console.WriteLine("All student with abv e-mail:");
            foreach (var student in studentsWithAbvMail)
            {
                Console.WriteLine(student);
            }
        }
    }
}