
namespace Constructor_Test1
{
    public class Customer
    {
        // Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }  // Default value of Orders is null

        // Constructors
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id) : this() // shortcut for creating constructor is ctor
        {
            Id = id;
        }
        //public Customer(int id, string name):this()
        public Customer(int id, string name) : this(id)
        {
            Name = name;
            Id = id;
        }
    }
}


