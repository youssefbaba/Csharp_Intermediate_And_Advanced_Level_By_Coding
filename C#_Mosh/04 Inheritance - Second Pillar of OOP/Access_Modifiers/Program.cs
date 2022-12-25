using Amazon;

namespace Access_Modifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            //Amazon.RateCalculator rateCalculator = new RateCalculator()  // Error because it is internal (visible just inside your asembly)
        }
    }
}
