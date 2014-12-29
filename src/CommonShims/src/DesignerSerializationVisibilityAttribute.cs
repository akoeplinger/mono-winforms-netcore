namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Event)]
    public sealed class DesignerSerializationVisibilityAttribute : Attribute
    {
        public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility hidden)
        {
        }
    }
}