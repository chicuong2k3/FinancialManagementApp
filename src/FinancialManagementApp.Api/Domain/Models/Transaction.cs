namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents a financial transaction associated with an account.
/// </summary>
public class Transaction
{
    public int Id { get; set; }
    /// <summary>
    /// Date when the transaction was recorded.
    /// </summary>
    public DateTime DateEntered { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// The actual date of the transaction.
    /// </summary>
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    public string? Memo { get; set; }
    public bool IsDeleted { get; set; }
    public int AccountId { get; set; }
    public Account Account { get; set; } = default!;
    public int PayeeId { get; set; }
    public Payee Payee { get; set; } = default!;
    public ICollection<TransactionDetail> TransactionDetails { get; set; } = new HashSet<TransactionDetail>();
    public Transfer? Transfer { get; set; }
}
