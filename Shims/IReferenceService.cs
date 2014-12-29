namespace System.ComponentModel
{
    public interface IReferenceService
    {
        string GetName(object value);
        object GetReference(string text);
        object[] GetReferences(Type type);
    }
}