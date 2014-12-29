using System.Collections;
using System.Reflection;

namespace System.ComponentModel
{
    public class InstanceDescriptor
    {
        private bool v;

        public InstanceDescriptor(MemberInfo member, ICollection arguments)
        {

        }

        public InstanceDescriptor(MemberInfo member, ICollection arguments, bool v) : this(member, arguments)
        {
            this.v = v;
        }
    }
}