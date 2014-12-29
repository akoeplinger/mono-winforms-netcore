namespace System.Windows.Forms
{
    internal class InitializationEventAttribute : Attribute
    {
        private string v;

        public InitializationEventAttribute(string v)
        {
            this.v = v;
        }
    }
}