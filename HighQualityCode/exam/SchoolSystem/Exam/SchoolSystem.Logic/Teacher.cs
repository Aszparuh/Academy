using System;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic
{
    public class Teacher : Person, ITeacher
    {
        public Teacher(string firstName, string lastName, Subject subject)
            : base(firstName, lastName)
        {
            this.Subject = subject;
        }

        public Subject Subject { get; set; }

        public void AddMark(Student student, float value)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student must not be null");
            }

            var mark = new Mark(this.Subject, value);
            student.Marks.Add(mark);
        }
    }
}
