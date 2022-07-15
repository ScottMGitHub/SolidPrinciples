namespace SolidPrinciples.SingleResponsibilityPrinciple.Correct
{

    /// <summary>
    ///  The Single Responsibility Principle (SRP) states that any class must have one, and only one, reason to change. 
    ///  If a class has more than one reason to change, it should be refactored.
    ///  ...
    ///  In the banking service example below, SRP is maintained because we have moved emails service into its own class
    /// </summary>
    public class BankingService
    {

        public async Task Credit(decimal amount, string accountNumber)
        {
            Console.WriteLine($@"credit {amount} to {accountNumber}");
            
            // Simulate process
            await Task.Delay(1000);

        }

        public async Task Debit(decimal amount, string accountNumber)
        {
            Console.WriteLine($@"debit {amount} from {accountNumber}");
            
            // Simulate process
            await Task.Delay(1000);

        }    
    }
}
