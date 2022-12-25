using Encaplsulation;

namespace EncapsulationDemo
{
    //Case 5 : Consuming the members of a class from non-child class of another assembly.
    public class ClassFive
    {
        static void Main(string[] args)
        {
            Program program= new Program();
            program.Test5();
        }
    }
}