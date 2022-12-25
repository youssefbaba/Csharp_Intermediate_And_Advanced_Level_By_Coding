
namespace Access_Specifier_Demo1
{
    // Case 2 : Consuming members of a class from child class of same project
    internal class SecondClass : FirstClass  // Internal class
    {
        static void Main()
        {
            SecondClass secondClass = new SecondClass();
            secondClass.InternalMember();
            secondClass.ProtectedMember();
            secondClass.ProtectedInternalMember();
            secondClass.PrivateProtectedMember();
            secondClass.PublicMember();
        }
    }
}
