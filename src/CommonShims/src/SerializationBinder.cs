using System;

namespace System.Runtime.Serialization
{
	public class SerializationBinder
	{
		public virtual Type BindToType(string assemblyName, string typeName)
		{
			return null;
		}
	}
}