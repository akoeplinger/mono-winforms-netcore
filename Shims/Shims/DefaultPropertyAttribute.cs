using System;

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DefaultPropertyAttribute : Attribute
    {
        public DefaultPropertyAttribute(string v)
        {
        }
    }
}