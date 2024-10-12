namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Defines the type of an account (e.g., Checking, Savings, Investment).
/// </summary>
public class AccountType : LookupItemBase
{
    public string Name { get; set; } = default!;
    public virtual ICollection<Account> Accounts { get; set; } = new HashSet<Account>();
}
