namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents a recurring or scheduled transaction that will occur in the future.
/// </summary>
public class ScheduledTransaction
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int PayeeId { get; set; }
    /// <summary>
    /// Foreign key indicating the recurrence pattern (weekly, monthly...).
    /// </summary>
    public int RecurrenceTypeId { get; set; }
    public virtual Account Account { get; set; } = default!;
    public virtual Payee Payee { get; set; } = default!;
    public virtual RecurrenceType RecurrenceType { get; set; } = default!;

}
