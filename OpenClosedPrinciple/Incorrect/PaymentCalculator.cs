namespace SolidPrinciples.OpenClosedPrinciple.Incorrect
{
    /// <summary>
    /// The Open/Closed Principle (OCP), as originally formulated by Bertrand Meyer, states that 
    /// a given software entity should be open for extension, but closed for modification. 
    /// Essentially, any given class (or module, or function, etc) should allow for its 
    /// functionality to be extended, but not allow for modification to its own source code.
    /// ...
    /// The class below and more specifically the TotalPaymentFeeCalculator violoates this principle
    /// Because if a different fee type comes in we will need to refactor the method to accomodated it.
    /// Thus it is not closed for modification as it should be.
    /// </summary>
    public class PaymentCalculator
    {
        private readonly decimal _overdraughtFacilityPercentage = 0.02M;
        private readonly decimal _proofOfPaymentNotificationPercentage = 0.001M;
        private readonly decimal _interbankPaymentPercentage = 0.005M;


        public decimal TotalPaymentFeeCalculator(decimal amount, List<FeeType> invoiceType)
        {
            decimal total = 0;

            if (invoiceType.Any(x => x == FeeType.OverdraughtFacility))
                total += amount * _overdraughtFacilityPercentage;
            
            if (invoiceType.Any(x => x == FeeType.ProofOfPaymentNotification))
                total += amount * _proofOfPaymentNotificationPercentage;

            if (invoiceType.Any(x => x == FeeType.InterbankPayment))
                total += amount * _interbankPaymentPercentage;

            return total;
            
        }

        public enum FeeType
        {
            OverdraughtFacility,
            ProofOfPaymentNotification,
            InterbankPayment
        };
    }
}
