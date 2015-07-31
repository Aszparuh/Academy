namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private const string InvalidTownNameMessage = "Town name cannot be null, empty or whitespace";

        private string town;

        public OffsiteCourse(string courseName, string teacherName, string townName)
            : base(courseName, teacherName)
        {
            this.Town = townName;
        }

        public OffsiteCourse(string courseName, string teacherName, string townName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = townName;
        }

        public string Town
        {
            get 
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidTownNameMessage, "Town");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Town: " + this.Town);
            return sb.ToString();
        }
    }
}