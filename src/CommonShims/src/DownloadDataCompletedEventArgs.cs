namespace System.Windows.Forms
{
    public class DownloadDataCompletedEventArgs :AsyncCompletedEventArgs
    {
        public bool Cancelled { get; set; }
        public object Error { get; set; }
        public byte[] Result { get; set; }
    }
}