namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public sealed class RefreshPropertiesAttribute : Attribute
    {
        public RefreshPropertiesAttribute(RefreshProperties all)
        {
        }
    }
}