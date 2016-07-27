namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void InitializingStudentWithCorrectData_ShouldNotThrowException()
        {
            var student = new Student("John Dow");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingStudentWithNullName_ShouldThrowException()
        {
            string name = null;
            var student = new Student(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingStudentWithWhiteSpaceName_ShouldThrowException()
        {
            string name = "   ";
            var student = new Student(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingStudentWithEmptyStringName_ShouldThrowException()
        {
            string name = string.Empty;
            var student = new Student(name);
        }

        [TestMethod]
        public void StudentMustHaveUniqueIds()
        {
            var firstStudent = new Student("Pesho");
            var secondStudent = new Student("Gosho");

            Assert.AreNotEqual(firstStudent.Id, secondStudent.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ReachingMaximumStudents_ShouldThrowException()
        {
            for (int i = 0; i < 90002; i++)
            {
                var student = new Student("Name " + i.ToString());
            }
        }
    }
}
