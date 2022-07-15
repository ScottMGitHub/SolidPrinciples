namespace SolidPrinciples.LiskovSubstitutionPrinciple.Incorrect.Fees
{
    public class InterbankPaymententFee : PaymentFee
    {
        private readonly decimal _fee = 0.005M;

        public override decimal PaymentFeeCalculator(decimal amount) => amount * _fee;
    }
}
