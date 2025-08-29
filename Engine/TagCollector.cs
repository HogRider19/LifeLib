namespace Engine;

public class TagCollector<T> where T : Enum
{
    private HashSet<T> _tags;

    public TagCollector()
    {
        _tags = new HashSet<T>();
    }
    
    public void AddTag(T tag)
    {
        _tags.Add(tag);
    }

    public void RemoveTag(T tag)
    {
        _tags.Remove(tag);
    }

    public bool HasTag(T tag)
    {
        return _tags.Contains(tag);
    }
}