namespace SolidPrinciples.OpenClosedPrinciple.Correct.Fees
{
    public abstract class PaymentFee
    {
        public abstract decimal PaymentFeeCalculator(decimal amount);

    }
}
