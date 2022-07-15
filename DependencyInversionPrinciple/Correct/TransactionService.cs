using SolidPrinciples.DependencyInversionPrinciple.Correct.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Correct
{
    /// <summary>
    /// The dependancy inversion principle has two rules;
    /// High-level modules should not depend on low-level modules. Both should depend on abstractions.
    /// Abstractions should not depend on details. Details should depend on abstractions.
    /// ...
    /// In order to correctly adhere to DIP we need remove the coupling (dependancy). 
    /// To do this we create abstractions in the form of interfaces which remove the dependancy 
    /// on concrete implementations. By using Dependancy Injection it allows both high-level and 
    /// low-level classes to rely on abstractions, thus enforcing Dependancy Inversion.
    /// </summary>
    public class TransactionService
    {
        private readonly IFeeService _feeService;

        private readonly IPaymentService _paymentService;

        public TransactionService(IFeeService feeService, IPaymentService paymentService)
        {
            _feeService = feeService;
            _paymentService = paymentService;
        }

        public void ProcessPayment()
        {
            _paymentService.Debit();
            _feeService.Charge();
        }
    }
}
