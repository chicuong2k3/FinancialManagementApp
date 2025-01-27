John is managing his finances using this application. He has the following income sources:

- Full-Time Job (Primary Income): John works as a software engineer and receives a monthly salary of $5,000.
- Occasionally, he receives bonuses (e.g., a $1,000 bonus for completing a big project).
- Rental Property (Passive Income): John owns a rental property that generates quarterly rental payments of $3,000.
- Freelance Design Work (Side Hustle): John occasionally takes freelance projects and earns irregular payments (e.g., $2,000 for designing a website).

```csharp
var fullTimeJob = new IncomeSource("Full-Time Job", IncomeCategory.Primary);
var monthlySalary = new RecurringIncome(
    new Money(5000, "USD"), 
    PaymentFrequency.Monthly, 
    DateTime.Today.AddMonths(1)
);
var bonus = new Transaction(
    new Money(1000, "USD"), 
    DateTime.Today
);

fullTimeJob.AddRecurringIncome(monthlySalary);
fullTimeJob.AddTransaction(bonus);


var rentalProperty = new IncomeSource("Rental Property", IncomeCategory.Passive);
var quarterlyRent = new RecurringIncome(
    new Money(3000, "USD"), 
    PaymentFrequency.Quarterly, 
    DateTime.Today.AddMonths(3)
);
rentalProperty.AddRecurringIncome(quarterlyRent);


var freelanceWork = new IncomeSource("Freelance Design Work", IncomeCategory.SideHustle);
var freelancePayment = new Transaction(
    new Money(2000, "USD"), 
    DateTime.Today.AddDays(-10)
);
freelanceWork.AddTransaction(freelancePayment);
```


