using System.IO;
using System.Resources;

namespace System.Runtime.Serialization.Formatters.Soap
{
    public class SoapFormatter
    {
        public SerializationBinder Binder { get; set; }

        public object Deserialize(MemoryStream s)
        {
            throw new NotImplementedException();
        }
    }
}