namespace Shared
{
    public interface ILookupItem
    {
        string Name { get; }
        int SortOrder { get; }
        DateTime LastUpdated { get; }
        bool IsDeleted { get; }
    }
}
