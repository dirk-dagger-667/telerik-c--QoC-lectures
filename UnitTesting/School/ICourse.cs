using System.Collections.Generic;

namespace School
{
    public interface ICourse
    {
        string Name { get; }
        IList<IStudent> ListOfStudents { get; }
        void JoinCourse(IStudent student);
        void LeaveCourse(IStudent student);
    }
}
