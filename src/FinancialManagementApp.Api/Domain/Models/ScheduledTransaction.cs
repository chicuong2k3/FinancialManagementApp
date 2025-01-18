namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents a recurring or scheduled transaction that will occur in the future,
/// such as bills or subscriptions.
/// </summary>
public class ScheduledTransaction
{
    public int Id { get; set; }
    public string? Memo { get; set; }
    public int AccountId { get; set; }
    public Account Account { get; set; } = default!;
    public int PayeeId { get; set; }
    public virtual Payee Payee { get; set; } = default!;

    public int RecurrenceTypeId { get; set; }
    public RecurrenceType RecurrenceType { get; set; } = default!;
}
