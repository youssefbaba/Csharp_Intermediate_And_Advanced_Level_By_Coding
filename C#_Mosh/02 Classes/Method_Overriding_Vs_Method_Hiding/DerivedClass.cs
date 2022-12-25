
namespace Method_Overriding_Vs_Method_Hiding
{
    public class DerivedClass : BaseClass
    {
        // Methods
        public override void PrintOne() // Method Overriding
        {
            Console.WriteLine($"I am a Derived Class From PrintOne");
        }

        public new void PrintTwo() // Method Hiding
        {
            Console.WriteLine($"I am a Derived Class From PrintTwo");
        }
    }
}
