namespace System.Windows.Forms
{
    internal class DefaultBindingPropertyAttribute : Attribute
    {
        private string v;

        public DefaultBindingPropertyAttribute(string v)
        {
            this.v = v;
        }
    }
}