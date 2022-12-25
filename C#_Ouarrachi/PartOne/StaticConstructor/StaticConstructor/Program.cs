namespace StaticConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             - Non-Static Constructor
                - public
                - initialisation non-static field
                - Explicit call
                - it may has parameters
             - Static Constructor
                - cannot take any access modifier , it is private by default
                - Implicit call
                - it calls when creation of instance or accessing to a static member
                - without parameter
                - it calls before non-satic constructor
                - it calls one time
             
             
             
         
             
             */
            Person person1 = new Person(1 , "David") ;  
            Person person2 = new Person(2 , "Marks") ;


            Car.NumberSeat();


        }
    }
}