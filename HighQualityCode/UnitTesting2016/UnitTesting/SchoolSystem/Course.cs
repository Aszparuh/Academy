namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxNumberOfStudents = 30;

        private IList<Student> enrolledStudents;
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.EnrolledStudents = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course name cannot be null, empty or whitespace");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public IList<Student> EnrolledStudents
        {
            get
            {
                return this.enrolledStudents;
            }

            private set
            {
                this.enrolledStudents = value;
            }
        }

        public void EnrollStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Null student cannot be enrolled");
            }
            else if (this.enrolledStudents.Count == MaxNumberOfStudents)
            {
                throw new InvalidOperationException($"Students in course cannot be more than {MaxNumberOfStudents}");
            }
            else if (this.enrolledStudents.Contains(student))
            {
                throw new InvalidOperationException("Student cannot be enrolled for course twice");
            }
            else
            {
                this.enrolledStudents.Add(student);
            }
        }

        public void DismissSudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Null student cannot be dismissed");
            }
            else if (this.enrolledStudents.Count == 0)
            {
                throw new InvalidOperationException("The course does not have any students");
            }
            else if (!this.enrolledStudents.Contains(student))
            {
                throw new InvalidOperationException("This student is not enrolled for this course");
            }
            else
            {
                this.enrolledStudents.Remove(student);
            }
        }
    }
}
