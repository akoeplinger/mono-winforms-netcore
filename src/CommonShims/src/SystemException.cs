using System.Runtime.Serialization;

namespace System
{
    public class SystemException : Exception
    {
        public SystemException()
            : base()
        {
        }

        public SystemException(String message)
            : base(message)
        {
        }

        public SystemException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected SystemException(SerializationInfo info, StreamingContext context)
        {
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }
    }
}