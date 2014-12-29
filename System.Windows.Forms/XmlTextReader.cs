using System.IO;
using System.Xml;

namespace System.Windows.Forms
{
    public class XmlTextReader
    {
        private string filename;
        private Stream stream;
        private TextReader reader;

        public XmlTextReader(string filename)
        {
            this.filename = filename;
        }

        public XmlTextReader(Stream stream)
        {
            this.stream = stream;
        }

        public XmlTextReader(TextReader reader)
        {
            this.reader = reader;
        }

        public string Name { get; internal set; }
        public XmlNodeType NodeType { get; internal set; }
        public string Value { get; internal set; }
        internal WhitespaceHandling WhitespaceHandling { get; set; }
        public int LineNumber { get; internal set; }
        public int LinePosition { get; internal set; }
        public bool HasAttributes { get; internal set; }
        public int AttributeCount { get; internal set; }
        public string LocalName { get; internal set; }

        internal bool Read()
        {
            throw new NotImplementedException();
        }

        internal string ReadString()
        {
            throw new NotImplementedException();
        }

        internal string GetAttribute(string v)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void ReadStartElement()
        {
            throw new NotImplementedException();
        }

        internal string ReadElementString()
        {
            throw new NotImplementedException();
        }

        internal void MoveToAttribute(int i)
        {
            throw new NotImplementedException();
        }

        internal void MoveToElement()
        {
            throw new NotImplementedException();
        }
    }
}