namespace System.Windows.Forms
{
    public class PropertyTabScope
    {
        public static PropertyTabScope Component { get; internal set; }
        public static PropertyTabScope Global { get; internal set; }
    }
}