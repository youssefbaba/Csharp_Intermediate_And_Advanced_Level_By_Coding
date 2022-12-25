
namespace Method_Overriding_Test1
{
    internal class BranchManager : Manager
    {
        public BranchManager(double salary, string designation, string name, int age) : base(salary, designation, name, age)
        {
        }
        //public sealed override void Display() // keyword sealed : cannot override sealed inherited member
        //{
        //    Console.WriteLine($"Is branch manager");
        //}
    }
}
