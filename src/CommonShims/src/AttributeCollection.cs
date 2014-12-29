using System.Collections;

namespace System.ComponentModel
{
    public class AttributeCollection : ICollection
    {
        private Attribute[] attribute;

        public AttributeCollection(Attribute[] attribute)
        {
            this.attribute = attribute;
        }

        public virtual Attribute this[Type attributeType]
        {
            get
            {
                return null;
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Contains(PasswordPropertyTextAttribute yes)
        {
            throw new NotImplementedException();
        }
    }
}