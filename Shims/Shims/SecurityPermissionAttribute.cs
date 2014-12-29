namespace System.Security.Permissions
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public class SecurityPermissionAttribute : Attribute
    {
        public SecurityPermissionAttribute(SecurityAction linkDemand)
        {
        }

        public bool UnmanagedCode
        {
            get;
            set;
        }

        public bool SerializationFormatter
        {
            get;
            set;
        }

        public SecurityPermissionFlag Flags
        {
            get;set;
        }
    }
}