namespace System.Windows.Forms
{
    public class DefaultBindingPropertyAttribute : Attribute
    {
        private string v;

        public DefaultBindingPropertyAttribute(string v)
        {
            this.v = v;
        }
    }
}