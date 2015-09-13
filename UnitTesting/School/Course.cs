//Write three classes: Student, Course and School. Students should have name and unique number (inside the entire School). Name can not be empty and the unique number is between 10000 and 99999. Each course contains a set of students. Students in a course should be less than 30 and can join and leave courses.
//Write VSTT tests for these two classes
//Use 2 class library projects in Visual Studio: School.csproj and TestSchool.csproj
//Execute the tests using Visual Studio and check the code coverage. Ensure it is at least 90%.


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace School
{
    public class Course : ICourse
    {
        public string regexForNameChecking = @"^[\p{L} \.\-]+$";
        public const int MAX_NUMBER_OF_STUDENTS_IN_CLASS = 29;

        private string name;
        private IList<IStudent> listOfStudents;

        public Course(string name)
        {
            this.Name = name;
            this.ListOfStudents = new List<IStudent>();
        }

        public string Name
        {
            get
            {
                return String.Copy(this.name);
            }
            private set
            {
                if (!Regex.IsMatch(value, regexForNameChecking))
                {
                    throw new FormatException("the name of the course can contain only letters and the '.', ' ', ''', '-' symbols");
                }
                else if (value == null || value == string.Empty)
                {
                    throw new NullReferenceException("the name of the course cannot be null or empty");
                }

                this.name = value;
            }
        }

        public IList<IStudent> ListOfStudents
        {
            get
            {
                return DeepCopyOfList();
            }
            private set
            {
                this.listOfStudents = value;
            }
        }

        public void JoinCourse(IStudent student)
        {
            if (this.ListOfStudents.Count > MAX_NUMBER_OF_STUDENTS_IN_CLASS)
            {
                throw new IndexOutOfRangeException(String.Format("the maximum count of students in any one course has reached the limit of {0}", MAX_NUMBER_OF_STUDENTS_IN_CLASS));
            }

            this.listOfStudents.Add(student);
        }

        public void LeaveCourse(IStudent student)
        {
            this.listOfStudents.Remove(student);
        }

        private IList<IStudent> DeepCopyOfList()
        {
            var copyOfList = new List<IStudent>();

            for (int i = 0; i < this.listOfStudents.Count; i++)
            {
                copyOfList.Add(this.listOfStudents[i]);
            }

            return copyOfList;
        }
    }
}
