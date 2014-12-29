using System;
using System.Windows.Forms;

namespace System.ComponentModel
{
	public class EventDescriptor
	{
		public Type EventType { get; set; }
		public string Name { get; set; }

		public void AddEventHandler(object o, EventHandler eventHandler)
		{
			throw new NotImplementedException();
		}

		public void RemoveEventHandler(object o, EventHandler eventHandler)
		{
			throw new NotImplementedException();
		}
	}
}