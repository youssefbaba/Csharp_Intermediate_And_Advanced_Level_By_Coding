using System.Reflection;

namespace Reflection_Part2
{
    public class Program
    {
        /*
         - if i want to get the structure or any detail information about particular assembly or a type , we can use Reflection.
         - Reflection is used to obtaining type information at run-time.
         - System.Reflection namespace contains classes that allow you to obtain information about the application ,
           and to dynamically add types , values and objects to the application.
         */
        static void Main(string[] args)
        {


            /*
            string path = @"C:\Users\Youssef Baba\Desktop\My_Computer\My-Projects\Cours\Csharp_Intermediate\C#_Ouarrachi\PartFive\Reflection\Reflection_Part2\bin\Debug\net7.0\Reflection_Part2.dll";
            Assembly assembly = Assembly.LoadFile(path);
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine($"-- Type : {type.Name}");
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine($"---- Return Type : {method.ReturnType.Name} & Name : {method.Name}");
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (ParameterInfo parameter in parameters)
                    {
                        Console.WriteLine($"------ Type Parameter : {parameter.ParameterType.Name} & Name : {parameter.Name}");
                    }
                }
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"---- Type Property : {property.PropertyType.Name} & Name : {property.Name}");
                }
            }
            */


            /*
            Type type1 = typeof(string);
            Console.WriteLine($"-- Type : {type1.Name}");
            MethodInfo[] methods1 = type1.GetMethods();
            foreach (MethodInfo method in methods1)
            {
                Console.WriteLine($"---- Return Type : {method.ReturnType.Name} & Name : {method.Name}");
                ParameterInfo[] parameters1 = method.GetParameters();
                foreach (ParameterInfo parameter in parameters1)
                {
                    Console.WriteLine($"------ Type Parameter : {parameter.ParameterType.Name} & Name : {parameter.Name}");
                }
            }
            PropertyInfo[] properties1 = type1.GetProperties();
            foreach (PropertyInfo property in properties1)
            {
                Console.WriteLine($"---- Type Property : {property.PropertyType.Name} & Name : {property.Name}");
            }
            */


            Type type2 = new User().GetType();
            Console.WriteLine($"-- Type : {type2.Name}");
            MethodInfo[] methods2 = type2.GetMethods();
            foreach (MethodInfo method in methods2)
            {
                Console.WriteLine($"---- Return Type : {method.ReturnType.Name} & Name : {method.Name}");
                ParameterInfo[] parameters = method.GetParameters();
                foreach (ParameterInfo parameter in parameters)
                {
                    Console.WriteLine($"------ Prameter Type : {method.ReturnType.Name} & Name = {parameter.Name}");
                }
            }
        }
    }
}