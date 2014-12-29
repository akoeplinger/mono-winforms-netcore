using System;
using System.Collections;

namespace System.ComponentModel
{
    public class StandardValuesCollection :ICollection
    {
        private ArrayList vals;

        public StandardValuesCollection(ArrayList vals)
        {
            this.vals = vals;
        }

        public StandardValuesCollection(Array x)
        {
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
    }
}