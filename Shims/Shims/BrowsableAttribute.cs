namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class BrowsableAttribute : Attribute
    {
        public static readonly BrowsableAttribute Yes = new BrowsableAttribute(true);

        public BrowsableAttribute(bool browsable)
        {
        }
    }
}