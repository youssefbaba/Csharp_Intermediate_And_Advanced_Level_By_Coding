using System;

namespace Interfaces_And_Testability
{
    public class Order
    {
        // Properties
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShiped
        {
            get
            {
                return Shipment != null;
            }
        }
    }
}
