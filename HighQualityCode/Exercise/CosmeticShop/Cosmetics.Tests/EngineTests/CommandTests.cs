namespace Cosmetics.Tests.EngineTests
{
    using System;
    using System.Collections.Generic;
    using Cosmetics.Engine;
    using NUnit.Framework;

    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void Parse_ShouldReturnNewCommandWhen_TheInputStringIsInTheRequiredValidFormat()
        {
            var str = "CreateToothpaste White+ Colgate 15.50 men fluor,bqla,golqma";
            var command = Command.Parse(str);

            Assert.IsInstanceOf<Command>(command);
        }

        [Test]
        public void Parse_ShouldSetSorrectValues_ToNameOfTheNewlyReturnedCommand()
        {
            var str = "CreateToothpaste White+ Colgate 15.50 men fluor,bqla,golqma";
            var command = Command.Parse(str);
            var expectedName = "CreateToothpaste";

            Assert.AreEqual(expectedName, command.Name);
        }

        [Test]
        public void Parse_ShouldSetSorrectValues_ToParametersOfTheNewlyReturnedCommand()
        {
            var str = "CreateToothpaste White+ Colgate 15.50 men fluor bqla golqma";
            var command = Command.Parse(str);
            var expectedParameters = new List<string>() { "White+", "Colgate", "15.50", "men", "fluor", "bqla", "golqma" };

            CollectionAssert.AreEqual(expectedParameters, command.Parameters);
        }

        [Test]
        public void Parse_ShouldThrowNullReferenceException_WhenTheInputsStringIsNull()
        {
            string str = null;

            Assert.Throws<NullReferenceException>(() => Command.Parse(str));
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullExceptionWithAMessageThatContainsTheStringName_WhenTheInputStringThatRepresentsTheCommandNamesIsNullOrEmpty()
        {
            string str = " White Colgate";

            Assert.That(() => Command.Parse(str), Throws.ArgumentNullException.With.Message.Contain("Name"));
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullExceptionWithAMessageThatContainsTheStringList_WhenTheInputStringThatRepresentsTheCommandNamesIsNullOrEmpty()
        {
            string str = "White  ";

            Assert.That(() => Command.Parse(str), Throws.ArgumentNullException.With.Message.Contain("List"));
        }
    }
}
