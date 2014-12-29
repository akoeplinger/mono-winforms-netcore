namespace System.Runtime.InteropServices
{
    public class ExternalException : SystemException
    {
        public ExternalException(string message) : base(message)
        {
        }

        public ExternalException(string message, int e) : this(message)
        {
        }
    }
}