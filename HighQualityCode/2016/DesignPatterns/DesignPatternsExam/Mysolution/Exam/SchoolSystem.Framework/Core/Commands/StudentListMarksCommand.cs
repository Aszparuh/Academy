using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Repositories.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class StudentListMarksCommand : ICommand
    {
        private readonly IRepository repostory;

        public StudentListMarksCommand(IRepository repostory)
        {
            this.repostory = repostory;
        }

        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            var student = this.repostory.GetStudentById(studentId);
            return student.ListMarks();
        }
    }
}
