namespace Properties_Part1
{
    public class CircleTest
    {
        /*
         - Property is a member of class using which we can expose values associated with a class to the outside environment.
         - Never declare field as public
         - [<modifiers>] <type> <name>
            {
               get { <Statements> }     // Get Accessor
               set { <Statements> }     // Set Accessor
            }
         - First advantage of properties is : Access restriction : Readonly property , Writeonly property , ReadWrite property
         - Second advantage of properties is : Conditional access , Conditional assignment


         */
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            /*
            double radius = circle.GetRadius();     // Getting the old value
            circle.SetRadius(56.81);            // Setting a new value
            */

            double Radius = circle.Radius;
            circle.Radius = 10.24;
            Console.WriteLine($"Radius = {circle.Radius}");
            circle.Radius = 56.12;
            Console.WriteLine($"Radius = {circle.Radius}");




        }
    }
}