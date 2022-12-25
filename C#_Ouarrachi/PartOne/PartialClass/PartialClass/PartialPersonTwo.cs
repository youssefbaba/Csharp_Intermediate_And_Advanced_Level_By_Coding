namespace PartialClass
{
    public partial class Person
    {
        // Methods
        public void Welcome()
        {
            Console.WriteLine($"Hi {_firstName} {_lastName}");
        }
    }
}