namespace Interfaces_Part2
{
    public class Program
    {
        /*
         - CSharp doesn't support multiple inheritance from classes , but it supports multiple implementation of interfaces.
         - A class can have one and only one immediate parent class , whereas the same class can have any number of implemented interfaces.
         - We can implement members of interface with two ways :
            - Normal imlementation : you can call it by using the instance of the type that implements that interface and by reference created by using instance of the type that implements that interface .
            - Explicit implementation : you can call it only  by using the reference created by using instance of the type that implements that interface .

         */
        static void Main(string[] args)
        {
            MultipleImplementation obj = new MultipleImplementation();
            obj.Test();
            Interface1 obj1 = new MultipleImplementation();
            obj1.Show();
            Interface2 obj2 = new MultipleImplementation();
            obj2.Show();
        }
    }
}