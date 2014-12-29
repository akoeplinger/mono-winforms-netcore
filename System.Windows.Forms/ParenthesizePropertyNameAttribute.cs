namespace System.Windows.Forms
{
    internal class ParenthesizePropertyNameAttribute : Attribute
    {
        private bool v;

        public ParenthesizePropertyNameAttribute(bool v)
        {
            this.v = v;
        }

        public bool NeedParenthesis { get; internal set; }
    }
}