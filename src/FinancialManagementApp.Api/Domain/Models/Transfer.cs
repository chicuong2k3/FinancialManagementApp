namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents a transfer between two transactions (typically from one account to another).
/// </summary>
public class Transfer
{
    public int Id { get; set; }
    public int TransactionId { get; set; }
    public int AccountId { get; set; }
    public virtual Transaction Transaction { get; set; } = default!;
    public virtual Account Account { get; set; } = default!;
}
