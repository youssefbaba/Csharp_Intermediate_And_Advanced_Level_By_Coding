namespace Abstract_Classes_Methods_Part1
{
    internal class Program
    {
        /*
         - A method with abstract keyword and without method body is known as an abstract method , what the method contains is only declaration of the method.
         - For example : 
                - public void Add(int number1 , int number2) { - Some Logic Here ...}  // Non-abstract method
                - public abstract void Add(int number1 , int number2); // abstract method
         - A class under which we define abstract methods is known as an abstract class.
         - To define a method or class as abstract we require to use the abstract keyword on them .
         - If a method is declared as abstract under an abstract class then the child class of that class is responsible for implementing the method , without fail.
         - Abstract class contains abstract methods and non-abstract methods .
         - Non-abstract class contains only non-abstract methods.
         - The concept of implementaion abstract methods is similar to the concept of method overriding .
         - If i have child class of abstract class : 
                1- Implement each and every abstract method of parent class.
                2- Now only we can consume non-abstract methods of parent class.
         - We cannot create an instance of the abstract class , so an abstract class it's not meant to be instantiated, it is meant to be derived.

         */
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();
            child.Add(10, 20);
            child.Sub(20,15);
            child.Div(14,125);
            child.Mul(145,12);

            Console.WriteLine();

            AbstractParent parent = child; // parent is an reference of parent class that is created by using child class instance.
            parent.Add(10, 20);
            parent.Sub(20, 15);
            parent.Div(14, 125);
            parent.Mul(145, 12);

        }
    }
}