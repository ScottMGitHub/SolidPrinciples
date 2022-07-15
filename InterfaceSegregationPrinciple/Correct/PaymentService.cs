namespace SolidPrinciples.InterfaceSegregationPrinciple.Correct
{
    /// <summary>
    /// "Code should not be forced to depend on methods it does not use." 
    /// Thus interfaces should be split up (segregated) into smaller parts. 
    /// So that the implementers of said interface only implement what is needed. 
    /// ...
    /// In the payment service below it now only implements the interfaces it needs
    /// </summary>
    public class PaymentService : IPaymentService, IFeeService
    {
        public async Task MakePayment(decimal amount, string toAccountNumber, string fromAccountNumber)
        {
            Console.WriteLine("Make Payment");

            // Simulate payment
            await Task.Delay(1000);

        }

        public async Task ChargeFees(decimal amount, string accountNumber)
        {
            Console.WriteLine("Charge Fee");

            // Simulate Fee charge
            await Task.Delay(1000);
        }
    }
}
