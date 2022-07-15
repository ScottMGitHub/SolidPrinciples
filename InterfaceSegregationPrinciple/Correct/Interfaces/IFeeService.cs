namespace SolidPrinciples.InterfaceSegregationPrinciple.Correct
{
    public interface IFeeService
    {
        public Task ChargeFees(decimal amount, string accountNumber);


    }
}
