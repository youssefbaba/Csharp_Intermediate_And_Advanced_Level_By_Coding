
namespace Method_Overriding_Vs_Method_Hiding
{
    public class BaseClass
    {
        // Methods
        public virtual void PrintOne()
        {
            Console.WriteLine($"I am a Base Class From PrintOne");
        }
        public virtual void PrintTwo()
        {
            Console.WriteLine($"I am a Base Class From PrintTwo");
        }
    }
}
