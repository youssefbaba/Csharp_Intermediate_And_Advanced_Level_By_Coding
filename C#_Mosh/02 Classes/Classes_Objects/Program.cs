namespace Classes_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = Person.Parse("Youssef");
            person.Introduce("Omar");
        }
    }
}
