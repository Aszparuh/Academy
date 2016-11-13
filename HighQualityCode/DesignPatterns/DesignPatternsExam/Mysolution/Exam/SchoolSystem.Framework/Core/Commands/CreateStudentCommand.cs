using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Core.Factories;
using System;
using SchoolSystem.Framework.Core.Repositories.Contracts;
using SchoolSystem.Framework.Core.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateStudentCommand : ICommand
    {
        private readonly IStudentFactory factory;
        private readonly IRepository repository;
        private readonly IStudentIdProvider idProvider;

        public CreateStudentCommand(IStudentFactory factory, IRepository repository, IStudentIdProvider idProvider)
        {
            if (factory == null)
            {
                throw new ArgumentNullException("Null student factory");
            }

            if (repository == null)
            {
                throw new ArgumentNullException("Null student repository");
            }

            if (idProvider == null)
            {
                throw new ArgumentNullException("Null student id provider");
            }

            this.factory = factory;
            this.repository = repository;
            this.idProvider = idProvider;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            var student = this.factory.CreateStudent(firstName, lastName, grade);
            var id = idProvider.GetNextId();
            this.repository.AddStudent(id, student);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {id} was created.";
        }
    }
}
