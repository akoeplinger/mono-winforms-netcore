using System;
using System.Windows.Forms;

public class EventDescriptor
{
    public Type EventType { get; internal set; }
    public string Name { get; internal set; }

    internal void AddEventHandler(object o, EventHandler eventHandler)
    {
        throw new NotImplementedException();
    }

    internal void RemoveEventHandler(object o, EventHandler eventHandler)
    {
        throw new NotImplementedException();
    }
}