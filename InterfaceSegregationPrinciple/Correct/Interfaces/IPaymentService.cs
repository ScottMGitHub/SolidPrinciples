namespace SolidPrinciples.InterfaceSegregationPrinciple.Correct
{

    public interface IPaymentService
    {
        public Task MakePayment(decimal amount, string toAccountNumber, string fromAccountNumber);

    }
}
