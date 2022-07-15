namespace SolidPrinciples.LiskovSubstitutionPrinciple.Incorrect.Fees
{
    public class PaymentFee
    {
        public virtual decimal PaymentFeeCalculator(decimal amount) {
            decimal flatAdminFee = 0.001M;
            decimal flatPercentageFee = 0.01M;
            return (amount * flatPercentageFee) + flatAdminFee;
        }
    }
}
