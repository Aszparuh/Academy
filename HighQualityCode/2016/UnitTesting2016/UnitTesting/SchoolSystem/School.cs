namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private IList<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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
                    throw new ArgumentException("Scholl name cannot be null, empty or whitespace");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public IEnumerable<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Null course cannot be added");
            }
            else if (this.courses.Contains(course))
            {
                throw new InvalidOperationException("This course is already added");
            }
            else
            {
                this.courses.Add(course);
            }
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Null course cannot be removes");
            }
            else if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException("There is no such a course in the school");
            }
            else
            {
                this.courses.Remove(course);
            }
        }
    }
}
