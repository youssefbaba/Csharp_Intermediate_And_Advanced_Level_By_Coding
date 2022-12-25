namespace StaticMembers
{
    public class User
    {
        // Fields
        int _id;
        string _name;
        public static int _age;    // Static field

        // Constructors
        public User()
        {
        }
        public User(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
        }

        //  Methods
        public void Display()
        {
            // Console.WriteLine($"Id = {_id} - Name = {_name} - Age = {User._age}");  // can be more simplified
            Console.WriteLine($"Id = {_id} - Name = {_name} - Age = {_age}");
        }

        public static void Welcome()
        {
            User user = new User();
            Console.WriteLine("Welcome");
            // Display(); // we cannot access to non-static members inside static method , so an reference object is required for the non-static members .
            user.Display();
        }

    }
}
