using Access_Specifier_Demo1;
namespace Access_Specifier_Demo2
{
    // Case 4 : Consuming members of a class from child class of different project

    internal class FourthClass : FirstClass
    {
        static void Main(string[] args)
        {
            FourthClass fourthClass = new FourthClass();
            fourthClass.ProtectedMember();
            fourthClass.ProtectedInternalMember();
            fourthClass.PublicMember();
        }
    }
}