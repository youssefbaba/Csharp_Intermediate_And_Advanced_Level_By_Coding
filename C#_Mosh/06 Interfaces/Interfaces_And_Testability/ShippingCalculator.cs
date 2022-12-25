namespace Interfaces_And_Testability
{
    public class ShippingCalculator : IShippingCalculator
    {
        // Methods
        public float CalculateShipping(Order order)   // For calculate Shipping of order
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            return 0;
        }
    }
}
