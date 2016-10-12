using System.Collections.Generic;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic.Commands
{
    public class RemoveTeacherCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var idForRemove = int.Parse(parameters[0]);
            StaticSchool.Teachers.Remove(idForRemove);
            var result = string.Format("Teacher with ID {0} was sucessfully removed.", idForRemove);
            return result;
        }
    }
}
