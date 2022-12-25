namespace Encaplsulation
{

    //Case 1 : Consuming members of a class from same class .
    //private class Program  // Error: Elements declared in a namespace explicitly cannot be private , protected , protected internal , private protected
    public class Program    // classes , records  , structs that is declared directly in a namespace can be public or internal and the default value is internal
    {
        /*
         - link : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
         - Access modifiers : it's a special kind of modifiers using which we can define the scope of type and it's members
         - Csharp supports 5 access modifiers and each one has a different scope :
            - private : member is accessible only within the type in which it was defined.
            - internal : type or member can be accessed from anywhere inside the same assembly.
            - protected : type or member can be accessed within the same class or from child class
            - protected internal : type or member can be accessed within the same class or from child class or from anywhere inside the same assembly.
            - public : member accessible from anywhere
         - The important point to remember is a member of a class that is defined with any scope (private by default) is always accessible within the class , if there are any restrictions , the restriction will start when we go outside the class
         - Every member of a class and struct is private by default.
         - Classes, records, and structs declared directly within a namespace can be either public or internal. internal is the default if no access modifier is specified.



         */



        // Methods
        private void Test1()
        {
            Console.WriteLine("Private Method.");
        }
        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Method.");
        }
        public void Test5()
        {
            Console.WriteLine("Public Method.");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Test1();
            program.Test2();
            program.Test3();
            program.Test4();
            program.Test5();
        }
    }

}