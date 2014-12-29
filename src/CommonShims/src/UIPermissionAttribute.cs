using System.Security.Permissions;

namespace System.Windows.Forms
{
    public class UIPermissionAttribute : Attribute
    {
        private SecurityAction inheritanceDemand;

        public UIPermissionAttribute(SecurityAction inheritanceDemand)
        {
            this.inheritanceDemand = inheritanceDemand;
        }

        public UIPermissionWindow Window { get; set; }
    }
}