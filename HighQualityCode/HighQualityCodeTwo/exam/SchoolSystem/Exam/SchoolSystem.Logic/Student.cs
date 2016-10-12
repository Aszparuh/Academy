using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem.Logic
{
    public class Student : Person
    {
        private Grade grade;
        private IList<Mark> marks;

        public Student(string firstName, string lastName, Grade grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
            this.Marks = new List<Mark>();
        }

        // Poor man dependency injection
        public Student(string firstName, string lastName, Grade grade, IList<Mark> marks)
            : this(firstName, lastName, grade)
        {
            this.Marks = marks;
        }

        public IList<Mark> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }
        }

        public string ListMarks()
        {
            if (this.marks.Count == 0)
            {
                var result = "This student has no marks.";
                return result;
            }
            else
            {
                var marks = this.marks.Select(m => $"{m.Subject} => {m.Value}").ToList();
                var marksAsString = string.Join("\n", marks);
                var result = "The student has these marks:\r\n" + marksAsString + "\r\n";
                return result;
            }
        }
    }
}
