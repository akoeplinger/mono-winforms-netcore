using System.Security.Permissions;
using src;

namespace System.Windows.Forms
{
    internal class UIPermissionAttribute : Attribute
    {
        private SecurityAction inheritanceDemand;

        public UIPermissionAttribute(SecurityAction inheritanceDemand)
        {
            this.inheritanceDemand = inheritanceDemand;
        }

        public UIPermissionWindow Window { get; set; }
    }
}