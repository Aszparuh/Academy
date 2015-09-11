namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private const string InvalidNameMessage = "Invalid name";
        private const string InvalidStudentCollectionMessage = "Students cannot be null";

        private string courseName;
        private string teacherName;
        private ICollection<string> students;

        protected Course(string courseName, string teacherName = "N/A")
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.students = new List<string>();
        }

        protected Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.students = students;
        }

        public string CourseName
        {
            get 
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidNameMessage, "Course Name");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidNameMessage, "Teacher Name");
                }

                this.teacherName = value;
            }
        }

        public ICollection<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException(InvalidStudentCollectionMessage);
                }

                this.students = new List<string>(value);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Course: " + this.CourseName);
            sb.AppendLine(string.Format("Teacher: {0}", this.TeacherName));
            sb.AppendLine("Students: ");
            foreach (var student in this.Students)
            {
                sb.AppendLine(student);
            }

            return sb.ToString();
        }
    }
}