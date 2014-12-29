namespace System.Windows.Forms
{
    public class PropertyTabAttribute :Attribute
    {
        public object[] TabClasses { get; set; }
        public object[] TabScopes { get; set; }
    }
}