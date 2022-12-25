using Interfaces_And_Testability;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Interfaces_And_Testability.UnitTest
{

    [TestClass]
    public class OrderProcessorTest
    {
        // METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            Order order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        // METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            Order order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShiped);
            Assert.AreEqual(10, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }
}
