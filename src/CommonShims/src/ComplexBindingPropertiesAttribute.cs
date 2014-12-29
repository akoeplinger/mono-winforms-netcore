namespace System.Windows.Forms
{
    public class ComplexBindingPropertiesAttribute : Attribute
    {
        private string v1;
        private string v2;

        public ComplexBindingPropertiesAttribute(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}