namespace IncomeManagement.Domain.ValueObjects
{
    internal record Money
    {
        public decimal Value { get; private set; }
        public string Currency { get; private set; }
        public Money(decimal value, string currency)
        {
            if (value < 0)
            {
                throw new ArgumentException("Money value cannot be negative.", nameof(value));
            }

            if (string.IsNullOrWhiteSpace(currency))
            {
                throw new ArgumentNullException(nameof(currency), "Currency cannot be null or empty.");
            }

            Value = value;
            Currency = currency;
        }

        public Money Add(Money other)
        {
            if (other.Currency != Currency)
            {
                throw new InvalidOperationException("Cannot add money with different currencies.");
            }

            return this with { Value = Value + other.Value };
        }

        public Money Subtract(Money other)
        {
            if (other.Currency != Currency)
            {
                throw new InvalidOperationException("Cannot subtract money with different currencies.");
            }

            return this with { Value = Value - other.Value };
        }

        public override string ToString() => $"{Value} {Currency}";
    }
}
