namespace Encaplsulation
{
    public class ClassThree
    {
        //Case 3 : Consuming the members of a class from non-child class of same assembly.
        static void Main(string[] args)
        {
            Program program = new Program();
            // program.Test1();  // we cannot access to Test1() method because it is private
            program.Test2();
            // program.Test3(); // we cannot access to Test2() method because it is protected
            program.Test4();
            program.Test5();
            
        }
    }

}