namespace System.Windows.Forms
{
    internal class ComponentConverter : TypeConverter
    {
        private Type type;

        public ComponentConverter(Type type)
        {
            this.type = type;
        }
    }
}