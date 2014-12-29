namespace System.Windows.Forms
{
    public class DownloadProgressChangedEventArgs
    {
        public object ProgressPercentage { get; internal set; }
        public object UserState { get; internal set; }
    }
}