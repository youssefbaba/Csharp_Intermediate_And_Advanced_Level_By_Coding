namespace StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "David", 20);
            User user1 = new User(2, "Mars", 25);
            //user._age = 30; // Error we cannot access to a static field by using instance reference
            User._age = 30;

            // user.Welcome(); // Error we cannot access to a static method by using instance reference
            User.Welcome();

        }
    }
}