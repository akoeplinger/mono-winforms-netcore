namespace System.Windows.Forms
{
    internal class PropertyTabAttribute :Attribute
    {
        public object[] TabClasses { get; internal set; }
        public object[] TabScopes { get; internal set; }
    }
}