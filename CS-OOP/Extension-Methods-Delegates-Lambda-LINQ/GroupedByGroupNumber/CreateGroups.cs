namespace GroupedByGroupNumber
{
    /*Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
      Use LINQ.*/

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentGroups.Models;

    class CreateGroups
    {
        static void Main()
        {
            var someStudents = new List<Student>();
            someStudents.Add(new Student("Anton", "Penev", "201610", "+359898444444", "wer@abv.bg", 1));
            someStudents.Add(new Student("Stoian", "Dimitrov", "201606", "+359898333333", "wer@yahoo.com", 2));
            someStudents.Add(new Student("Peter", "Penev", "201612", "+359898222222", "wer@gmail.com", 1));
            someStudents.Add(new Student("Simeon", "Slavov", "2018106", "+359898111111", "example@abv.bg", 2));
            someStudents.Add(new Student("Dimitar", "Lubenov", "2016345", "+35929855555", "qwerty@abv.bg", 1));
            someStudents.Add(new Student("Angel", "Atansov", "1216065", "+359898666666", "abvbgr@outlook.com", 1));
            someStudents.Add(new Student("Stoimil", "Goshev", "3116125", "0287777777", "exampl2@abv.bg", 1));

            var studentsByGroup =
                from student in someStudents
                group student by student.Group
                    into groups
                    select new { Group = groups.Key, Students = groups.ToList() };

            foreach (var group in studentsByGroup)
            {
                Console.WriteLine("Group number {0}:", group.Group);
                Console.WriteLine(string.Join(", ", group.Students));
            }

            /*Rewrite the previous using extension methods.*/
            Console.WriteLine();
            var studentsByGroupExt = someStudents.GroupBy(st => st.Group, (Group, students) => new {Group = Group, Students = students  });

            foreach (var group in studentsByGroupExt)
            {
                Console.WriteLine("Group number {0}:", group.Group);
                Console.WriteLine(string.Join(", ", group.Students));
            }
        }   
    }
}