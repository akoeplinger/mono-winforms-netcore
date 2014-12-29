namespace System.Windows.Forms
{
    internal class StackTrace
    {
        private Exception e;
        private bool v;

        public StackTrace()
        {
        }

        public StackTrace(Exception e)
        {
            this.e = e;
        }

        public StackTrace(bool v)
        {
            this.v = v;
        }

        public StackTrace(Exception e, bool v)
        {
            this.e = e;
            this.v = v;
        }

        public int FrameCount { get; internal set; }

        internal StackFrame GetFrame(int i)
        {
            throw new NotImplementedException();
        }
    }
}