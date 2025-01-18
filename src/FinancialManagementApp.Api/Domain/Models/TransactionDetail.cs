namespace FinancialManagementApp.Api.Domain.Models;

/// <summary>
/// Represents the detailed breakdown of a transaction, 
/// typically for transactions involving multiple line items.
/// </summary>
public class TransactionDetail
{
    public int Id { get; set; }
    public double Amount { get; set; }
    public string? Description { get; set; }
    public int TransactionId { get; set; }
    public Transaction Transaction { get; set; } = default!;
    public int LineItemTypeId { get; set; }
    public LineItemType LineItemType { get; set; } = default!;
}
