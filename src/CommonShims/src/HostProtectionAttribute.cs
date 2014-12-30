namespace System.Security.Permissions
{
    public class HostProtectionAttribute : Attribute
    {
        public HostProtectionAttribute ()
        {

        }

        public bool SharedState { get; set; }
    }
}