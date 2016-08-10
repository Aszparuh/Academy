namespace IntergalacticTravel.Tests.UnitFactory
{
    using Exceptions;
    using NUnit.Framework;

    [TestFixture]
    public class UnitFactoryTests
    {
        [Test]
        public void GetUnit_ShouldReturnNewProcyonUnit_WhenValidCorrespondingCommandIsPassed()
        {
            var factory = new UnitsFactory();
            var command = "create unit Procyon Gosho 1";

            var unit = factory.GetUnit(command);

            Assert.IsInstanceOf<Procyon>(unit);
        }

        [Test]
        public void GetUnit_ShouldReturnNewLuytenUnit_WhenValidCorrespondingCommandIsPassed()
        {
            var factory = new UnitsFactory();
            var command = "create unit Luyten Pesho 2";

            var unit = factory.GetUnit(command);

            Assert.IsInstanceOf<Luyten>(unit);
        }

        [Test]
        public void GetUnit_ShouldReturnNewLacailleUnit_WhenValidCorrespondingCommandIsPassed()
        {
            var factory = new UnitsFactory();
            var command = "create unit Lacaille Tosho 3";

            var unit = factory.GetUnit(command);

            Assert.IsInstanceOf<Lacaille>(unit);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("aaaa")]
        [TestCase("create unit lacaille Tosho 3")]
        public void GetUnit_ShouldThrowInvalidUnitCreationCommandException_WhenTheCommandPassedIsNotInTheValidFormat(string command)
        {
            var factory = new UnitsFactory();

            Assert.Throws<InvalidUnitCreationCommandException>(() => factory.GetUnit(command));
        }
    }
}
