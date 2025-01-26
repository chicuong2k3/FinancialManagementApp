namespace Shared;

public abstract class LookupItemBase : LookupItemBase<int>, ILookupItem
{
}

public abstract class LookupItemBase<TKey> : ILookupItem
{
    public virtual TKey Id { get; set; } = default!;
    public virtual int SortOrder { get; set; }
    public virtual DateTime LastUpdated { get; set; }
    public virtual bool IsDeleted { get; set; }

    public virtual string Name { get; set; } = default!;
}
