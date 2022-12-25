namespace BaseKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - Base keyword provides access to the members of parent class.
             - We use the base keyword to explicitly call the parameterized constructor of the parent class from the constructor of the child class.
             - The absence of a call to a constructor of the parent class in the constructor of a child class implicitly leads to a call to the parameter-less constructor of this parent class.
             */

            Circle circle1 = new Circle();
            circle1.Display();
            Circle circle2 = new Circle(10, 20, 30.5);
            circle2.Display();

        }
    }
    
}