namespace SchoolTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    class TestSchool
    {
        [TestClass]
        public class SchoolTest
        {
            [TestMethod]
            public void SchoolShouldNotThrowException()
            {
                var school = new School("Test school");
            }

            [TestMethod]
            public void SchoolShouldReturnNameCorrectly()
            {
                var school = new School("Test school");
                Assert.AreEqual("Test school", school.Name);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void SchoolShouldThrowExceptionWhenNameIsNull()
            {
                var school = new School(null);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void SchoolShouldThrowExceptionWhenNameIsEmpty()
            {
                var school = new School(string.Empty);
            }

            [TestMethod]
            public void SchoolShouldAddStudentCorrectly()
            {
                var school = new School("Test school");
                var student = new Student("Test student");
                school.AddStudent(student);
                Assert.AreSame(student, school.Students[0]);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void SchoolShouldThrowExceptionWhenNullStudentAdded()
            {
                var school = new School("Test school");
                Student student = null;
                school.AddStudent(student);
            }

            [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]
            public void SchoolShouldThrowExceptionWhenAddingExistingStudent()
            {
                var school = new School("Test school");
                var student = new Student("Test student");
                school.AddStudent(student);
                school.AddStudent(student);
            }

            [TestMethod]
            public void SchoolShouldAddCourseCorrectly()
        {
            var school = new School("Test school");
            var course = new Course("Test course");
            school.AddCourse(course);
            Assert.AreSame(course, school.Courses[0]);
        }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void SchoolShouldThrowExceptionWhenNullCourseAdded()
            {
                var school = new School("Test school");
                Course course = null;
                school.AddCourse(course);
            }

            [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]
            public void SchoolShouldThrowExceptionWhenExistingCourseAdded()
            {
                var school = new School("Test school");
                var course = new Course("Test course");
                school.AddCourse(course);
                school.AddCourse(course);
            }

            [TestMethod]
            public void SchoolShouldRemoveStudentCorrectly()
            {
                var school = new School("Test school");
                var student = new Student("Test student");
                school.AddStudent(student);
                school.RemoveStudent(student);
                Assert.IsTrue(school.Students.Count == 0);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void SchoolShouldThrowExceptionWhenRemovingNullStudent()
            {
                var school = new School("Test school");
                Student student = null;
                school.RemoveStudent(student);
            }

            [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]
            public void SchoolShouldThrowExceptionWhenRemovingNotExistingStudent()
            {
                var school = new School("Test school");
                var student = new Student("Test student");
                school.RemoveStudent(student);
            }

            [TestMethod]
            public void SchoolShouldRemoveCourseCorrectly()
            {
                var school = new School("Test school");
                var course = new Course("test course");
                school.AddCourse(course);
                school.RemoveCourse(course);
                Assert.IsTrue(school.Courses.Count == 0);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentNullException))]
            public void SchoolShouldThrowExceptionWhenRemovingNullCourse()
            {
                var school = new School("Test school");
                Course course = null;
                school.RemoveCourse(course);
            }

            [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]
            public void SchoolShouldThrowExceptionWhenRemovingNotExistingCourse()
            {
                var school = new School("Test school");
                var course = new Course("Test course");
                school.RemoveCourse(course);
            }
        }
    }
}