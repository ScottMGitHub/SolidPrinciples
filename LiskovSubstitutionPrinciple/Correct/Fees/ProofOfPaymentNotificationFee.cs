namespace SolidPrinciples.LiskovSubstitutionPrinciple.Correct.Fees
{
    public class ProofOfPaymentNotificationFee : PaymentFee
    {
        private readonly decimal _fee = 0.01M;

        public override decimal PaymentFeeCalculator(decimal amount) => amount * _fee;

    }
}
