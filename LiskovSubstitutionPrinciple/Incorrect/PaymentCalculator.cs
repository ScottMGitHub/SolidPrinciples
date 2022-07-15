using SolidPrinciples.LiskovSubstitutionPrinciple.Incorrect.Fees;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.Incorrect
{
    /// <summary>
    ///  Liskov Substitution principle - strong behavioral subtyping;
    ///  "A child class should be interchangeable with its parent class"
    ///  Any subclass should maintain the baseclass' functionality. 
    ///  To test this; when inheriting from a baseclass,
    ///  if your subclass can no longer perform one of the operations of the baseclass, 
    ///  the principle has been violated.
    ///  ...
    ///  The following example is very similer to the OCP principle example and the two principles do indeed complement each other,
    ///  They are not the same though! In this Incorrect example the different payment fees subclasses 'replace' the functionality in their baseclass.
    ///  Specifically, the child classes replace the calculation in payment fee. 
    /// </summary>
    public class PaymentCalculator
    {
        public decimal TotalPaymentFeeCalculator(decimal paymentAmount, List<PaymentFee> fees) 
            => fees.Sum(x => x.PaymentFeeCalculator(paymentAmount));

    }
}
