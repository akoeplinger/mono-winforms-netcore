namespace System.Windows.Forms
{
    public class ParenthesizePropertyNameAttribute : Attribute
    {
        private bool v;

        public ParenthesizePropertyNameAttribute(bool v)
        {
            this.v = v;
        }

        public bool NeedParenthesis { get; set; }
    }
}