namespace System.Windows.Forms
{
    public class ListBindableAttribute : Attribute
    {
        private bool v;

        public ListBindableAttribute(bool v)
        {
            this.v = v;
        }
    }
}