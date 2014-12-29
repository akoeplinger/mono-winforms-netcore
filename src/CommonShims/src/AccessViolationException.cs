using System;

namespace System
{
    public class AccessViolationException : SystemException
    {
        public AccessViolationException(string message) : base(message)
        {
        }
    }
}