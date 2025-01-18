namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Defines the type of a transaction line item (e.g., income, expense, tax).
/// </summary>
public class LineItemType : LookupItemBase
{
    /// <summary>
    /// Gets or sets the name of the line item type.
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    /// Gets or sets the collection of transaction details associated with this line item type.
    /// </summary>
    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new HashSet<TransactionDetail>();
}
