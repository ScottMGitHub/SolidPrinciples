namespace SolidPrinciples.InterfaceSegregationPrinciple.Incorrect
{

    public interface IBankingService
    {
        public Task MakePayment(decimal amount, string toAccountNumber, string fromAccountNumber);

        public Task ChargeFees(decimal amount, string accountNumber);

        public Task SendNotification(string emailAddress, string subject, string message);

    }
}
