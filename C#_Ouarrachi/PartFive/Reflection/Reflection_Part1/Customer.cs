namespace Reflection_Part1
{
    public class Customer
    {
        // Constructors
        public Customer()
        {
            Id = -1;
            Name = string.Empty;
        }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }


        // Methods
        public void PrintId()
        {
            Console.WriteLine($"Id = {Id}");
        }
        public void PrintName()
        {
            Console.WriteLine($"Name = {Name}");
        }


        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
    }
}