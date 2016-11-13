using Moq;
using NUnit.Framework;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Factories;
using SchoolSystem.Framework.Core.Repositories.Contracts;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using System;
using System.Collections.Generic;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class CreateStudentCommandTests
    {
        [Test]
        public void ExecuteShouldCall_FactoryCreateStudent()
        {
            IList<string> parameters = new List<string>()
            {
                "Pesho",
                "Peshev",
                "11"
            };
            
            var mockedFactory = new Mock<IStudentFactory>();
            var mockedRepository = new Mock<IRepository>();
            var mockedIdProvider = new Mock<IStudentIdProvider>();

            var createStudentCommand = new CreateStudentCommand(mockedFactory.Object, mockedRepository.Object, mockedIdProvider.Object);
            createStudentCommand.Execute(parameters);

            mockedFactory.Verify(f => f.CreateStudent(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Grade>()), Times.Once);
        }

        [Test]
        public void ExecuteShouldCall_IdProvider_GetNextId()
        {
            IList<string> parameters = new List<string>()
            {
                "Pesho",
                "Peshev",
                "11"
            };

            var mockedFactory = new Mock<IStudentFactory>();
            var mockedRepository = new Mock<IRepository>();
            var mockedIdProvider = new Mock<IStudentIdProvider>();

            var createStudentCommand = new CreateStudentCommand(mockedFactory.Object, mockedRepository.Object, mockedIdProvider.Object);
            createStudentCommand.Execute(parameters);

            mockedIdProvider.Verify(f => f.GetNextId(), Times.Once);
        }

        [Test]
        public void ExecuteShouldCall_Repository_AddStudent()
        {
            IList<string> parameters = new List<string>()
            {
                "Pesho",
                "Peshev",
                "11"
            };

            var mockedFactory = new Mock<IStudentFactory>();
            var mockedRepository = new Mock<IRepository>();
            var mockedIdProvider = new Mock<IStudentIdProvider>();

            var createStudentCommand = new CreateStudentCommand(mockedFactory.Object, mockedRepository.Object, mockedIdProvider.Object);
            createStudentCommand.Execute(parameters);

            mockedRepository.Verify(r => r.AddStudent(It.IsAny<int>(), It.IsAny<IStudent>()), Times.Once);
        }

        [Test]
        public void CreateStudentCommandShoultThrow_ArgumentNullException_When_FactoryIsNull()
        {
            IStudentFactory factory = null;
            var mockedRepository = new Mock<IRepository>();
            var mockedIdProvider = new Mock<IStudentIdProvider>();

            Assert.Throws<ArgumentNullException>(() => new CreateStudentCommand(factory, mockedRepository.Object, mockedIdProvider.Object));
        }

        [Test]
        public void CreateStudentCommandShoultThrow_ArgumentNullException_When_RepositoryIsNull()
        {
            var mockedFactory = new Mock<IStudentFactory>();
            IRepository repository = null;
            var mockedIdProvider = new Mock<IStudentIdProvider>();

            Assert.Throws<ArgumentNullException>(() => new CreateStudentCommand(mockedFactory.Object, repository, mockedIdProvider.Object));
        }

        [Test]
        public void CreateStudentCommandShoultThrow_ArgumentNullException_When_IdProviderIsNull()
        {
            var mockedFactory = new Mock<IStudentFactory>();
            var mockedRepository = new Mock<IRepository>();
            IStudentIdProvider idProvider = null;

            Assert.Throws<ArgumentNullException>(() => new CreateStudentCommand(mockedFactory.Object, mockedRepository.Object, idProvider));
        }
    }
}
