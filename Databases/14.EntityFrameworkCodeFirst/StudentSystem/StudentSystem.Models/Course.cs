namespace StudentSystem.Models
{
    using System;

    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Materials { get; set; }

        public DateTime? SignedOn { get; set; }
    }
}