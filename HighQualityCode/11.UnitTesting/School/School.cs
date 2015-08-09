namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private IList<Course> courses;
        private IList<Student> students;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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
                    throw new ArgumentNullException("School name cannot be null or empty");
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

        public IList<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course courseToAdd)
        {
            if (courseToAdd == null)
            {
                throw new ArgumentNullException("Cannot add null course");
            }

            if (this.Courses.Contains(courseToAdd))
            {
                throw new InvalidOperationException("Course has been added");
            }

            this.courses.Add(courseToAdd);
        }

        public void RemoveCourse(Course courseToRemove)
        {
            if (courseToRemove == null)
            {
                throw new ArgumentNullException("Cannot remove null course");
            }

            if (!this.courses.Contains(courseToRemove))
            {
                throw new InvalidOperationException("There is no such a course in the school");
            }

            this.courses.Remove(courseToRemove);
        }

        public void AddStudent(Student studentToAdd)
        {
            if (studentToAdd == null)
            {
                throw new ArgumentNullException("Cannot add null student");
            }

            if (this.Students.Contains(studentToAdd))
            {
                throw new InvalidOperationException("student is already added");
            }

            this.students.Add(studentToAdd);
        }

        public void RemoveStudent(Student studentToRemove)
        {
            if (studentToRemove == null)
            {
                throw new ArgumentNullException("Cannot remove null student");
            }

            if (!this.Students.Contains(studentToRemove))
            {
                throw new InvalidOperationException("There is no such student in the school");
            }

            this.students.Remove(studentToRemove);
        }
    }
}