namespace System.Windows.Forms
{
    public class DesignerSerializerAttribute : Attribute
    {
        private string v1;
        private string v2;

        public DesignerSerializerAttribute(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}