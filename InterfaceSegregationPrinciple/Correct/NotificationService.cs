namespace SolidPrinciples.InterfaceSegregationPrinciple.Correct
{
    /// <summary>
    /// "Code should not be forced to depend on methods it does not use." 
    /// Thus interfaces should be split up (segregated) into smaller parts. 
    /// So that the implementers of said interface only implement what is needed. 
    /// ...
    /// In the notification service below, it now only has to implement the interface methods it needs
    /// </summary>
    public class NotificationService : INotificationService
    {
  
        public async Task SendNotification(string emailAddress, string subject, string message)
        {
            Console.WriteLine("Send notification");

            // Simulate notification
            await Task.Delay(1000);
        }
    }
}
