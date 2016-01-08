namespace SchoolSystemTest
{
    using System;
    using SchoolSysytemLib.Models;

    class tests
    {
        static void Main()
        {
            School exapmleSchool = new School("Some School Name");
            exapmleSchool.AddComment(new Comment("Comment sample"));
            exapmleSchool.AddComment(new Comment("another comment sample"));

            var comments = exapmleSchool.GetAllComments();
            foreach (var comment in comments)
            {
                Console.WriteLine(comment);
            }

            Console.WriteLine();
            SchoolClass exampleClass = new SchoolClass("First Group");
            exampleClass.AddStudent(new Student("Anton", "Stoianov"));
            exampleClass.AddStudent(new Student("Petar", "Dimitrov"));
            exampleClass.AddTeacher(new Teacher("Gosho", "Goshev", new Discipline("Biology", 15, 15)));

            Console.WriteLine(exampleClass);
        }
    }
}