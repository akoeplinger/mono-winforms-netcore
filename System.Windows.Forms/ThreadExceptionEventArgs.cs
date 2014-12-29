namespace System.Windows.Forms
{
    public class ThreadExceptionEventArgs : EventArgs
    {
        private Exception t;

        public ThreadExceptionEventArgs(Exception t)
        {
            this.t = t;
        }
    }
}