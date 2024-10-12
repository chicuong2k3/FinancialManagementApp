namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents a financial account that a user manages, 
/// such as a bank account or an investment account.
/// </summary>
public class Account
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double StartingBalance { get; set; }
    /// <summary>
    /// The current balance of the account.
    /// </summary>
    public double BalanceAsOfDate { get; set; }
    public int AccountTypeId { get; set; }
    public virtual AccountType AccountType { get; set; } = default!;
    public virtual ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
    public virtual ICollection<ScheduledTransaction> ScheduledTransactions { get; set; } = new HashSet<ScheduledTransaction>();
    public virtual ICollection<Transfer> Transfers { get; set; } = new HashSet<Transfer>();
}
