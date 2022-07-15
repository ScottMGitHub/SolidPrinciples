namespace SolidPrinciples.InterfaceSegregationPrinciple.Correct
{

    public interface INotificationService
    {
        public Task SendNotification(string emailAddress, string subject, string message);

    }
}
