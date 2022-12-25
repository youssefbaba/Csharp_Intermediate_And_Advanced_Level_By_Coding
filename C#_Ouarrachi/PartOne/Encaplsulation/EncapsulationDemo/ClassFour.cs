using Encaplsulation;

namespace EncapsulationDemo
{
    //Case 4 : Consuming the members of a class from child class of another assembly.
    public class ClassFour : Program
    {
        static void Main(string[] args)
        {
            ClassFour classFour= new ClassFour();
            //classFour.Test1();  // we cannot access to Test1() because it is private
            //classFour.Test2(); // we cannot access to Test2() because it is internal
            classFour.Test3();
            classFour.Test4();
            classFour.Test5();
        }
    }
}