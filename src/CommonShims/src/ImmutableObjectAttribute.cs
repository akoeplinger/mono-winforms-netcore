namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class ImmutableObjectAttribute : Attribute
    {
        public ImmutableObjectAttribute(bool immutable)
        {
        }

        public static ImmutableObjectAttribute Yes = new ImmutableObjectAttribute(true);
    }
}