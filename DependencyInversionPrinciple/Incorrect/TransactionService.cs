namespace SolidPrinciples.DependencyInversionPrinciple.Incorrect
{
    /// <summary>
    /// The dependancy inversion principle has two rules;
    /// High-level modules should not depend on low-level modules. Both should depend on abstractions.
    /// Abstractions should not depend on details. Details should depend on abstractions.
    /// ...
    /// In this example the Transaction Service which is a higher level class, 
    /// has a dependancy on both the Fee and Payment service, which are low level classes.
    /// Newing up the two low level classes can be seen as an indication of DIP violation. 
    /// </summary>
    public class TransactionService
    {
        private readonly FeeService _feeService;

        private readonly PaymentService _paymentService;

        public TransactionService()
        {
            _feeService = new FeeService();
            _paymentService = new PaymentService();
        }

        public void ProcessPayment()
        {
            _paymentService.Debit();
            _feeService.Charge();
        }
    }
}
