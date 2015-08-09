namespace SchoolTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void InitializingCourseWithCorrectDataShouldNotThrowException()
        {
            var course = new Course("Math");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingCourseWithNullNameShouldThrowException()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InitializingCourseWithEmptyNameShouldThrowException()
        {
            var course = new Course("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullStudentShouldThrowException()
        {
            var course = new Course("Test");
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingSameStudentShouldThrowException()
        {
            var course = new Course("Test");
            var student = new Student("Anton");

            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingMoreThanMaximumStudentsShouldThrowException()
        {
            var course = new Course("Test");

            for (int i = 0; i < 32; i++)
            {
                string name = "Student Name" + i.ToString();
                var newStudent = new Student(name);
                course.AddStudent(newStudent);
            }
        }

        [TestMethod]
        public void CorrectlyAddingOneStudent()
        {
            var course = new Course("Test");
            var student = new Student("Test Student");

            course.AddStudent(student);

            Assert.AreSame(student, course.Students[0], "Students are not the same");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveNullStudentShouldThrowException()
        {
            var course = new Course("Test");
            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveMissingStudentShouldThrowException()
        {
            var course = new Course("test");
            var student = new Student("Test Student");

            course.RemoveStudent(student);
        }

        [TestMethod]
        public void CorrectlyRemovingStudent()
        {
            var course = new Course("Test");
            var student = new Student("Test Student");

            course.AddStudent(student);
            Assert.AreEqual(1, course.Students.Count, "Student cannot be added");

            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count, "Student cannot be removed" );
        }

        [TestMethod]
        public void CourseReturnsCorrectName()
        {
            string courseName = "Some strange name";
            var course = new Course(courseName);

            Assert.AreEqual(courseName, course.Name, "Course returns wrong name");
        }
    }
}