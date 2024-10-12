namespace FinancialManagementApp.Shared
{
    public interface ILookupItem
    {
        int SortOrder { get; }
        DateTime LastUpdated { get; }
        bool IsDeleted { get; }
    }
}
