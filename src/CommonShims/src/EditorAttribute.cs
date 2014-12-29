namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class EditorAttribute : Attribute
    {
        public EditorAttribute(string typeName, string baseTypeName)
        {
        }
        public EditorAttribute(string typeName, Type baseType)
        {
        }
    }
}