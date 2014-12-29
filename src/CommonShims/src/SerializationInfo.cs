using System;
using System.Collections;
using System.Reflection;

namespace System.Runtime.Serialization
{
    public class SerializationInfo
    {
        private Type type;
        private object formatterConverter;

        public SerializationInfo(Type type,object formatterConverter)
        {
            this.type = type;
            this.formatterConverter = formatterConverter;
        }

        public object GetValue(string v, Type type)
        {
            throw new NotImplementedException();
        }

        public string GetString(string v)
        {
            throw new NotImplementedException();
        }

        public bool GetBoolean(string v)
        {
            throw new NotImplementedException();
        }

        public void AddValue(string v, object value)
        {
            throw new NotImplementedException();
        }

        public void AddValue(string v, object value, Type type)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int GetInt32(string v)
        {
            throw new NotImplementedException();
        }
    }
}