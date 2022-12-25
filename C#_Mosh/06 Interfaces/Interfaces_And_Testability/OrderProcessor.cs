using System;

namespace Interfaces_And_Testability
{
    public class OrderProcessor
    {
        // Fields
        private readonly IShippingCalculator _shippingCalculator;


        // Constructors
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator ;    
        }


        // Methods
        public void Process(Order order)
        {
            if (order.IsShiped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
