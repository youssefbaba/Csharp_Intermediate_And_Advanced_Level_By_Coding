namespace Var_Dynamic
{
    public class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Methods
        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}");
        }

    }
}