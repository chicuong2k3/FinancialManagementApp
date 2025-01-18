namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents afund transfer between accounts.
/// </summary>
public class Transfer
{
    public int Id { get; set; }

    public int TransactionId { get; set; }
    public Transaction Transaction { get; set; } = default!;

    public int AccountId { get; set; }
    public Account Account { get; set; } = default!;
}
