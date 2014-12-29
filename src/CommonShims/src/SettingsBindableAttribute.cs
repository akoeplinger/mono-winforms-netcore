namespace System.Windows.Forms
{
    public class SettingsBindableAttribute : Attribute
    {
        private bool v;

        public SettingsBindableAttribute(bool v)
        {
            this.v = v;
        }
    }
}