using NUnit.Framework;
using SchoolSystem.Logic;
using System;
using System.Collections.Generic;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class TeacherTests
    {
        [Test]
        public void Teacher_WithFirstName_WithLessThanTwoSymbols_ShouldThrowArgumentException()
        {
            var name = "a";
            var validLastName = "aaaaaa";

            Assert.Throws<ArgumentException>(() => new Teacher(name, validLastName, Subject.Bulgarian));
        }

        [Test]
        public void Teacher_WithLastName_WithLessThanTwoSymbols_ShouldThrowArgumentException()
        {
            var validFirstName = "aaaaaa";
            var lastName = "a";

            Assert.Throws<ArgumentException>(() => new Teacher(validFirstName, lastName, Subject.Bulgarian));
        }

        [Test]
        public void Teacher_WithFirstName_WithMoreThan31Symbols_ShouldThrowArgumentException()
        {
            var validFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            var lastName = "aaaaaa";

            Assert.Throws<ArgumentException>(() => new Teacher(validFirstName, lastName, Subject.Bulgarian));
        }

        [Test]
        public void Teacher_ShouldAddMarks_Correctrly()
        {
            var teacher = new Teacher("Test", "Test", Subject.Math);
            var studentMarks = new List<Mark>();
            var student = new Student("Test", "Test", Grade.Eighth, studentMarks);

            teacher.AddMark(student, 4f);

            Assert.AreEqual(1, studentMarks.Count);
        }
    }
}
