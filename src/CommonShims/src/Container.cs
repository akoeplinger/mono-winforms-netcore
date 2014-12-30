namespace System.ComponentModel
{
    public class Container : IContainer
    {
        public ComponentCollection Components
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add (IComponent component)
        {
            throw new NotImplementedException();
        }

        public void Add (IComponent component, string name)
        {
            throw new NotImplementedException();
        }

        public void Dispose ()
        {
        }

        public void Remove (IComponent component)
        {
            throw new NotImplementedException();
        }
    }
}