using System;
using System.Runtime.Serialization;

namespace School
{
    [Serializable]
    public class DuplicateStudentUNException : Exception
    {
        public DuplicateStudentUNException()
            : base() { }

        public DuplicateStudentUNException(string message)
            : base(message) { }

        public DuplicateStudentUNException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public DuplicateStudentUNException(string message, Exception innerException)
            : base(message, innerException) { }

        public DuplicateStudentUNException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected DuplicateStudentUNException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
