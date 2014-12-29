namespace System.ComponentModel
{
    public class DesignerCategoryAttribute : Attribute
    {
        private string v;

        public DesignerCategoryAttribute(string v)
        {
            this.v = v;
        }
    }
}