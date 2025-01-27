namespace IncomeManagement.Domain.ValueObjects
{
    internal record PaymentFrequency
    {
        public string Frequency { get; private set; }

        private PaymentFrequency(string frequency)
        {
            Frequency = frequency;
        }

        public static PaymentFrequency Daily => new PaymentFrequency(nameof(Daily));
        public static PaymentFrequency Weekly => new PaymentFrequency(nameof(Weekly));
        public static PaymentFrequency BiWeekly => new PaymentFrequency(nameof(BiWeekly));
        public static PaymentFrequency Quarterly => new PaymentFrequency(nameof(Quarterly));
        public static PaymentFrequency Monthly => new PaymentFrequency(nameof(Monthly));
        public static PaymentFrequency Annually => new PaymentFrequency(nameof(Annually));

        public override string ToString() => Frequency;
    }
}
