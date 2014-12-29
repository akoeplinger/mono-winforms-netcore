using System.ComponentModel;

namespace System.Windows.Forms
{
    internal interface IEventBindingService
    {
        PropertyDescriptorCollection GetEventProperties(EventDescriptorCollection events);
        PropertyDescriptor GetEventProperty(EventDescriptor defaultEvent);
    }
}