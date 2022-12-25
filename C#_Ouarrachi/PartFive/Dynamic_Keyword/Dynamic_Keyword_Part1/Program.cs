using Microsoft.CSharp.RuntimeBinder;
using System.Reflection;

namespace Dynamic_Keyword_Part0
{
    public class Program
    {
        /*
         - In C# we have two types :
            - Static types (built-in types(int , double , string , bool , DateTime , ... or user-defined types) : Type checking and type safety are enforced at compile-time.
            - Dynamic types (introduced in C# 4 for writing dynamic code) : Type checking and type safety are enforced at run-time.
         - The compile time checking of the code is called static binding.
         - Conversion from static types (int , double , string ...) to dynamic types and vice versa does not require an axplicit cast these conversions are done implicitly.
         - Type Conversions : 
            - No potential of Data Loss :
                - Implicit conversion are allowed.
                - True with both static type and dynamic type in C#.
            - There Is Data Loss
                - Converting large data types to small data types.
                - Implicit conversions are not allowed 
                - Can result in data loss
                - Explicit cast can be used for both static type and dynamic type .
         - Dynamic type can take any data type. 
            - For Example : dynamic dynamicInt = 12;
                            dynamic dynamicDouble = 15.69;
                            dynamic dynamicString = "Hello";
          - Benefits of Dynamic : 
            - Simplifies processing JSON API Data .
            - Interoperate with IronRuby , IronPython etc...
            - COM Interoperability is simpler and easier .
            - Easier to write and maintain reflection code .

         
         */
        static void Main(string[] args)
        {

            int intNumber1 = 100;
            double doubleNumber1 = intNumber1;      // Implicit Conversion withot data loss because (range of int < range of double)
            Console.WriteLine($"intNumber1 = {intNumber1} & doubleNumber1 = {doubleNumber1}");

            Console.WriteLine();

            double doubleNumber2 = 10.254;
            int intNumber2 = (int)doubleNumber2;    // Explicit casting with data loss because (range of double > range of int)
            Console.WriteLine($"doubleNumber2 = {doubleNumber2} & intNumber2 = {intNumber2}");

            Console.WriteLine();

            string str = "Hello World";
            Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.NonExistingMethod());     // Compile-time error : because string data type does not contain a definition of NonExistingMethod Method. 

            Console.WriteLine();

            dynamic dynamicString1 = "John Doe";
            Console.WriteLine(dynamicString1.ToUpper());
            try
            {
                Console.WriteLine(dynamicString1.NonExistingMethod());
            }
            catch (RuntimeBinderException)
            {
                Console.WriteLine("string data type does not contain a definition for NonExistingMethod method");
            }

            Console.WriteLine();

            dynamic dynamicString2 = "Marks Pedri";
            Console.WriteLine($"Type at run time = {dynamicString2.GetType().Name} & Value of dynamicString2 = {dynamicString2}");
            dynamic dynamicInt1 = 1002;
            Console.WriteLine($"Type at run time = {dynamicInt1.GetType().Name} & Value of dynamicString2 = {dynamicInt1}");

            Console.WriteLine();

            int intNumber3 = 123;
            dynamic dynamicInt2 = intNumber3;       // Implicit Conversion from static int data type to dynamic type which will have int value.
            Console.WriteLine($"intNumber3 = {intNumber3} & dynamicInt2 = {dynamicInt2}");

            Console.WriteLine();

            dynamic dynamicInt3 = 120;
            int intNumber4 = dynamicInt3;           // Implicit Conversion from dynamic type which has integer value to static int data type.
            Console.WriteLine($"dynamicInt3 = {dynamicInt3} & intNumber4 = {intNumber4}");

            Console.WriteLine();

            User user1 = new User { Name = "Sam", Age = 25 };
            dynamic dynamicUser1 = user1;
            Console.WriteLine($"Name = {dynamicUser1.Name} & Age = {dynamicUser1.Age}");

            Console.WriteLine();

            dynamic dynamicUser2 = new User { Name = "Jim", Age = 30 };
            User user = dynamicUser2;
            Console.WriteLine($"Name = {user.Name} & Age = {user.Age}");

            Console.WriteLine();

            // Implicit Conversion : 
            int intNumber6 = 159;
            double doubleNumber3 = intNumber6;
            Console.WriteLine($"intNumber6 = {intNumber6} & doubleNumber3 = {doubleNumber3}");

            Console.WriteLine();

            dynamic dynamicInt5 = 189;
            double doubleNumbe3 = dynamicInt5;
            Console.WriteLine($"dynamicInt5 = {dynamicInt5} & doubleNumbe3 = {doubleNumbe3}");

            Console.WriteLine();

            // Explicit Casting : 
            double doubleNumber5 = 145.36;
            //int intNumber7 = (int)doubleNumber5;        // Compile-time error : cannot implicitly convert type double to int
            int intNumber7 = (int)doubleNumber5;       
            Console.WriteLine($"doubleNumber5 = {doubleNumber5} & intNumber7 = {intNumber7}");

            Console.WriteLine();

            dynamic dynamicDouble2 = 14.58;
            try
            {
                //int intNumbe8 = dynamicDouble2;             // run-time exception
                int intNumbe8 = (int)dynamicDouble2;
                Console.WriteLine($"dynamicDouble2 = {dynamicDouble2} & intNumbe8 = {intNumbe8}");
            }
            catch (RuntimeBinderException)
            {
                Console.WriteLine("cannot implicitly convert type double to int.");
            }

            Console.WriteLine();


            // Using Reflection :
            Type type = Type.GetType("Dynamic_Keyword_Part0.Calculator");
            MethodInfo methodAdd = type.GetMethod("Add");
            object typeInstance = Activator.CreateInstance(type);
            int result = (int)methodAdd.Invoke(typeInstance, new object[] { 10, 20 });
            Console.WriteLine($"The result = {result}");

            Console.WriteLine();

            // Simplify reflection by using dynamic :
            dynamic calculator = Activator.CreateInstance(Type.GetType("Dynamic_Keyword_Part0.Calculator"));
            dynamic result1 =  calculator.Add(10, 20);
            Console.WriteLine($"The result = {result1}");


        }
    }
}