namespace Interfaces_Part1
{
    public class Program
    {
        /*
         - Class : it's a user-defined data type (it's a reference type).
         - Interface : this is also an user-defined data type only(it's a reference type).
         - Non-abstract class : contains only non-abstract methods (Methods with method body).
         - Abstract class : contains non-abstract methods (Methods with method body) and also abstract methods (Methods without method body just declaration).
         - Interface : contains only abstract methods (Methods without method body).
         - Every abstract method of an interface should be implemented by the class that implements that interface , without fail (mandatory).
         - Generally a class inherits from another class to consume the members of its parent , whereas if a class implements an interface it is to implement the members of that interface.
         - A class can inherit from a class and implement an interface simultaneously.
         - C# does not support multiple inheritance of classes but supports multiple implementation of interfaces.
         - <modifiers> interface <Name> { - Abstract member declarations here ...}
         - The default scope of the members of an interface is public , whereas it's private in case of a class.
         - Abstract method within abstract class => public abstract <Return type> <Name>(<Parameters>);
                For example : public abstract void Add(int number1 , int number2);
         - Abstract method within interface (by default it's public and abstract) => <Return type> <Name>(<Parameters>);
                For example : void Add(int number1 , int number2);
         - We can't declare any instance fields and constructors under an interface.
         - If required an interface can inherit from another interface.
         - We can't create an instance of the interface.
         - Every abstract method of an interface should be implemented by the class that implements that interface without fail (mandatory),
           but while implementing we dont require to use override modifier just like we have done in case of abstract class.
         


         */
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.Write("10 + 20 = ");
            calculator.Add(10, 20);
            Console.Write("30 - 20 = ");
            calculator.Sub(30, 20);

            Console.WriteLine();

            Interface2 obj = calculator; // Reference created by using the instance calculator.
            Console.Write("100 + 20 = ");
            obj.Add(100, 20);
            Console.Write("100 - 20 = ");
            obj.Sub(100, 20);



            Console.WriteLine($"X = {Interface1.X}");
        }
    }
}