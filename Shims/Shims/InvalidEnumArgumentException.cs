using System;

namespace System.ComponentModel
{
    [Serializable]
    public class InvalidEnumArgumentException : Exception
    {
        public InvalidEnumArgumentException()
        {
        }

        public InvalidEnumArgumentException(string message) : base(message)
        {
        }

        public InvalidEnumArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass)
        {
        }
    }
}