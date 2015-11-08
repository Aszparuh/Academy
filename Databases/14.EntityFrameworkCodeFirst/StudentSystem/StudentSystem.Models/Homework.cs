namespace StudentSystem.Models
{
    using System;

    public class Homework
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime SentOn { get; set; }
    }
}