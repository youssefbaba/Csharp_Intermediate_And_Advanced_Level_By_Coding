namespace Fields
{
    public class Customer
    {
        // Fields
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();  // Second approach


        // Constructors
        //public Customer()  // First approach
        //{
        //    Orders = new List<Order>();
        //}
        //public Customer(int id):this()  // First approach
        //{
        //    Id = id;
        //}
        //public Customer(int id, string name) : this(id) // First approach
        //{
        //    Orders = new List<Order>(); 
        //    Name = name;
        //}

        public Customer(int id)
        {
            Id = id;
        }
        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }


        // Methods
        public void Promote()
        {
            //Orders = new List<Order>();  // Error because Orders field is readonly
            // ...
        }
    }
}
