using System;

namespace System.Security.Permissions
{
    public abstract class CodeAccessSecurityAttribute : Attribute
    {
        public CodeAccessSecurityAttribute(SecurityAction action)
        {
        }

        public bool Unrestricted { get; set; }

        abstract public IPermission CreatePermission();
    }
}