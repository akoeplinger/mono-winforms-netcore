using System.IO;
using System.Resources;

namespace System.Runtime.Serialization.Formatters.Binary
{
    public class BinaryFormatter
    {
        public SerializationBinder Binder { get; set; }

        public void Serialize(MemoryStream stream, object data)
        {
            throw new NotImplementedException();
        }

        public object Deserialize(MemoryStream stream)
        {
            throw new NotImplementedException();
        }
    }
}