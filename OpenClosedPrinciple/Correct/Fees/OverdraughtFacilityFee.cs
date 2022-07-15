namespace SolidPrinciples.OpenClosedPrinciple.Correct.Fees
{
    public class OverdraughtFacilityFee : PaymentFee
    {
        private readonly decimal _fee = 0.02M;

        public override decimal PaymentFeeCalculator(decimal amount) => amount * _fee;
        
    }
}
