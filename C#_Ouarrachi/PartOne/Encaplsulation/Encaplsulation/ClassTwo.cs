namespace Encaplsulation
{
    //Case 2 : Consuming members of a class from child class of same assembly.
    public class ClassTwo : Program
    {
        static void Main(string[] args)
        {
            ClassTwo classTwo = new ClassTwo();
            // classTwo.Test1();  //  we cannot access to Test1() method because it is private
            classTwo.Test2();
            classTwo.Test3();
            classTwo.Test4();
            classTwo.Test5();
                
        }
    }
}