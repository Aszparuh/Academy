namespace Cosmetics.Tests
{
    using System;
    using Common;
    using NUnit.Framework;
    using Ploeh.AutoFixture;
    using Products;

    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void CheckIfNullShould_Throw_NullReferenceException_WhenTheParameterObjIsNull()
        {
           object obj = null;

           Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(obj, string.Empty));
        }

        [Test]
        public void CheckIfNullShould_Throw_NullReferenceException_WhenTheParameterObjIsNotNull()
        {
            var fixture = new Fixture();
            var str = fixture.Create<string>();

            Assert.DoesNotThrow(() => Validator.CheckIfNull(str, string.Empty));
        }

        [TestCase(null)]
        [TestCase("")]
        public void CheckIfStringIsNullOrEmpty_Should_ThrowNullReferenceException_WhenTheParameterTextIsNullOrEmpty(string text)
        {
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(text));
        }

        [Test]
        public void CheckIfStringIsNullOrEmpty_Should_ThrowNullReferenceException_WhenTheParameterTextIsNotNullOrEmpty()
        {
            var fixture = new Fixture();
            var str = fixture.Create<string>();

            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty(str));
        }

        [TestCase("two--")]
        [TestCase("a")]
        public void CheckIfStringLengthIsValid_Should_ThrowIndexOutOfRangeException_WhenTheLengthOfTheParameterTextIsLowerOrGreaterThanAllowed(string text)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(text, 3, 2));
        }

        [TestCase("two")]
        [TestCase("aa")]
        public void CheckIfStringLengthIsValid_ShouldNot_ThrowAnyException_WhenTheLengthOfTheParameterTextIsLowerOrGreaterThanAllowed(string text)
        {
            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(text, 3, 2));
        }
    }
}
