using Moq;
using NUnit.Framework;
using SchoolSystem.Logic;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class EngineTests
    {
        [Test]
        public void EngineShouldWriteMessageThereIsNoShuchCommand()
        {
            var someUnknownCommand = "Write Fs";
            var mockedReader = new Mock<IReader>();
            mockedReader.Setup(m => m.ReadLine()).Returns(someUnknownCommand).Callback(() => mockedReader.Setup(m => m.ReadLine()).Returns("End"));
            var mockedWriter = new Mock<IWriter>();
            var engine = new Engine(mockedReader.Object, mockedWriter.Object);

            engine.Start();
            mockedReader.Setup(m => m.ReadLine()).Returns("End");
            mockedWriter.Verify(w => w.WriteLine(It.Is<string>(s => s == "The passed command is not found!")), Times.Once);
        }
    }
}
