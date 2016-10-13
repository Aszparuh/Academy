namespace StudentSystem.Models
{
    using System.Collections.Generic;

    public class Student
    {
        private ICollection<Course> courses;

        public Student()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int StudentNumber { get; set; }

        public virtual ICollection<Course> Courses 
        {
            get { return  this.courses; }
            set { this.courses = value; }
        }
    }
}