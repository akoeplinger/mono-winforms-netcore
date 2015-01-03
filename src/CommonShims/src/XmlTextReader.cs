using System.IO;

namespace System.Xml
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

        public string Name { get; set; }
        public XmlNodeType NodeType { get; set; }
        public string Value { get; set; }
        public WhitespaceHandling WhitespaceHandling { get; set; }
        public int LineNumber { get; set; }
        public int LinePosition { get; set; }
        public bool HasAttributes { get; set; }
        public int AttributeCount { get; set; }
        public string LocalName { get; set; }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public string ReadString()
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string v)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ReadStartElement()
        {
            throw new NotImplementedException();
        }

        public string ReadElementString()
        {
            throw new NotImplementedException();
        }

        public void MoveToAttribute(int i)
        {
            throw new NotImplementedException();
        }

        public void MoveToElement()
        {
            throw new NotImplementedException();
        }
    }
}