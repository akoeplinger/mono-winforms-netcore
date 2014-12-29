namespace System.Windows.Forms
{
    public class InitializationEventAttribute : Attribute
    {
        private string v;

        public InitializationEventAttribute(string v)
        {
            this.v = v;
        }
    }
}