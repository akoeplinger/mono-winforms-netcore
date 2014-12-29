using System;

namespace System.Security
{
    abstract public class CodeAccessPermission : IPermission
    {
        abstract public SecurityElement ToXml();
        abstract public void FromXml(SecurityElement elem);
        public abstract IPermission Copy();
        public abstract IPermission Intersect(IPermission target);
        public abstract bool IsSubsetOf(IPermission target);
        public virtual IPermission Union(IPermission other)
        {
            return null;
        }
    }
}