namespace Object_Initializer_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User  // we using object initializer to initialze the object (Id = 0)
            {
                Name = "Youssef Baba",
                BirthDay = new DateTime(1992, 12, 01),
            };
            Console.WriteLine($"{nameof(user1)} : Id = {user1.Id} , Name = {user1.Name ?? "null"} , BirhtDay = {user1.BirthDay:d}");

            User user2 = new User  // we using object initializer to initialze the object (Id = 0)
            {
                Id = 1,
                Name = "Mohamed Zidani",
                BirthDay = new DateTime(1992, 04, 18),
            };
            Console.WriteLine($"{nameof(user2)} : Id = {user2.Id} , Name = {user2.Name ?? "null"} , BirhtDay = {user2.BirthDay:d}");

        }
    }
}