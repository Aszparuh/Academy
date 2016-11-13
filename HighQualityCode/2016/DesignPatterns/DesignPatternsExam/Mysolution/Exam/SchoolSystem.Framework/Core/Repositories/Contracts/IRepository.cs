using SchoolSystem.Framework.Models.Contracts;
using System.Collections.Generic;

namespace SchoolSystem.Framework.Core.Repositories.Contracts
{
    public interface IRepository
    {
        void AddStudent(int id, IStudent student);

        void AddTeacher(int id, ITeacher teacher);

        void RemoveTeacher(int id);

        void RemoveStudent(int id);

        IStudent GetStudentById(int id);

        ITeacher GetTeacherById(int id);

        IDictionary<int, ITeacher> GetAllTeachers();
    }
}
