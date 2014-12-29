namespace System.Windows.Forms
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class ProvidePropertyAttribute : Attribute
    {
        private string v1;
        private string v2;

        public ProvidePropertyAttribute(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public ProvidePropertyAttribute(string t, Type v)
        {

        }
    }
}