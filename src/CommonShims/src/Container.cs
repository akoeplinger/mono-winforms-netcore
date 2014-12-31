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
        }

        public void Add (IComponent component, string name)
        {
        }

        public void Dispose ()
        {
        }

        public void Remove (IComponent component)
        {
        }
    }
}