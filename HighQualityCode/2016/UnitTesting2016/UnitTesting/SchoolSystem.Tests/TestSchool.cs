namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        public void InitializingSchool_ShouldNot_ThorwException()
        {
            var school = new School("Primary school");
        }

        [TestMethod]
        public void School_Should_ReturnCorrectName()
        {
            var name = "Primary school";
            var school = new School(name);

            Assert.AreEqual(school.Name, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingSchoolWhthNullName_Should_ThrowException()
        {
            string name = null;
            var school = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolShouldThrowExceptionWhenNameIsEmpty()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void SchoolShouldAddCourseCorrectly()
        {
            var school = new School("Some school");
            var course = new Course("Math");
            school.AddCourse(course);

            Assert.AreSame(course, school.Courses.FirstOrDefault());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowException_WhenSameCourseIsAdded()
        {
            var school = new School("Some school");
            var course = new Course("Math");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNullCourseAdded()
        {
            var school = new School("Some school");
            Course course = null;
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowException_WhenNullCourseRemoved()
        {
            var school = new School("Some school");
            Course course = null;
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowException_WhenTryingToRemoveCourseThatIsNotAdded()
        {
            var school = new School("Some school");
            Course course = new Course("Math");
            school.RemoveCourse(course);
        }

        [TestMethod]
        public void SchoolShouldCorrectly_RemoveCourse()
        {
            var school = new School("Some school");
            Course course = new Course("Math");
            school.AddCourse(course);
            school.RemoveCourse(course);

            Assert.AreEqual(false, school.Courses.Contains(course));
        }
    }
}
