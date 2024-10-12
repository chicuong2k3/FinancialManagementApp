

namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Defines the recurrence pattern for scheduled transactions (daily, weekly,...).
/// </summary>
public class RecurrenceType : LookupItemBase
{
    public string Name { get; set; } = default!;
    public string DisplayText { get; set; } = string.Empty;
    public virtual ICollection<ScheduledTransaction> ScheduledTransactions { get; set; } = new HashSet<ScheduledTransaction>();
}
