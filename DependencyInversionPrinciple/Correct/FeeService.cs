using SolidPrinciples.DependencyInversionPrinciple.Correct.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Correct
{
    public class FeeService : IFeeService
    {
        public void Charge()
        {
            Console.WriteLine("charge");
        }
    }
}
