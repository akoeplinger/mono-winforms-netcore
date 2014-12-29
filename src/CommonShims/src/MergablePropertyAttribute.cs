
namespace System.ComponentModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class MergablePropertyAttribute : Attribute
    {
        public MergablePropertyAttribute(bool mergeable)
        {
        }

        public bool AllowMerge { get; set; }
    }
}