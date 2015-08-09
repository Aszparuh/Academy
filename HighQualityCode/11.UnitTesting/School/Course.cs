namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxSudentsInCourse = 30;

        private string name;
        private IList<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
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
                    throw new ArgumentException("Course name cannot be empty or white space");
                }

                this.name = value;
            }

        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student newStudent)
        {
            if (newStudent == null)
            {
                throw new ArgumentNullException("Cannot add null Student");
            }

            if (this.Students.Count + 1 > MaxSudentsInCourse)
            {
                throw new InvalidOperationException("Max students reached for the course");
            }

            if (this.Students.Contains(newStudent))
            {
                throw new InvalidOperationException("The student is already in the course");
            }

            this.students.Add(newStudent);
        }

        public void RemoveStudent(Student studentToRemove)
        {
            if (studentToRemove == null)
            {
                throw new ArgumentNullException("Cannot remove null student");
            }

            if (!this.Students.Contains(studentToRemove))
            {
                throw new InvalidOperationException("Cannot remove student that is not in the course");
            }

            this.students.Remove(studentToRemove);
        }
    }
}