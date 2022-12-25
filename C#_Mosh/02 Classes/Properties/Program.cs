namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            // First Approach
            Person person = new Person();
            person.Name = "John Doe";
            Console.WriteLine($"Name = {person.Name} - Age = {person.Age}");

            */



            // Second Approach
            Person person = new Person("David Huge" , new DateTime(1996,12,01));
            Console.WriteLine($"Name = {person.Name} - Age = {person.Age}");



        }
    }
}