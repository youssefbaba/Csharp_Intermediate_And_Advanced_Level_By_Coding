using Amazon;

namespace Access_Modifiers
{
    public class GoldCustomer : Customer
    {
        public void Offer()
        {
            TestSomething();   // this is visible here because it is protected
            //RateCalculator()  // Error this is not visible here because it is private
        }

    }
}
