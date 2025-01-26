namespace IncomeManagement.Domain.ValueObjects
{
    internal class PaymentFrequency
    {
        public string Frequency { get; private set; }

        private PaymentFrequency(string frequency)
        {
            Frequency = frequency;
        }

        public static PaymentFrequency Monthly => new PaymentFrequency("Monthly");
        public static PaymentFrequency Weekly => new PaymentFrequency("Weekly");
        public static PaymentFrequency Annually => new PaymentFrequency("Annually");

        public override string ToString() => Frequency;
    }
}
