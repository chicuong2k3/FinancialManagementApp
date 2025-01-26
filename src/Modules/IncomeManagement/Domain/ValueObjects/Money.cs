namespace IncomeManagement.Domain.ValueObjects
{
    internal class Money
    {
        public decimal Value { get; private set; }
        /// <summary>
        /// ISO 4217 currency code (e.g., USD, EUR)
        /// </summary>
        public string Currency { get; private set; }

        public Money(decimal value, string currency)
        {
            if (value < 0)
            {
                throw new ArgumentException("Money value cannot be negative.");
            }

            if (string.IsNullOrWhiteSpace(currency))
            {
                throw new ArgumentNullException(nameof(currency));
            }

            Value = value;
            Currency = currency.ToUpper();
        }

        public Money Add(Money other)
        {
            if (other.Currency != Currency)
            {
                throw new InvalidOperationException("Cannot add money with different currencies.");
            }

            return new Money(Value + other.Value, Currency);
        }

        public Money Subtract(Money other)
        {
            if (other.Currency != Currency)
            {
                throw new InvalidOperationException("Cannot subtract money with different currencies.");
            }

            return new Money(Value - other.Value, Currency);
        }

        public override string ToString() => $"{Value} {Currency}";
    }
}
