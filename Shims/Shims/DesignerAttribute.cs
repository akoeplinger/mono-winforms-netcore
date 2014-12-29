using System;

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple =true)]
    public class DesignerAttribute : Attribute
    {
        public DesignerAttribute(string v)
        {
        }

        public DesignerAttribute(string v1, string v2)
        {
        }

        public DesignerAttribute(string v1, Type v2)
        {
        }
    }
}