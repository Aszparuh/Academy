namespace Cosmetics.Tests.EngineTests
{
    using System;
    using Common;
    using Contracts;
    using Engine;
    using NUnit.Framework;

    [TestFixture]
    public class CosmeticFactoryTests
    {
        [TestCase(null)]
        [TestCase("")]
        public void CreateShampoo_ShouldThrowNullReferenceException_WhenNameIsNullOrEmpty(string name)
        {
            var factory = new CosmeticsFactory();

            Assert.Throws<NullReferenceException>(() => factory.CreateShampoo(name, "brand", 5M, GenderType.Unisex, 100, UsageType.EveryDay));
        }

        [TestCase("aa")]
        [TestCase("aaaaaaaaaaa")]
        public void CreateShampoo_ShouldThrowIndexOutOfRangeException_WhenNameIsLongerThanExpectedOrShorter(string name)
        {
            var factory = new CosmeticsFactory();

            Assert.Throws<IndexOutOfRangeException>(() => factory.CreateShampoo(name, "brand", 5M, GenderType.Unisex, 100, UsageType.EveryDay));
        }

        [TestCase(null)]
        [TestCase("")]
        public void CreateShampoo_ShouldThrowNullReferenceException_WhenBrandIsNullOrEmpty(string brand)
        {
            var factory = new CosmeticsFactory();

            Assert.Throws<NullReferenceException>(() => factory.CreateShampoo("somename", brand, 5M, GenderType.Unisex, 100, UsageType.EveryDay));
        }

        [TestCase("a")]
        [TestCase("aaaaaaaaaaa")]
        public void CreateShampoo_ShouldThrowIndexOutOfRangeException_WhenBrandIsLongerThanExpectedOrShorter(string brand)
        {
            var factory = new CosmeticsFactory();

            Assert.Throws<IndexOutOfRangeException>(() => factory.CreateShampoo("name", brand, 5M, GenderType.Unisex, 100, UsageType.EveryDay));
        }

        [Test]
        public void CreateShampoo_ShouldReturnNewShampoo_WhenPassedParametersAreAllValid()
        {
            var factory = new CosmeticsFactory();

            var result = factory.CreateShampoo("name", "brand", 5M, GenderType.Unisex, 100, UsageType.EveryDay);

            Assert.IsInstanceOf<IShampoo>(result);
        }

        [TestCase(null)]
        [TestCase("")]
        public void CreateCategory_ShouldThrowNullReferenceException_WhenNameIsNullOrEmpty(string name)
        {
            var factory = new CosmeticsFactory();

            Assert.Throws<NullReferenceException>(() => factory.CreateCategory(name));
        }
    }
}
