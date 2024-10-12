namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents a category to which payees can be assigned (utilities, groceries...).
/// </summary>
public class Category : LookupItemBase
{
    public string Name { get; set; } = default!;
    public virtual ICollection<Payee> Payees { get; set; } = new HashSet<Payee>();
}
