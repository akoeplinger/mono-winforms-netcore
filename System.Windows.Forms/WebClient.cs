using System.IO;

namespace System.Windows.Forms
{
    internal class WebClient
    {
        public DownloadDataCompletedEventHandler DownloadDataCompleted { get; internal set; }
        public DownloadProgressChangedEventHandler DownloadProgressChanged { get; internal set; }
        public bool IsBusy { get; internal set; }

        internal void CancelAsync()
        {
            throw new NotImplementedException();
        }

        internal Stream OpenRead(string url)
        {
            throw new NotImplementedException();
        }

        internal void DownloadDataAsync(Uri uri)
        {
            throw new NotImplementedException();
        }
    }
}