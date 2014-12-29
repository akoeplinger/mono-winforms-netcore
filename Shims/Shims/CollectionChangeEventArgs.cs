namespace System.ComponentModel
{

    public class CollectionChangeEventArgs : EventArgs
    {
        public CollectionChangeEventArgs(CollectionChangeAction add, object dataBinding)
        {
        }

        public CollectionChangeAction Action { get; set; }
        public object Element { get; set; }
    }
}