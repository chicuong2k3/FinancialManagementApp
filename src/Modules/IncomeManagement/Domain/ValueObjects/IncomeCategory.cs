namespace IncomeManagement.Domain.ValueObjects
{
    internal class IncomeCategory
    {
        public string Name { get; private set; }

        private IncomeCategory(string name)
        {
            Name = name;
        }

        public static IncomeCategory Salary => new IncomeCategory("Salary");
        public static IncomeCategory Freelance => new IncomeCategory("Freelance");
        public static IncomeCategory Rental => new IncomeCategory("Rental");
        public static IncomeCategory Other => new IncomeCategory("Other");

        public override string ToString() => Name;
    }
}
