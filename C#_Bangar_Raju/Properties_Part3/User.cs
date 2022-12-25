namespace Properties_Part3
{
    public class User
    {
        // Fields
        int _age;

        // Constructors
        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            _age = age;
        }

        // Properties
        public int Id { get; } // Read-only Auto-Implemented Property
        public string Name { set; get; } // Read-Write Auto-Implemented Property
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
        public string Country { get; } = "Turkey";  // Read-only Auto Property Initializer

        /*
         
         public string Name { set; } // Error : because Auto-Implemented properties must have get accessors
         
         */

        static void Main(string[] args)
        {
            User user = new User(100, "John", 30);
            Console.WriteLine($"User Id : {user.Id}");
            //user.Id = 101; // Invalid because Id property is read-only
            Console.WriteLine($"User Name : {user.Name}");
            user.Name += " Doe";
            Console.WriteLine($"Modified User Name : {user.Name}");
            Console.WriteLine($"User Age : {user.Age}");
            user.Age = -10;
            Console.WriteLine($"Modified User Age : {user.Age}");
            Console.WriteLine($"User Country : {user.Country}");
            //user.Country = "Spain"; // Invalid because Country property is read-only
            Console.WriteLine($"Modified User Country : {user.Country}");
        }
    }
}
