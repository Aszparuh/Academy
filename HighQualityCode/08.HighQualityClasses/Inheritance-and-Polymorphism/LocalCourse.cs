namespace InheritanceAndPolymorphism
{
    using System;
    using System.Text;

    public class LocalCourse : Course
    {
        private const string InvalidLabNameMessage = "Lab name cannot be null, empty or white space";

        private string lab;

        public LocalCourse(string courseName, string teacherName = "N/A", string labName = "N/A")
           :base(courseName, teacherName)
        {
            this.Lab = labName;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidLabNameMessage, "Lab");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Lab: " + this.Lab);
            return sb.ToString();
        }
    }
}