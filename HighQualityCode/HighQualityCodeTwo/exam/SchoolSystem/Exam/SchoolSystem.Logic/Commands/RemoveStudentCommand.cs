using System.Collections.Generic;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic.Commands
{
    internal class RemoveStudentCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var idForRemove = int.Parse(parameters[0]);
            StaticSchool.Students.Remove(idForRemove);
            var result = string.Format("Student with ID {0} was sucessfully removed.", idForRemove);
            return result;
        }
    }
}
