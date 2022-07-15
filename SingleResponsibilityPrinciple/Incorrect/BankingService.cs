using System.Net.Mail;

namespace SolidPrinciples.SingleResponsibilityPrinciple.Incorrect
{

    /// <summary>
    ///  The Single Responsibility Principle (SRP) states that any class must have one, and only one, reason to change. 
    ///  If a class has more than one reason to change, it should be refactored.
    ///  ...
    ///  In the banking service example below, SRP is violated because this class has more than one reason to change,
    ///  Other than banking services, sending emails should not for part of this class
    /// </summary>
    public class BankingService
    {

        public async Task Credit(decimal amount, string accountNumber, string emailAddress)
        {
            Console.WriteLine($@"credit {amount} from {accountNumber}");

            // Simulate process
            await Task.Delay(1000);

            SendMailNotification(emailAddress, "You got money", $@"{amount} was credited to your account");

        }

        public async Task Debit(decimal amount, string accountNumber, string emailAddress)
        {
            Console.WriteLine($@"debit {amount} from {accountNumber}");

            // Simulate process
            await Task.Delay(1000);

            SendMailNotification(emailAddress, "You spent money", $@"{amount} was debited from your account");
        }

        public void SendMailNotification(string emailAddress, string subject, string emailBody)
        {

            // Validate email
            if (!emailAddress.Contains("@") || !emailAddress.Contains("."))
                throw new ArgumentNullException("Invaild Email");

            // Generate HTML Mail
            var htmlMail = $"<html><body>{emailBody}</body></html>";

            // Send mail
            SmtpClient client = new SmtpClient();
            client.SendAsync("noreply@website.nl", emailAddress, subject, htmlMail, null);

        }
    }
}
