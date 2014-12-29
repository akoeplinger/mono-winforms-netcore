namespace System.Windows.Forms
{
    internal class SettingsBindableAttribute : Attribute
    {
        private bool v;

        public SettingsBindableAttribute(bool v)
        {
            this.v = v;
        }
    }
}