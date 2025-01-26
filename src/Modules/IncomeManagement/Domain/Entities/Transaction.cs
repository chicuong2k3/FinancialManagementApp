using IncomeManagement.Domain.ValueObjects;

namespace IncomeManagement.Domain.Entities;

internal class Transaction
{
    public Guid Id { get; private set; }

    public DateTime TransactionDate { get; private set; }
    public string? Description { get; private set; }
    public Money Amount { get; private set; } = default!;


    public Guid IncomeSourceId { get; private set; }

    private Transaction() { }

    public Transaction(DateTime transactionDate, Money amount, string description)
    {
        Id = Guid.NewGuid();
        TransactionDate = transactionDate;
        Amount = amount ?? throw new ArgumentNullException(nameof(amount));
        Description = description;
    }
}
