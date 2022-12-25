namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - Encapsulation ! In practice
                    - Define fields as private
                    -¨Provide getter/setter or properties methods as public 
            */

            Person person = new Person();
            //person.SetName(null);
            person.SetName("John Doe");
            person.SetBirthDate(new DateTime(1996, 12, 01));
            Console.WriteLine($"Name = {person.GetName()} - BirthDate = {person.GetBirthDate().ToShortDateString()}");

        }
    }
}