namespace System.Windows.Forms
{
    internal class ListBindableAttribute : Attribute
    {
        private bool v;

        public ListBindableAttribute(bool v)
        {
            this.v = v;
        }
    }
}