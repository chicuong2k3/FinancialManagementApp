
using IncomeManagement.Domain.ValueObjects;

namespace IncomeManagement.Domain.Entities;

/// <summary>
/// Represents the core concept of an income stream (e.g., Salary, Freelance Work). 
/// This is the aggregate root.
/// </summary>
internal class IncomeSource
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = default!;
    public IncomeCategory Category { get; private set; } = default!;

    /// <summary>
    /// A single IncomeSource can have multiple RecurringIncome schedules (e.g., ).
    /// </summary>
    private ICollection<RecurringIncome> recurringIncomes;
    private ICollection<Transaction> transactions;

    public IReadOnlyCollection<RecurringIncome> RecurringIncomes => [.. recurringIncomes];
    public IReadOnlyCollection<Transaction> Transactions => [.. transactions];



    private IncomeSource()
    {
        transactions = new List<Transaction>();
        recurringIncomes = new List<RecurringIncome>();
    }

    public IncomeSource(string name, IncomeCategory category)
    {
        Id = Guid.NewGuid();
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Category = category ?? throw new ArgumentNullException(nameof(category));
        transactions = new List<Transaction>();
        recurringIncomes = new List<RecurringIncome>();
    }

    public void AddTransaction(Transaction transaction)
    {
        if (transaction == null)
        {
            throw new ArgumentNullException(nameof(transaction));
        }

        transactions.Add(transaction);
    }

    public void AddRecurringIncome(RecurringIncome recurringIncome)
    {
        if (recurringIncome == null)
        {
            throw new ArgumentNullException(nameof(recurringIncome));
        }

        recurringIncomes.Add(recurringIncome);
    }
}
