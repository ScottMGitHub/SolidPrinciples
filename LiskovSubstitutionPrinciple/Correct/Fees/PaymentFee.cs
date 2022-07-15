namespace SolidPrinciples.LiskovSubstitutionPrinciple.Correct.Fees
{
    public abstract class PaymentFee
    {
        public decimal GenericPaymentFeeCalculator(decimal amount) {
            decimal flatAdminFee = 0.001M;
            decimal flatPercentageFee = 0.01M;
            return (amount * flatPercentageFee) + flatAdminFee;
        }

        public abstract decimal PaymentFeeCalculator(decimal amount);
    }
}
