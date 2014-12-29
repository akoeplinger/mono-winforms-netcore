using System.IO;
using System.Resources;

namespace System.Runtime.Serialization.Formatters.Binary
{
    class BinaryFormatter
    {
        public SerializationBinder Binder { get; internal set; }

        internal void Serialize(MemoryStream stream, object data)
        {
            throw new NotImplementedException();
        }

        internal object Deserialize(MemoryStream stream)
        {
            throw new NotImplementedException();
        }
    }
}