using NUnit.Framework;
using SchoolSystem.Logic;
using System;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class MarkTests
    {
        [Test]
        public void MarkShouldThrowArgumentExceptionWhenValueIsLessThanTwo()
        {
            var value = 1f;

            Assert.Throws<ArgumentException>(() => new Mark(Subject.Bulgarian, value));
        }

        [Test]
        public void MarkShouldThrowArgumentExceptionWhenValueIsGreaterThanSix()
        {
            var value = 6.1f;

            Assert.Throws<ArgumentException>(() => new Mark(Subject.Bulgarian, value));
        }
    }
}
