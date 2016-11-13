using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Repositories.Contracts;
using System;

namespace SchoolSystem.Framework.Core.Commands
{
    public class TeacherAddMarkCommand : ICommand
    {
        private readonly IRepository repository;

        public TeacherAddMarkCommand(IRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("TeacherAddMark repository is null");
            }

            this.repository = repository;
        }

        public string Execute(IList<string> parameters)
        {
            var teacherId = int.Parse(parameters[0]);
            var studentId = int.Parse(parameters[1]);
            var mark = float.Parse(parameters[2]);

            var student = this.repository.GetStudentById(studentId);
            var teacher = this.repository.GetTeacherById(teacherId);

            teacher.AddMark(student, mark);
            return $"Teacher {teacher.FirstName} {teacher.LastName} added mark {mark} to student {student.FirstName} {student.LastName} in {teacher.Subject}.";
        }
    }
}
