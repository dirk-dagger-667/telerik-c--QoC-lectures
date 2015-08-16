using System;
using System.Text.RegularExpressions;

namespace School
{
    public class Student : IStudent
    {
        public string regexForNameChecking = @"^[\p{L} \.\-]+$";

        private string firstName;
        private string lastName;
        private int uniqueNumber;

        public Student(string firstName, string lastName, int uniqueNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UniqueNumber = uniqueNumber;

            if (School.StudentPresentInList(this))
            {
                throw new DuplicateStudentUNException("the school has two defferent students with the same unique number!");
            }

            School.ListOfAllStudents.Add(this);
        }

        public string FirstName
        {
            get
            {
                return String.Copy(this.firstName);
            }
            set
            {
                if (!Regex.IsMatch(value, regexForNameChecking))
                {
                    throw new FormatException("the first name can contain only letters and the '.', ' ', ''', '-' symbols");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return String.Copy(this.lastName);
            }
            set
            {
                if (!Regex.IsMatch(value, regexForNameChecking))
                {
                    throw new FormatException("the last name can contain only letters and the '.', ' ', ''', '-' symbols");
                }
                else if (value == null || value == string.Empty)
                {
                    throw new NullReferenceException("the last name of a student cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("the unique number cannot be a value less than 10000 or more than 99999");
                }

                this.uniqueNumber = value;
            }
        }
    }
}
