namespace StudentGroups
{
    /*Create a List<Student> with sample students. Select only the students that are from group number 2.
     Use LINQ query. Order the students by FirstName.*/

    using System;
    using System.Collections.Generic;

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
        }
    }
}