namespace Polymorphism
{
    internal class Manager : Employee
    {
        // Methods
        public override void Show()
        {
            Console.WriteLine("Manager");
        }
        public override string ToString()
        {
            return $"ToString Method from Manager class";
        }
    }
}
