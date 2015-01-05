namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class SRDescriptionAttribute : Attribute
    {
        public SRDescriptionAttribute(string s)
        {
        }
    }
}