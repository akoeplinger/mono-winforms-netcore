namespace System.Security
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
    sealed public class SuppressUnmanagedCodeSecurityAttribute : System.Attribute
    {
    }
}