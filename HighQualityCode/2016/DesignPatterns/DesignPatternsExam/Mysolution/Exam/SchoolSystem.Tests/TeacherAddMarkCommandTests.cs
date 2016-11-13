using Moq;
using NUnit.Framework;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Factories;
using SchoolSystem.Framework.Core.Repositories.Contracts;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;
using System;
using System.Collections.Generic;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class TeacherAddMarkCommandTests
    {
        [Test]
        public void ExecuteShouldCall_Repository_GetStudentById()
        {
            IList<string> parameters = new List<string>()
            {
                "1",
                "1",
                "4"
            };

            var mockedRepository = new Mock<IRepository>();
            var mockedMarkedFactory = new Mock<IMarkFactory>();

            var student = new Student("Name", "Name", Grade.Eighth);
            var teacher = new Teacher("Name", "Name", Subject.Bulgarian, mockedMarkedFactory.Object);
            mockedRepository.Setup(x => x.GetStudentById(It.IsAny<int>())).Returns(student);
            mockedRepository.Setup(x => x.GetTeacherById(It.IsAny<int>())).Returns(teacher);

            var teacherAddMarkCommand = new TeacherAddMarkCommand(mockedRepository.Object);
            teacherAddMarkCommand.Execute(parameters);

            mockedRepository.Verify(r => r.GetStudentById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void ExecuteShouldCall_Repository_GetTeacherById()
        {
            IList<string> parameters = new List<string>()
            {
                "1",
                "1",
                "4"
            };

            var mockedRepository = new Mock<IRepository>();
            var mockedMarkedFactory = new Mock<IMarkFactory>();

            var student = new Student("Name", "Name", Grade.Eighth);
            var teacher = new Teacher("Name", "Name", Subject.Bulgarian, mockedMarkedFactory.Object);
            mockedRepository.Setup(x => x.GetStudentById(It.IsAny<int>())).Returns(student);
            mockedRepository.Setup(x => x.GetTeacherById(It.IsAny<int>())).Returns(teacher);

            var teacherAddMarkCommand = new TeacherAddMarkCommand(mockedRepository.Object);
            teacherAddMarkCommand.Execute(parameters);

            mockedRepository.Verify(r => r.GetTeacherById(It.IsAny<int>()), Times.Once);
        }

        [Test]
        public void ExecuteShouldCall_Teacher_AddMark()
        {
            IList<string> parameters = new List<string>()
            {
                "1",
                "1",
                "4"
            };

            var name = "Dow";
            var mockedRepository = new Mock<IRepository>();
            var mockedMarkedFactory = new Mock<IMarkFactory>();
            var mockedTeacher = new Mock<ITeacher>();
            var student = new Student("Nmae", "Name", Grade.Fifth);

            mockedTeacher.Setup(x => x.FirstName).Returns(name);
            mockedTeacher.Setup(x => x.LastName).Returns(name);
            mockedTeacher.Setup(x => x.AddMark(It.IsAny<Student>(), It.IsAny<float>())).Verifiable();

            mockedRepository.Setup(x => x.GetStudentById(It.IsAny<int>())).Returns(student);
            mockedRepository.Setup(x => x.GetTeacherById(It.IsAny<int>())).Returns(mockedTeacher.Object);

            var teacherAddMarkCommand = new TeacherAddMarkCommand(mockedRepository.Object);
            teacherAddMarkCommand.Execute(parameters);
            mockedTeacher.Verify(r => r.AddMark(It.IsAny<Student>(), It.IsAny<float>()), Times.Once);
        }

        [Test]
        public void TeacherAddMarkCommandShouldThrown_ArgumentNullException_WhenRepostoryIsNull()
        {
            IRepository repository = null;

            Assert.Throws<ArgumentNullException>(() => new TeacherAddMarkCommand(repository));
        }
    }
}
