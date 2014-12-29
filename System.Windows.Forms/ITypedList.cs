using System.ComponentModel;

namespace System.Windows.Forms
{
    internal interface ITypedList
    {
        string GetListName(PropertyDescriptor[] pds);
        PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
    }
}