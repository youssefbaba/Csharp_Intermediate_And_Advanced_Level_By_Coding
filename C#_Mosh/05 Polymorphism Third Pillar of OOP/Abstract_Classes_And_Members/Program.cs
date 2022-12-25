namespace Abstract_Classes_And_Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
 
             - Abstract Modifier: - can be applied to class and its members (Fields , Methods , Properties)
                                  - Indicates that a class or member is missing implementation
            
             - Abstract method don't include implementation just declaration. 
             - If a member is declared as abstract , the containing class needs to be declared as abstract too. 
             - Must implement all abstract memebers in the base class abstract , before consuming no abstrat members.
             - Abstract class cannot be instantiated.
            
             */


            Circle circle = new Circle();
            circle.Draw();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();

            //Shape shape = new Shape();  // we cannot instantiate abstract class
            Shape shape1 = new Rectangle();
            shape1.Draw();  // Draw method that is inside Rectangle class

            Shape shape2 = new Circle();
            shape2.Draw();  // Draw method that is inside Circle class


        }
    }
}