namespace System.Windows.Forms
{
    public class NotifyParentPropertyAttribute : Attribute
    {
        private bool v;

        public NotifyParentPropertyAttribute(bool v)
        {
            this.v = v;
        }
    }
}