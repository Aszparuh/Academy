using System.Collections.Generic;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic.Commands
{
    internal class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            var student = StaticSchool.Students[studentId];
            var marks = student.ListMarks();
            return marks;
        }
    }
}
