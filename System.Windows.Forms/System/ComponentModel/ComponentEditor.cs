namespace System.ComponentModel
{
    public class ComponentEditor
    {
        public virtual bool EditComponent(ITypeDescriptorContext context, object component)
        {
            return false;
        }
    }
}