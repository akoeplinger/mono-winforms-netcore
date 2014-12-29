namespace System.Windows.Forms
{
    public class AddingNewEventArgs : EventArgs
    {
        public AddingNewEventArgs()
        {
        }

        public object NewObject { get; set; }
    }
}