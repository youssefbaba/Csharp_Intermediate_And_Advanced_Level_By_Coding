using Microsoft.CSharp.RuntimeBinder;
using System.Reflection;
using System.Reflection.Metadata;

namespace Dynamic_Keyword_Part2
{
    public class Program
    {
        /*
         - Programming Languages : 
            - Static languages : C# , Java , ....
            - Dynamic languages : Php , Python , JavaScript ....
         - Type Resolution :
            - Static Languages : Resolution of types , members , properties , methods is done at compile-time
            - Dynamic Languages : Resolution of types , members , properties , methods is done at run-time
        - Benefits :
            - Static languages : early feedback (compile-time)
            - Dynamic languages : easier and faster to code.
        - Dynamic type can take any data type without constraints.

         */
        static void Main(string[] args)
        {

            object obj = "David";
            int hasCode = obj.GetHashCode();
            Console.WriteLine($"HashCode = {hasCode}");

            Console.WriteLine();

            // Using Reflection : 
            object obj1 = "Marks Pedri";
            MethodInfo parameterlessMethodHashCode = obj1.GetType().GetMethods().FirstOrDefault(m => m.Name == "GetHashCode" && m.GetParameters().Count() == 0);
            int hashCode = (int)parameterlessMethodHashCode.Invoke(obj1, null);
            Console.WriteLine($"HashCode = {hashCode}");

            Console.WriteLine();

            // Using dynamic keyword : it's much cleaner and easier
            dynamic obj2 = "Hello world";
            Console.WriteLine($"HashCode = {obj2.GetHashCode()}");

            Console.WriteLine();

            // Optimize() method should be able at run-time.
            /*
            object excelObject1 = "Excel Object";
            excelObject1.Optimize();        // Compile-time error , because object data type does not contain a definition for Optimize method
            */

            // Using Reflection : 
            try
            {
                object excelObject2 = "Excel Object";
                MethodInfo methodOptimize = excelObject2.GetType().GetMethod("Optimize");
                methodOptimize.Invoke(excelObject2, null);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.WriteLine();

            // Using dynamic keyword : it's much cleaner and easier
            try
            {
                dynamic excelObject3 = "Excel Object";
                excelObject3.Optimize();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.WriteLine();

            dynamic name = "David";
            Console.WriteLine($"Type = {name.GetType().Name} & Value = {name}");
            name = 10;
            Console.WriteLine($"Type = {name.GetType().Name} & Value = {name}");

            Console.WriteLine();

            try
            {
                dynamic text = "Hello";
                text++;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.WriteLine();

            dynamic number1 = 10;
            dynamic number2 = 15;
            var sum = number1 + number2;
            Console.WriteLine($"Type at run-time = {sum.GetType().Name} & Value = {sum}");

            // Implicit Conversion :
            dynamic dynamicInt1 = 123;
            double numberDouble1 = dynamicInt1;     // Implicit Conversion from dynamic type that has integer value to static double data type 
            Console.WriteLine($"dynamicInt1 = {dynamicInt1} & numberDouble1 = {numberDouble1}");

            Console.WriteLine();

            // Explicit Casting : 
            try
            {
                dynamic dynamicDouble1 = 145.68;
                //int numberInt1 = dynamicDouble1;      // throws an nexception at run-time
                int numberInt1 = (int)dynamicDouble1;
                Console.WriteLine($"dynamicDouble1 = {dynamicDouble1} & numberInt1 = {numberInt1}");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

    }
}