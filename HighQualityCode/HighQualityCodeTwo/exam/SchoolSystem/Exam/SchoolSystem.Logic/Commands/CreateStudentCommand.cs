using System.Collections.Generic;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic.Commands
{
    internal class CreateStudentCommand : ICommand
    {
        private static int id = 0;

        public string Execute(IList<string> parameters)
        {
            var studentFirstName = parameters[0];
            var studentLastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            StaticSchool.Students.Add(id, new Student(studentFirstName, studentLastName, grade));
            var result = string.Format("A new student with name {0} {1}, grade {2} and ID {3} was created.", studentFirstName, studentLastName, grade, id);
            id++;
            return result;
        }
    }
}
