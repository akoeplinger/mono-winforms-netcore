using System;

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DefaultEventAttribute : Attribute
    {
        public DefaultEventAttribute(string v)
        {
        }
    }
}