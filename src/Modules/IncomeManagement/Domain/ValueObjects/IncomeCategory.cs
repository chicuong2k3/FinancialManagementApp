namespace IncomeManagement.Domain.ValueObjects
{
    internal record IncomeCategory
    {
        public string Name { get; private set; }

        private IncomeCategory(string name)
        {
            Name = name;
        }

        public static IncomeCategory Primary => new IncomeCategory(nameof(Primary));
        public static IncomeCategory Passive => new IncomeCategory(nameof(Passive));
        public static IncomeCategory SideHustle => new IncomeCategory(nameof(SideHustle));
        public static IncomeCategory Other => new IncomeCategory(nameof(Other));

        public override string ToString() => Name;
    }
}
