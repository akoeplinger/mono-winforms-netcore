using System;

namespace System.IO
{
    public class InternalBufferOverflowException : SystemException
    {
        public InternalBufferOverflowException(string message) : base(message)
        {
        }
    }
}