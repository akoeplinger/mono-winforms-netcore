using System.IO;
using System.Resources;

namespace System.Runtime.Serialization.Formatters.Soap
{
    class SoapFormatter
    {
        public SerializationBinder Binder { get; internal set; }

        internal object Deserialize(MemoryStream s)
        {
            throw new NotImplementedException();
        }
    }
}