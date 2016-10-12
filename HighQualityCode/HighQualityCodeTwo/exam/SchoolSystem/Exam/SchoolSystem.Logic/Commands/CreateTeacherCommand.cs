using System.Collections.Generic;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic.Commands
{
    internal class CreateTeacherCommand : ICommand
    {
        private static int id = 0;

        public string Execute(IList<string> parameters)
        {
            var teacherFirstName = parameters[0];
            var teacherLastName = parameters[1];
            var subject = (Subject)int.Parse(parameters[2]);
            var teacher = new Teacher(teacherFirstName, teacherLastName, subject);
            StaticSchool.Teachers.Add(id, teacher);
            var result = string.Format("A new teacher with name {0} {1}, subject {2} and ID {3} was created.", teacherFirstName, teacherLastName, subject, id);
            id++;
            return result;
        }
    }
}
