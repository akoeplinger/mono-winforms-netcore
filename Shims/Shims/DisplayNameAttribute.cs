namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Class | AttributeTargets.Method)]
    public class DisplayNameAttribute : Attribute
    {
        public DisplayNameAttribute(string v)
        {
        }
    }
}