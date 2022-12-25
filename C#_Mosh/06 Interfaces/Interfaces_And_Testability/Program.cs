using System;

namespace Interfaces_And_Testability
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor orderProcessor = new OrderProcessor(new ShippingCalculator()); // There is UpCasting here
            Order order = new Order {DatePlaced = DateTime.Now , TotalPrice = 100f};
            orderProcessor.Process(order);  
        }
    }
}