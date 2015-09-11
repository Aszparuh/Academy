namespace SchoolTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void InitializingStudentWithCorrectDataShouldNotThrowException()
        {
            var student = new Student("John Dow");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingStudentWithNullNameShouldThrowException()
        {
            var student = new Student(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingStudentWithWhiteSpaceNameShouldThrowException()
        {
            var student = new Student("   ");
        }

        [TestMethod]
        public void StudentMustHaveUniqueIds()
        {
            var firstStudent = new Student("Pesho");
            var secondStudent = new Student("Gosho");
            
            Assert.AreNotEqual(firstStudent.Id, secondStudent.Id, "Student Ids are same");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ReachingMaximumStudentsShouldThrowException()
        {
            for (int i = 0; i < 90002; i++)
            {
                var student = new Student("Name " + i.ToString());
            }

            IdGenerator.Restart();
        }
    }
}
