using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace School.Tests.CourseTests
{
    [TestClass]
    public class SchoolCourseTests
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestCorrectNameConventionsWithNumbersCourse()
        {
            var course = new Course("Cosho123");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestCorrectNameConventionsWithSpecialCharsCourse()
        {
            var course = new Course("Gosho@#!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullNameCourse()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestEmptyNameCourse()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void TestAddingStudents()
        {
            School.ListOfAllStudents.Clear();
            var course = new Course("Hard Rock Aleluya");

            for (int i = 0; i < 5; i++)
            {
                course.JoinCourse(new Student("Hamburg", "Ham", 10001 + i));
            }

            Assert.AreEqual(5, course.ListOfStudents.Count);
        }

        [TestMethod]
        public void TestRemovingStudents()
        {
            School.ListOfAllStudents.Clear();
            var course = new Course("ALALLALALL");
            var student = new Student("LALA", "LALA", 10001);

            course.JoinCourse(student);
            course.LeaveCourse(student);

            Assert.AreEqual(0, course.ListOfStudents.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestAddingMoreThan30Students()
        {
            School.ListOfAllStudents.Clear();
            var course = new Course("hah");

            for (int i = 0; i < 32; i++)
            {
                course.JoinCourse(new Student("Lala", "Lala", 10001 + i));
            }
        }
    }
}
