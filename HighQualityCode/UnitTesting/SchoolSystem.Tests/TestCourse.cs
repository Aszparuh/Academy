namespace SchoolSystem.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void InitializingCourseWithCorrectName_DoesNotThrowException()
        {
            var course = new Course("Math");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingCourseWithNullName_ShouldThrowException()
        {
            string name = null;
            var course = new Course(name);
        }
    }
}
