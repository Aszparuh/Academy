namespace IntergalacticTravel.Tests.ResourceFactory
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ResourceFactoryTests
    {
        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources gold(20) bronze(40) silver(30)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        [TestCase("create resources silver(30) gold(20) bronze(40)")]
        [TestCase("create resources bronze(40) gold(20) silver(30)")]
        [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void GetResources_ShouldReturnNewResourcesObject_WithCorrectProperties_OrderOfParametersDoesNotMatter(string command)
        {
            var factory = new ResourcesFactory();
            uint gold = 20;
            uint silver = 30;
            uint bronze = 40;

            var result = factory.GetResources(command);

            Assert.AreEqual(gold, result.GoldCoins);
            Assert.AreEqual(silver, result.SilverCoins);
            Assert.AreEqual(bronze, result.BronzeCoins);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("bronze(40) silver(30) gold(20)")]
        public void GetResources_ShouldThrowInvalidOperationException_WhichContains_CommandString_WhenInvalidCommand(string command)
        {
            var factory = new ResourcesFactory();

            var exception = Assert.Throws<InvalidOperationException>(() => factory.GetResources(command));
            StringAssert.Contains("command", exception.Message);
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_ShouldThrowOverflowException_WhenAmountOverflowUint(string command)
        {
            var factory = new ResourcesFactory();

            Assert.Throws<OverflowException>(() => factory.GetResources(command));
        }
    }
}
