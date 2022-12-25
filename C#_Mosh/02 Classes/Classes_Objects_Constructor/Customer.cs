
namespace Classes_Objects_Constructor
{
    public class Customer
    {
        // Fields : 
        public string FirstName;
        public string LastName;

        // Constructors : 
        // Default Constructor is provided by .Net by default when any of custom Constructors were define , otherwise i must define its
        public Customer():this("No FirstName Provided" , "No LastName Provided")
        {
        }
        // Custom Constructor
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Methods : 
        public void PrintFullName()
        {
            Console.WriteLine($"Full Name : {FirstName} {LastName}");
        }

        // Destructors : 
        ~Customer()
        {
            // Clean up code
        }
    }
}
