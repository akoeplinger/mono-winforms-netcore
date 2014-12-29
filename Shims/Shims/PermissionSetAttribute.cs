namespace System.Security.Permissions
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public class PermissionSetAttribute : Attribute
    {
        public PermissionSetAttribute(SecurityAction linkDemand)
        {
        }

        public bool Unrestricted
        {
            get;
            set;
        }
    }
}