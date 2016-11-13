using Moq;
using NUnit.Framework;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class RemoveStudentCommandTests
    {
        [Test]
        public void ExecuteShouldCall_Repository_RemoveStudent()
        {
            IList<string> parameters = new List<string>()
            {
                "0"
            };

            var mockedRepository = new Mock<IRepository>();

            var removeStudentCommand = new RemoveStudentCommand(mockedRepository.Object);
            removeStudentCommand.Execute(parameters);

            mockedRepository.Verify(r => r.RemoveStudent(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void RemoveStudentCommandShouldThrown_ArgumentNullException_WhenRepostoryIsNull()
        {
            IRepository repository = null;

            Assert.Throws<ArgumentNullException>(() => new RemoveStudentCommand(repository));
        }
    }
}
