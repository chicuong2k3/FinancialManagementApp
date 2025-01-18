namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents a financial account that a user manages, 
/// such as a bank account, a credit card, or a cash holoding.
/// </summary>
public class Account
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public double StartingBalance { get; set; }
    public double BalanceAsOfDate { get; set; }
    public int AccountTypeId { get; set; }
    public AccountType AccountType { get; set; } = default!;
    public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
    public ICollection<ScheduledTransaction> ScheduledTransactions { get; set; } = new HashSet<ScheduledTransaction>();
    public ICollection<Transfer> Transfers { get; set; } = new HashSet<Transfer>();
}
