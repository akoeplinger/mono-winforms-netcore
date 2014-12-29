namespace System.Windows.Forms
{
    public class ListChangedEventArgs
    {
        private object p;
        private ListChangedType propertyDescriptorChanged;
        private ListChangedType reset;
        private int v;
        private int v1;

        public ListChangedEventArgs(ListChangedType propertyDescriptorChanged, object p)
        {
            this.propertyDescriptorChanged = propertyDescriptorChanged;
            this.p = p;
        }

        public ListChangedEventArgs(ListChangedType reset, int v)
        {
            this.reset = reset;
            this.v = v;
        }

        public ListChangedEventArgs(ListChangedType reset, int v, int v1) : this(reset, v)
        {
            this.v1 = v1;
        }

        public ListChangedType ListChangedType { get; internal set; }
        public int NewIndex { get; internal set; }
    }
}