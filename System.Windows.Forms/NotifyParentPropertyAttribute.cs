namespace System.Windows.Forms
{
    internal class NotifyParentPropertyAttribute : Attribute
    {
        private bool v;

        public NotifyParentPropertyAttribute(bool v)
        {
            this.v = v;
        }
    }
}