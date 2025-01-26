using IncomeManagement.Domain.ValueObjects;

namespace IncomeManagement.Domain.Entities;
/// <summary>
/// Represents a recurring payment tied to an IncomeSource (e.g., a monthly salary).
/// </summary>
internal class RecurringIncome
{
    public Guid Id { get; private set; }
    public Money Amount { get; private set; } = default!;
    public PaymentFrequency Frequency { get; private set; } = default!;
    public DateTime NextPaymentDate { get; private set; }

    private RecurringIncome() { }

    public RecurringIncome(Money amount, PaymentFrequency frequency, DateTime nextPaymentDate)
    {
        Id = Guid.NewGuid();
        Amount = amount ?? throw new ArgumentNullException(nameof(amount));
        Frequency = frequency ?? throw new ArgumentNullException(nameof(frequency));
        NextPaymentDate = nextPaymentDate;
    }
}
