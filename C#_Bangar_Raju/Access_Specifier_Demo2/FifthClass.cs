using Access_Specifier_Demo1;
namespace Access_Specifier_Demo2
{
    // Case 5 : Consuming members of a class from non-child class of different project

    internal class FifthClass
    {
        static void Main()
        {
            FirstClass firstClass = new FirstClass();
            firstClass.PublicMember();
        }
    }
}
