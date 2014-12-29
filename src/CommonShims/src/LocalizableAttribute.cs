namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class LocalizableAttribute : Attribute
    {
        public LocalizableAttribute(bool localizable)
        {
        }
    }
}