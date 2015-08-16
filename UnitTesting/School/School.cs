using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace School
{
    public static class School
    {
        private static IList<IStudent> listOfAllStudents = new List<IStudent>();

        public static IList<IStudent> ListOfAllStudents
        {
            get
            {
                return listOfAllStudents;
            }
            private set
            {
                listOfAllStudents = value;
            }
        }

        public static bool StudentPresentInList(IStudent studentForChecking)
        {
            return ListOfAllStudents.Any(student => student.UniqueNumber == studentForChecking.UniqueNumber);
        }
    }
}
