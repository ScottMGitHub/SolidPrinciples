using SolidPrinciples.DependencyInversionPrinciple.Correct.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Correct
{
    
    public class PaymentService : IPaymentService
    {
        public void Debit()
        {
            Console.WriteLine("debit");
        }
    }
}
