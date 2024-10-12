namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Defines the type of a transaction line item (e.g., income, expense, tax).
/// </summary>
public class LineItemType : LookupItemBase
{
    public string Name { get; set; } = default!;
    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new HashSet<TransactionDetail>();
}
