namespace PartialMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - Link 1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
             - Link 2 : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/partial-method
             - A partial method must be declared within a partial class or partial struct , a non partial class or struct cannot include partial methods.
             - A partial method is created using the partial keyword.
             - A partial method declaration consists of two parts : 
                    - The definition (Only the method signature)
                    - The implementation

                - These may be in separate parts of a partial class , or in the same part

             - If the The implementation for partial method is optional , and if we don't provide the implementation , the compiler removes the signature and all calls to the method.
             - It is a compile time error , to include declaration and implementation at the same time for a partial method  => it is an error to have implmentation without declaration
             - A partial method return type must be void if we don't have any access modifier, otherwise we  can use any return type
             - Signature of the partial method declaration must match with the signature of the implementation
             - A partial method can be implemented only once , trying to implement a partial method more than once , raises a complie time error


             */

            SamplePartialClass obj = new SamplePartialClass();
            obj.NonPartialMethod();

            DerivedClassFromSamplePartialClass obj1 = new DerivedClassFromSamplePartialClass(); 
            obj1.SamplePartialMethodOne();



        }
    }
}