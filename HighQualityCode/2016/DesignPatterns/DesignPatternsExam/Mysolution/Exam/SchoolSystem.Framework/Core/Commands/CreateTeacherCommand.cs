using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Core.Factories;
using System;
using SchoolSystem.Framework.Core.Repositories.Contracts;
using SchoolSystem.Framework.Core.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateTeacherCommand : ICommand
    {
        private readonly ITeacherFactory factory;
        private readonly IRepository repostory;
        private readonly ITeacherIdProvider idProvider;

        public CreateTeacherCommand(ITeacherFactory factory, IRepository repostory, ITeacherIdProvider idProvider)
        {
            if (factory == null)
            {
                throw new ArgumentNullException("Teacher factory is null");
            }

            if (repostory == null)
            {
                throw new ArgumentNullException("Teacher repository is null");
            }

            this.factory = factory;
            this.repostory = repostory;
            this.idProvider = idProvider;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var subject = (Subject)int.Parse(parameters[2]);

            var teacher = this.factory.CreateTeacher(firstName, lastName, subject);
            var id = this.idProvider.GetNextId();
            this.repostory.AddTeacher(id, teacher);

            return $"A new teacher with name {firstName} {lastName}, subject {subject} and ID {id} was created.";
        }
    }
}
