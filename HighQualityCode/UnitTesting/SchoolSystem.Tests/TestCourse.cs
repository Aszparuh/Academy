namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EnrollingNullStudent_ShouldThrowException()
        {
            Student student = null;
            var course = new Course("Math");

            course.EnrollStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EnrollingMoreThanMaxStudents_ShouldThrowException()
        {
            var course = new Course("Math");

            for (int i = 0; i < 31; i++)
            {
                course.EnrollStudent(new Student("Test" + i.ToString()));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EnrollingOneStudentTwice_ShouldThrowException()
        {
            var student = new Student("John Dow");
            var course = new Course("Math");

            course.EnrollStudent(student);
            course.EnrollStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DismissingNullStudent_ShouldThrowException()
        {
            Student student = null;
            var course = new Course("Math");

            course.DismissSudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DismissingStudentFormEmptyCourse_ShouldThrowException()
        {
            Student student = new Student("John Dow");
            var course = new Course("Math");

            course.DismissSudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DismissingStudentWhoIsNotEnrolled_ShouldThrowException()
        {
            Student student = new Student("John Dow");
            Student secondStudent = new Student("Jane Dow");
            var course = new Course("Math");

            course.EnrollStudent(student);
            course.DismissSudent(secondStudent);
        }

        [TestMethod]
        public void DismissingStudent()
        {
            Student student = new Student("John Dow");
            var course = new Course("Math");

            course.EnrollStudent(student);
            course.DismissSudent(student);

            Assert.AreEqual(true, !course.EnrolledStudents.Contains(student));
        }

        [TestMethod]
        public void NameReturns_CorrectName()
        {
            var name = "Math";
            var course = new Course(name);

            Assert.AreEqual(name, course.Name);
        }
    }
}
