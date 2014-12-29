using System;

namespace System.ComponentModel
{
    public class ExpandableObjectConverter : TypeConverter
    {
        public ExpandableObjectConverter()
        {
        }

        public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return false;
        }

        public virtual object CreateInstance(ITypeDescriptorContext context, System.Collections.IDictionary propertyValues)
        {
            return null;
        }
    }
}