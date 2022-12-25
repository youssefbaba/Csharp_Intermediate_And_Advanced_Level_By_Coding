namespace Collections_Part3
{
    public class Customer
    {
        // Constructors
        public Customer(int id, string name, double balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

    }
}
