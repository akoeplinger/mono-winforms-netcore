using System;

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class DesignTimeVisibleAttribute : Attribute
    {
        public DesignTimeVisibleAttribute(bool v)
        {
        }
    }
}