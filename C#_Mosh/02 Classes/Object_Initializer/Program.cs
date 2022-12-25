namespace Object_Initializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                FirstName = "Youssef",
                LastName = "Baba",
            };
            Console.WriteLine($"Id = {person1.Id} , FirstName = {person1.FirstName} , LastName = {person1.LastName} , BirthDate = {person1.BirthDate}");

            Person person2 = new Person
            {
                Id = 1,
                FirstName = "Mohamed",
                LastName = "Zidani",
                BirthDate = DateTime.Now,
            };
            Console.WriteLine($"Id = {person2.Id} , FirstName = {person2.FirstName} , LastName = {person2.LastName} , BirthDate = {person2.BirthDate}");
        }
    }
}