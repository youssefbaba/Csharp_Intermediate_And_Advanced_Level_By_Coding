
namespace Access_Specifier_Demo1
{
    // Case 3 : Consuming members of a class from non-child class of same project
    internal class ThirdClass // Internal class 
    {
        
       static void Main()
        {
            FirstClass firstClass = new FirstClass();
            firstClass.InternalMember();
            firstClass.ProtectedInternalMember();
            firstClass.PublicMember();
        }
       
    }
}
