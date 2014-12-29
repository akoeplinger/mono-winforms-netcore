namespace System.Windows.Forms
{
    public class ProgressChangedEventArgs : EventArgs
    {
        private object progressPercentage;
        private object userState;

        public ProgressChangedEventArgs(object progressPercentage, object userState)
        {
            this.progressPercentage = progressPercentage;
            this.userState = userState;
        }

    }
}