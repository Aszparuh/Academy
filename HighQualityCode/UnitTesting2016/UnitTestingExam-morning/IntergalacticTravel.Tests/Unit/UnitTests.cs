namespace IntergalacticTravel.Tests.Unit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using IntergalacticTravel;
    using NUnit.Framework;

    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_ShouldThrowNullReferenceException_WhenThePassedObjectIsNull()
        {
            var unit = new Unit(1, "test");

            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }

        [Test]
        public void Pay_ShouldDecreaseTheOwnerAmountOfResourcesByTheAmountOfTheCost()
        {
            var unit = new Unit(1, "test");

            unit.Resources.Add(new Resources(5, 5, 5));
            unit.Resources.Add(new Resources(5, 5, 5));

            unit.Pay(new Resources(5, 5, 5));

            Assert.AreEqual(unit.Resources.BronzeCoins, 5);
            Assert.AreEqual(unit.Resources.SilverCoins, 5);
            Assert.AreEqual(unit.Resources.GoldCoins, 5);
        }

        [Test]
        public void Pay_ShouldReturnNewCosResource()
        {
            var unit = new Unit(1, "test");

            unit.Resources.Add(new Resources(5, 5, 5));
            unit.Resources.Add(new Resources(5, 5, 5));

            var cost = unit.Pay(new Resources(5, 5, 5));

            Assert.IsInstanceOf<IResources>(cost);
        }
    }
}
