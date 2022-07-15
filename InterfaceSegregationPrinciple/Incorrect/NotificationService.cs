namespace SolidPrinciples.InterfaceSegregationPrinciple.Incorrect
{
    /// <summary>
    /// "Code should not be forced to depend on methods it does not use." 
    /// Thus interfaces should be split up (segregated) into smaller parts. 
    /// So that the implementers of said interface only implement what is needed. 
    /// ...
    /// In the example here, notification service also implements the ChargeFees and MakePayment methods,
    /// where it only requires the SendNotification method
    /// </summary>
    public class NotificationService : IBankingService
    {
        public async Task ChargeFees(decimal amount, string accountNumber)
        {
            throw new NotImplementedException();
        }

        public async Task MakePayment(decimal amount, string toAccountNumber, string fromAccountNumber)
        {
            throw new NotImplementedException();
        }

        public async Task SendNotification(string emailAddress, string subject, string message)
        {
            Console.WriteLine("Send notification");

            // Simulate notification
            await Task.Delay(1000);
        }
    }
}
