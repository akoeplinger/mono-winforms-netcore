using System.IO;

namespace System.Windows.Forms
{
    public class WebClient
    {
        public DownloadDataCompletedEventHandler DownloadDataCompleted { get; set; }
        public DownloadProgressChangedEventHandler DownloadProgressChanged { get; set; }
        public bool IsBusy { get; set; }

        public void CancelAsync()
        {
            throw new NotImplementedException();
        }

        public Stream OpenRead(string url)
        {
            throw new NotImplementedException();
        }

        public void DownloadDataAsync(Uri uri)
        {
            throw new NotImplementedException();
        }
    }
}