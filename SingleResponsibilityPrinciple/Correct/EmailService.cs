using System.Net.Mail;

namespace SolidPrinciples.SingleResponsibilityPrinciple.Correct
{
    /// <summary>
    ///  The Single Responsibility Principle (SRP) states that any class must have one, and only one, reason to change. 
    ///  If a class has more than one reason to change, it should be refactored.
    ///  ...
    ///  In the Email service example below, SRP is maintained because we have moved the banking service into its own class
    /// </summary>
    public class EmailService
    {
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
