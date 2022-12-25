namespace Interfaces_And_Testability.UnitTest
{
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 10;
        }
    }
}
