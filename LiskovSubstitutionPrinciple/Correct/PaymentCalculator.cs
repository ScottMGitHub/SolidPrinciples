using SolidPrinciples.LiskovSubstitutionPrinciple.Correct.Fees;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.Correct
{
    /// <summary>
    ///  Liskov Substitution principle - strong behavioral subtyping;
    ///  Objects of a superclass shall be replaceable with objects of its subclasses without breaking the application
    ///  We should be able to treat a child class as though it were the parent class. 
    ///  Essentially this means that all derived classes should retain the functionality of their parent class
    ///  It's main purpose is to guarantee that objects lower in a relational hierarchy can be treated as though they are objects 
    ///  higher in the hierarchy. Basically, any child class should be able to do anything the parent can do.
    ///  ...
    ///  In the following refactored Correct implementation example Ive renamed the function in PaymentFee, and made it concrete
    ///  and Ive created a new abstract method for the subclasses to override. Now the sub classes can have their own functionality 
    ///  and do anything the parent class can do.
    /// </summary>
    public class PaymentCalculator
    {
        public decimal TotalPaymentFeeCalculator(decimal paymentAmount, List<PaymentFee> fees) 
            => fees.Sum(x => x.PaymentFeeCalculator(paymentAmount) + x.GenericPaymentFeeCalculator(paymentAmount));

    }
}
