namespace SolidPrinciples.DependencyInversionPrinciple.Incorrect
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentService
    {
        public void Debit()
        {
            Console.WriteLine("debit");
        }
    }
}
