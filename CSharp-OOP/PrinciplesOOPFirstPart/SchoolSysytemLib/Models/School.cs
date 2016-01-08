namespace SchoolSysytemLib.Models
{
    using System;
    using System.Collections.Generic;

    public class School : BaseSchoolAbs
    {
        private List<SchoolClass> courses = new List<SchoolClass>();

        public School(string name) : base(name)
        { }

        public void AddCourse(SchoolClass anyClass)
        {
            this.courses.Add(anyClass);
        }

        public void RemoveCourse(int index)
        {
            if (index > -1 && index < this.courses.Count)
            {
                this.courses.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid course index");
            }
        }

        public List<SchoolClass> GetAllCoures()
        {
            if (this.courses.Count == 0)
            {
                throw new InvalidOperationException("There are no courses.");
            }

            return new List<SchoolClass>(this.courses);
        }
    }
}