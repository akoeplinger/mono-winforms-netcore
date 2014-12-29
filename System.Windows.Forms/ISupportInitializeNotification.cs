namespace System.ComponentModel
{
    internal interface ISupportInitializeNotification : ISupportInitialize
    {
        bool IsInitialized { get;  }
        
        event EventHandler Initialized;
    }
}