namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true), Serializable]
    public sealed class ToolboxItemFilterAttribute : Attribute
    {
        public ToolboxItemFilterAttribute(string v)
        {
        }
        public ToolboxItemFilterAttribute(string v, ToolboxItemFilterType allow)
        {
        }
    }
}