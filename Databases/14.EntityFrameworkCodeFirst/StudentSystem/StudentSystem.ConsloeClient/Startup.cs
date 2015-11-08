namespace StudentSystem.ConsloeClient
{
    using System;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;

    public class Startup
    {
        public static void Main()
        {
            var db = new StudentsDbContext();
            var course = new Course
            {
                Name = "TestCourse",
                SignedOn = DateTime.Now
            };
            var student = new Student
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName"
            };

            student.Courses.Add(course);
            db.Students.Add(student);
            db.SaveChanges();
            
            Console.WriteLine(db.Students.Count());
        }
    }
}