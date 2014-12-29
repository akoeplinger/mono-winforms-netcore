using System.IO;

namespace System.Windows.Forms
{
    public class XmlTextWriter
    {
        private string full_file_name;
        private object p;
        private StringWriter sw;
        private TextWriter textwriter;

        internal Formatting Formatting { get; set; }

        public XmlTextWriter(string full_file_name, object p)
        {
            this.full_file_name = full_file_name;
            this.p = p;
        }

        public XmlTextWriter(StringWriter sw)
        {
            this.sw = sw;
        }

        public XmlTextWriter(TextWriter textwriter)
        {
            this.textwriter = textwriter;
        }

        internal void WriteStartElement(string v)
        {
            throw new NotImplementedException();
        }

        internal void WriteAttributeString(string v, string name)
        {
            throw new NotImplementedException();
        }

        internal void WriteEndElement()
        {
            throw new NotImplementedException();
        }

        internal void WriteString(string v)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void WriteEndDocument()
        {
            throw new NotImplementedException();
        }

        internal void WriteStartDocument()
        {
            throw new NotImplementedException();
        }

        internal void WriteBase64(byte[] value, int offset, int length)
        {
            throw new NotImplementedException();
        }

        internal void WriteWhitespace(string v)
        {
            throw new NotImplementedException();
        }

        internal void WriteRaw(string schema)
        {
            throw new NotImplementedException();
        }

        internal void WriteElementString(string v, string value)
        {
            throw new NotImplementedException();
        }

        internal void Flush()
        {
            throw new NotImplementedException();
        }
    }
}