namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents a financial transaction within an account.
/// </summary>
public class Transaction
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int PayeeId { get; set; }
    public DateTime DateEntered { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// The date the transaction actually occurred.
    /// </summary>
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Optional description or notes about the transaction.
    /// </summary>
    public string? Memo { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Account Account { get; set; } = default!;
    public virtual Payee Payee { get; set; } = default!;
    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new HashSet<TransactionDetail>();
    public virtual Transfer? Transfer { get; set; }
}
