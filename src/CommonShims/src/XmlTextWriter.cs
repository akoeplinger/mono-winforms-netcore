using System.IO;

namespace System.Windows.Forms
{
    public class XmlTextWriter
    {
        private string full_file_name;
        private object p;
        private StringWriter sw;
        private TextWriter textwriter;

        public Formatting Formatting { get; set; }

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

        public void WriteStartElement(string v)
        {
            throw new NotImplementedException();
        }

        public void WriteAttributeString(string v, string name)
        {
            throw new NotImplementedException();
        }

        public void WriteEndElement()
        {
            throw new NotImplementedException();
        }

        public void WriteString(string v)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void WriteEndDocument()
        {
            throw new NotImplementedException();
        }

        public void WriteStartDocument()
        {
            throw new NotImplementedException();
        }

        public void WriteBase64(byte[] value, int offset, int length)
        {
            throw new NotImplementedException();
        }

        public void WriteWhitespace(string v)
        {
            throw new NotImplementedException();
        }

        public void WriteRaw(string schema)
        {
            throw new NotImplementedException();
        }

        public void WriteElementString(string v, string value)
        {
            throw new NotImplementedException();
        }

        public void Flush()
        {
            throw new NotImplementedException();
        }
    }
}