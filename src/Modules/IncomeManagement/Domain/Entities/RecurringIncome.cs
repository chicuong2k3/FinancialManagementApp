using IncomeManagement.Domain.ValueObjects;

namespace IncomeManagement.Domain.Entities;

internal class RecurringIncome
{
    public Guid Id { get; private set; }
    public Money Amount { get; private set; } = default!;
    public PaymentFrequency Frequency { get; private set; } = default!;
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public Guid IncomeSourceId { get; private set; }

    private RecurringIncome() { }

    public RecurringIncome(Money amount, PaymentFrequency frequency, DateTime startDate, DateTime? endDate = null)
    {
        Id = Guid.NewGuid();
        Amount = amount ?? throw new ArgumentNullException(nameof(amount));
        Frequency = frequency ?? throw new ArgumentNullException(nameof(frequency));
        StartDate = startDate;
        EndDate = endDate;
    }

    public bool IsActive(DateTime currentDate)
    {
        return currentDate >= StartDate && (EndDate == null || currentDate <= EndDate);
    }
}
