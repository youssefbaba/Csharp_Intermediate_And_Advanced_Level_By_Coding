using System.Reflection;

namespace Reflection_Part1
{
    /*
     - Reflection is the ability of inspecting an assemblies metadata at runtime. it is used to find all types in an assembly and/or dynamically invoke methods in an assembly.
     - Uses of reflection : 
        - 1 : When you drag and drop a button on windows from or WPF.the properties windows uses reflection to show all the properties of the Button class.
              So reflection is extensively used by IDE or a UI designers.
        - 2 : Late binding can be achieved by using reflection , You can use reflection to dynamically create an instance of a type , about which we don't have any information at compile-time ,
              So reflection anables you to use code that is not available at compile-time .
     






     */
    public class TestCustomer
    {
        static void Main(string[] args)
        {

            // how to inspect assembly metadata and use reflection framework provided by .Net framework to inspect that assemblies methods , properties , constructors , etc ...
            Type type = Type.GetType("Reflection_Part1.Customer");      // First way
            // Type type = typeof(Customer);                              // Second way
            //Type type = new Customer().GetType();                         // Third way
            Console.WriteLine($"Information about the customer class : ");
            Console.WriteLine($"Full Name = {type.FullName}");
            Console.WriteLine($"Just the Name = {type.Name}");
            Console.WriteLine($"Just the Namespace = {type.Namespace}");

            Console.WriteLine();

            Console.WriteLine($"Information about properties of the customer class : ");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"Type = {property.PropertyType.Name} & Name = {property.Name}");
            }

            Console.WriteLine();

            Console.WriteLine("Information about methods of the customer class : ");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"Return Type = {method.ReturnType.Name} & Name = {method.Name}");
            }

            Console.WriteLine();

            Console.WriteLine("Information about constructors of the customer class : ");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                //Console.WriteLine($"{constructor.Name}");
                Console.WriteLine($"{constructor}");
            }
        }
    }
}