using System;

namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class CategoryAttribute : Attribute
    {
        public CategoryAttribute()
        {
        }

        public CategoryAttribute(string category)
        {
        }

        protected virtual string GetLocalizedString(string value)
        {
            return null;
        }
    }
}