namespace Dynamic_Keyword_Part3
{
    public class Program
    {
        /*
         - object is data type , dynamic is data type , var is not data type .

         - Object type internally behaves as a dynamic type, only for dynamic type checking is done at runtime, but for object type it is done at compile time.

         - The dynamic type enables the operations in which it occurs to bypass compile-time type checking. Instead, these operations are resolved at run time. 

         - The dynamic type simplifies access to COM APIs such as the Office Automation APIs, and also to dynamic APIs such as HTML Document Object Model (DOM).

         - Type dynamic behaves like type object in most circumstances. However, operations that contain expressions of type dynamic are not resolved or type-checked by the compiler. 
           The compiler packages together information about the operation and that information is later used to evaluate the operation at run time. 

         - As part of the process, variables of type dynamic are compiled into variables of type object. Therefore, type dynamic exists only at compile-time, not at run time.

         */
        static void Main(string[] args)
        {

            object object1, object2, object3;
            object1 = 10;
            object2 = 20;
            //object3 = object1 + object2;        // Compile-time error , becausewe cannot applied operand + to object data type.


            dynamic dynamic1 , dynamic2 , dynamic3 , dynamic4 , dynamic5 ;
            dynamic1 = 10;
            dynamic2 = 20;
            dynamic3 = "Number ";
            dynamic4 = dynamic1 + dynamic2;     // Addition operation
            Console.WriteLine(dynamic4);    
            dynamic5 = dynamic3 + dynamic4;     // Concatenation operation
            Console.WriteLine(dynamic5); 
            

            Demo demo = new Demo();
            int number = demo.Foo();
            Console.WriteLine(number);


            object object4 = new Demo();
            //int number1 = object4.Foo();        // Compile-time error , because object data type does not contain a definition of Foo method.
            //Console.WriteLine(number1);


            dynamic dynamic6 = new Demo();
            int number2 = dynamic6.Foo();
            Console.WriteLine(number2);


            try
            {
            dynamic dynamic7 = new Demo();  
            int number3 = dynamic7.Foo1();
            Console.WriteLine(number3);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}