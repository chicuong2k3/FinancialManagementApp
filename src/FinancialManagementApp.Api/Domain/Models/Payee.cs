namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents the entity that receives payments in a transaction.
/// </summary>
public class Payee
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    public virtual ICollection<ScheduledTransaction> ScheduledTransactions { get; set; } = new HashSet<ScheduledTransaction>();
    public virtual ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
}
