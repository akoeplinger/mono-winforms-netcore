using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace System.Windows.Forms.PropertyGridInternal
{
    internal class ServiceContainer : IServiceContainer
    {
        private IServiceContainer parent;

        public ServiceContainer()
        {
        }

        public ServiceContainer(IServiceContainer parent)
        {
            this.parent = parent;
        }

        public void AddService(Type serviceType, ServiceCreatorCallback callback)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, object serviceInstance)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote)
        {
            throw new NotImplementedException();
        }

        public void AddService(Type serviceType, object serviceInstance, bool promote)
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public void RemoveService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public void RemoveService(Type serviceType, bool promote)
        {
            throw new NotImplementedException();
        }

        internal void AddService(Type type, IWindowsFormsEditorService service)
        {
            throw new NotImplementedException();
        }
    }
}