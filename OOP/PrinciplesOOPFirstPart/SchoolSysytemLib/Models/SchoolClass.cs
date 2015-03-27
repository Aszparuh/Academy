namespace SchoolSysytemLib.Models
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : BaseSchoolAbs
    {
        private string uniqueClassIdentifier;
        private List<Student> studentsInClass = new List<Student>();
        private List<Teacher> teachersOfClass = new List<Teacher>();

        #region CONSTRUCTORS

        public SchoolClass(string name, string uniqueIdentifier) : base(name)
        {
            this.uniqueClassIdentifier = UniqueClassNumberStorage.CreateNewUniqueClass();
        }

        public SchoolClass(string name, string uniqueIdentifier, Teacher aTeacher) : this(name, uniqueIdentifier)
        {
            this.AddTeacher(aTeacher);
        }
        #endregion

        #region TEACHERS

        public void AddTeacher(Teacher anyTeacher)
        {
            this.teachersOfClass.Add(anyTeacher);
        }

        public void RemoveTeacher(int index)
        {
            if (index > -1 && index < this.teachersOfClass.Count)
            {
                this.teachersOfClass.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid teacher index");
            }
        }

        public List<Teacher> GetAllTeachers()
        {
            if (this.teachersOfClass.Count == 0)
            {
                throw new InvalidOperationException("There are no teachers.");
            }

            return new List<Teacher>(this.teachersOfClass);
        }

        #endregion

        #region STUDENTS

        public void AddStudent(Student anyStudent)
        {
            this.studentsInClass.Add(anyStudent);
        }

        public void RemoveStudent(int index)
        {
            if (index > -1 && index < this.studentsInClass.Count)
            {
                this.studentsInClass.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid student index");
            }
        }

        public List<Student> GetAllStudents()
        {
            if (this.studentsInClass.Count == 0)
            {
                throw new InvalidOperationException("There are no students.");
            }

            return new List<Student>(this.studentsInClass);
        }
        #endregion
    }
}