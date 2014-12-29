namespace System.Windows.Forms
{
    [Serializable]
    internal class EntryPointNotFoundException : Exception
    {
        public EntryPointNotFoundException()
        {
        }

        public EntryPointNotFoundException(string message) : base(message)
        {
        }

        public EntryPointNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}