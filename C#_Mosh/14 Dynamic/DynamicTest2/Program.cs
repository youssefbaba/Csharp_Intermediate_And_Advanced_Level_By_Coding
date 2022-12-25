using System.Reflection;

namespace DynamicTest2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - Programming Languages :
                - Statically-typed languages : C# , Java ..
                - Dynamically-typed languages : Ruby , Python , JavaScript ...

             - Static languages : Resolution of types , members , properties , methods is done at compile-time
             - Dynamic languages : Resolution of types , members , properties , methods is done at run-time
             - Conversion from Static Types to Dynamic Types and vice versa is implicitly.
             - No Data Loss => Implicit Conversion : True for both Static Types and Dynamic Types
             - There is Data Loss => Explicit Conversion : in the case of Static Types an error will throw at compile-time , but in the case of Dynamic Types an Exception will throw at run-time
             */

            // Reflection :
            object obj1 = "Youssef";
            object result = obj1.GetType().InvokeMember("GetHashCode", BindingFlags.InvokeMethod, null, obj1, null);
            Console.WriteLine(result);


            object obj2 = "Youssef";
            Console.WriteLine(obj2.GetHashCode());


            dynamic dyn = "Youssef";
            Console.WriteLine(dyn.GetHashCode());


            object excelObject = "Excel Object";
            Console.WriteLine($"At compile-time : {excelObject.GetType().Name}"); // String
            Console.WriteLine($"At run-time : {GetTypeAtRunTime(excelObject)}");  // Object
            //excelObject.Optimize();  // we get an error at compile-time , because Optimize() method there is not in object data type


            // Using Reflection for solving this problem : but this code it little bit difficult and messy .
            try
            {
                object excelObject1 = "Excel Object One";
                object obj = excelObject1.GetType().InvokeMember("Optimize", BindingFlags.InvokeMethod, null, excelObject1, null); // Throws an Exception at run-time 
                Console.WriteLine(obj);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            // Using Dynamic keyword for solving this problem and this is an easy way and much cleaner  
            try
            {
                dynamic excelObject2 = "Excel Object Two";
                excelObject2.Optimize(); // Throws an  Exception at run-time
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            // we can assign anu type to a dynamic types without issue.
            dynamic name = "John Doe";
            Console.WriteLine($"Type : {GetTypeAtRunTime(name)}"); // String
            Console.WriteLine($"Value : {name}");
            name = 100;
            Console.WriteLine($"Type : {GetTypeAtRunTime(name)}"); // Int32
            Console.WriteLine($"Value : {name}");
            name = true;
            Console.WriteLine($"Type : {GetTypeAtRunTime(name)}"); // Boolean
            Console.WriteLine($"Value : {name}");


            try
            {
                dynamic text = "Some text here...";
                text++;  //Throws an Exception at run-time : because ++ operator cannot applied to string data type
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            // var keyword : letting the compiler decide what type a given variable should be. 
            dynamic number1 = 10;
            dynamic number2 = 15;
            var sum = number1 + number2;
            Console.WriteLine(sum);


            int intValue1 = 100;
            dynamic dynamicValue1 = intValue1;    // Implicit Conversion from Static Types to Dynamic Types
            Console.WriteLine(dynamicValue1);


            dynamic dynamicValue2 = 10;
            int intValue2 = dynamicValue2;      // Implicit Conversion from Dynamic Types to Static Types
            Console.WriteLine(intValue2);


            // Implicit Conversion : Static Types
            int intNumber1 = 100;
            double doubleNumber1 = intNumber1;  // Implicit Conversion from int data type to double data type
            Console.WriteLine(doubleNumber1);


            // Implicit Conversion : Dynamic Types
            dynamic dynamicInt1 = 10;
            double doubleNumber2 = dynamicInt1; // Implicit Conversion from data type that is int type to static type that is double type
            Console.WriteLine(doubleNumber2);


            // Explicit Conversion : Static Types
            double doubleNumber3 = 12.5;
            // int intNumber3 = doubleNumber3; // An error at compile-time , because cannot implicitly convert double data type to int data typa
            int intNumber3 = (int)doubleNumber3; // Solution : Explicit Conversion from double data type to int data type , but there is Data Loss
            Console.WriteLine(intNumber3);


            try
            {
                dynamic dynamicDouble1 = 12.3;
                //int intNumber4 = dynamicDouble1; // An Exception at run-time , because cannot implicitly convert double data type to int data typa
                int intNumber4 = (int)dynamicDouble1;    // Solution : Explicit Conversion from double data type to int data type  , but there is Data Loss
                Console.WriteLine(intNumber4);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

        }
        static string GetTypeAtRunTime<T>(T value)
        {
            return typeof(T).Name;
        }

    }
}