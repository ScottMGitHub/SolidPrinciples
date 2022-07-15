using SolidPrinciples.OpenClosedPrinciple.Correct.Fees;

namespace SolidPrinciples.OpenClosedPrinciple.Correct
{
    /// <summary>
    /// The Open/Closed Principle (OCP), as originally formulated by Bertrand Meyer, states that 
    /// a given software entity should be open for extension, but closed for modification. 
    /// Essentially, any given class (or module, or function, etc) should allow for its 
    /// functionality to be extended, but not allow for modification to its own source code.
    /// ...
    /// The class below adheres to the principle in that it is closed for modification
    /// Should there be an additional fee necessary we can add a new concrete class to the fees namespace
    /// As long as it inherits from the PaymentFee abstract base class it will be summed as part of the
    /// TotalPaymentFeeCalculator method
    /// </summary>
    public class PaymentCalculator
    {
        public decimal TotalPaymentFeeCalculator(decimal paymentAmount, List<PaymentFee> fees) 
            => fees.Sum(x => x.PaymentFeeCalculator(paymentAmount));

    }
}
