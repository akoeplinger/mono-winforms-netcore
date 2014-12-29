namespace System.Windows.Forms
{
    public class DownloadDataCompletedEventArgs :AsyncCompletedEventArgs
    {
        public bool Cancelled { get; internal set; }
        public object Error { get; internal set; }
        public byte[] Result { get; internal set; }
    }
}