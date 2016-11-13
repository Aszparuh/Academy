using SchoolSystem.Framework.Core.Repositories.Contracts;
using SchoolSystem.Framework.Models.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Framework.Core.Repositories
{
    public class SchoolRepository : IRepository
    {
        private IDictionary<int, IStudent> students;
        private IDictionary<int, ITeacher> teachers;

        public SchoolRepository()
        {
            this.students = new Dictionary<int, IStudent>();
            this.teachers = new Dictionary<int, ITeacher>();
        }

        public void AddStudent(int id, IStudent student)
        {
            this.students.Add(id, student);
        }

        public void AddTeacher(int id, ITeacher teacher)
        {
            this.teachers.Add(id, teacher);
        }

        public void RemoveTeacher(int id)
        {
            this.teachers.Remove(id);
        }

        public void RemoveStudent(int id)
        {
            this.students.Remove(id);
        }

        public IStudent GetStudentById(int id)
        {
            return this.students[id];
        }

        public ITeacher GetTeacherById(int id)
        {
            return this.teachers[id];
        }

        public IDictionary<int, ITeacher> GetAllTeachers()
        {
            return this.teachers;
        }
    }
}
