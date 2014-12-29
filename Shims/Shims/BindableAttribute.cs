namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class BindableAttribute : Attribute
    {
        private BindableSupport yes;

        public BindableAttribute(BindableSupport yes)
        {
            this.yes = yes;
        }

        public BindableAttribute(bool v)
        {
        }
        public BindableAttribute(bool v, BindingDirection s)
        {
        }
    }
}