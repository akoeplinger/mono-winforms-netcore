using System;

namespace System.Security.Permissions
{
    public interface IUnrestrictedPermission
    {
        bool IsUnrestricted();
    }
}