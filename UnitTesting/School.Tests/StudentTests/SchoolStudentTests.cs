using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace School.Tests
{
    [TestClass]
    public class SchoolSTudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestCorrectFirstNameConventionsWithNumbersForStudent()
        {
            var student = new Student("Gosho76", "Hamburg", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestCorrectFirstNameConventionsWithSpecialCharsForStudent()
        {
            var student = new Student("Gosho@#!", "Hamburg", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullFirstNameForStudent()
        {
            var student = new Student(null, "Hamburg", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestEmptyFirstNameForStudent()
        {
            var student = new Student(string.Empty, "Hamburg", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestCorrectLastNameConventionsWithNumbersForStudent()
        {
            var student = new Student("Hamburg", "Gosho123", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestCorrectLastNameConventionsWithSpecialCharsForStudent()
        {
            var student = new Student("Hamburg", "Gosho@#!", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullLastNameForStudent()
        {
            var student = new Student("Hamburg", null, 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestEmptyLastNameForStudent()
        {
            var student = new Student("Hamburg", string.Empty, 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestUNLessThan10000()
        {
            var student = new Student("Hamburg", "Hamburg", 500);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestUNLessLarger99999()
        {
            var student = new Student("Hamburg", "Hamburg", 100500);
        }

        [TestMethod]
        [ExpectedException(typeof(DuplicateStudentUNException))]
        public void TestAddingStudentsWithSameUN()
        {
            School.ListOfAllStudents.Clear();
            var student = new Student("Hamburg", "Hamburg", 50000);
            var studentTwo = new Student("Billy", "Billy", 50000);
        }

        [TestMethod]
        public void TestIfStudentsAreAddedCorrectlyInSchoolList()
        {
            School.ListOfAllStudents.Clear();
            var student = new Student("Hamburg", "Hamburg", 50000);
            var studentTwo = new Student("Gosho", "Gosho", 50001);

            Assert.AreEqual(2, School.ListOfAllStudents.Count);
        }
    }
}
