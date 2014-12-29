using System;

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class ToolboxItemAttribute : Attribute
    {
        private string v;

        public ToolboxItemAttribute(string v)
        {
            this.v = v;
        }

        public ToolboxItemAttribute(bool v)
        {
        }
    }
}