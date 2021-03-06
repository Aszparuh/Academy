﻿namespace StudentGroups
{
    /*Create a List<Student> with sample students. Select only the students that are from group number 2.
     Use LINQ query. Order the students by FirstName.*/

    /*Implement the previous using the same query expressed with extension methods.*/
  
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentGroups.Models;

    class Operations
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

            //Add some marks for tests
            someStudents[1].AddMark("Biology", 6);
            someStudents[1].AddMark("Math", 4);
            someStudents[2].AddMark("Biology", 3);
            someStudents[2].AddMark("Math", 6);
            someStudents[3].AddMark("Biology", 4);
            someStudents[5].AddMark("Biology", 4.5);

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

            /*Extract all students that have email in abv.bg.
              Use string methods and LINQ.*/

            var studentsWithAbvMail =
                from student in someStudents
                where student.Email.Substring(student.Email.IndexOf('@') + 1) == "abv.bg"
                select student;

            Console.WriteLine("All student with abv e-mail:");
            foreach (var student in studentsWithAbvMail)
            {
                Console.WriteLine(student);
            }

            /*Extract all students with phones in Sofia.
             Use LINQ.*/

            Console.WriteLine();
            var studentsWithSfNumber =
                from student in someStudents
                where student.Telephone.StartsWith("+3592") || student.Telephone.StartsWith("02")
                select student;

            Console.WriteLine("All students with numbers in Sofia:");
            foreach (var student in studentsWithSfNumber)
            {
                Console.WriteLine(student);
            }

            /*Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            Use LINQ.*/

            Console.WriteLine();
            var studentsWithOneExcellentMark =
                from student in someStudents
                where student.Marks.ContainsValue(6)
                select new {StudentName = string.Format("{0} {1}", student.FirstName, student.LastName), Marks = student.Marks};

            Console.WriteLine("Students with at least one excellent mark:");
            foreach (var student in studentsWithOneExcellentMark)
            {
                Console.WriteLine(student.StudentName);
                foreach (KeyValuePair<string, double> pair in student.Marks)
	            {
	                Console.WriteLine("{0} {1}",
		            pair.Key,
		            pair.Value);
	            }
            }

            Console.WriteLine();

            /*Write down a similar program that extracts the students with exactly two marks "2".
              Use extension methods.*/

            var studentsWithTwoMarks = someStudents.Where(st => st.Marks.Count == 2);
                

            Console.WriteLine("Students with 2 marks");
            foreach (var student in studentsWithTwoMarks)
            {
                Console.WriteLine(student);
            }

            /*Extract all Marks of the students that enrolled in 2006. (The students from
             * 2006 have 06 as their 5-th and 6-th digit in the FN).*/

            Console.WriteLine();
            var studentsThatEnrolled =
            from student in someStudents
            where student.FacultyNumber[4] == '0' && student.FacultyNumber[5] == '6'
            select new { StudentName = string.Format("{0} {1}", student.FirstName, student.LastName), Marks = student.Marks };

            Console.WriteLine("Students' marks 2006");
            foreach (var student in studentsThatEnrolled)
            {
                Console.WriteLine(student.StudentName);
                foreach (KeyValuePair<string, double> pair in student.Marks)
                {
                    Console.WriteLine("{0} {1}",
                    pair.Key,
                    pair.Value);
                }
            }

            /*eate a class Group with properties GroupNumber and DepartmentName.
            Introduce a property GroupNumber in the Student class.
            Extract all students from "Mathematics" department.
            Use the Join operator.*/

            Console.WriteLine();
            Console.WriteLine("All students in Mathematics Department:");
            Group group1 = new Group(1, "Mathematics");
            Group group2 = new Group(2, "Biology");
            Group group3 = new Group(3, "Science");

            List<Group> groups = new List<Group> { group1, group2, group3 };

            var studentsDptMath =
                from agroup in groups
                where agroup.GroupNumber == 1
                join student in someStudents on agroup.GroupNumber equals student.Group
                select new 
                {          
                    Name = student.FirstName + " " + student.LastName,
                    Department = agroup.DepartmentName
                };

            foreach (var student in studentsDptMath)
            {
                Console.WriteLine("{0} {1}", student.Name, student.Department);
            }
        }
    }
}