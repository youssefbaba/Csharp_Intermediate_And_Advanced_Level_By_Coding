using System.Reflection;

namespace Reflection_Part4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Youssef Baba\Desktop\My_Computer\My-Projects\Cours\Csharp_Intermediate\C#_Ouarrachi\PartFive\Reflection\PrintDataBase\bin\Debug\net6.0\PrintDataBase.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            foreach (Type type in assembly.GetTypes().Where(t => t.Name == "Employee"))
            {
                Console.WriteLine($"Type : {type.Name}");
                Console.WriteLine("============================================");
                var employee = Activator.CreateInstance(type);
                foreach (FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                    Console.WriteLine($"Field : {field.Name}");
                    field.SetValue(employee, "John Doe");
                    string name = (string)field.GetValue(employee);
                    Console.WriteLine($"Value of {field.Name} : {name}");
                }
                Console.WriteLine("============================================");
                foreach (MethodInfo method in type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(m => !m.IsSpecialName))
                {
                    Console.WriteLine($"Method : {method.Name}");
                    if (method.GetParameters().Length > 0)
                    {
                        method.Invoke(employee, new object[] { "Marks Huge" });
                    }
                    else if (method.ReturnType.Name != "Void")
                    {
                        var returnedValue = method.Invoke(employee, null);
                        Console.WriteLine(returnedValue);
                    }
                    else
                    {
                        method.Invoke(employee, null);
                    }
                }
                Console.WriteLine("============================================");
                foreach (PropertyInfo property in type.GetProperties())
                {
                    Console.WriteLine($"Property : {property.Name}");
                    var propertyValue = property.GetValue(employee);
                    Console.WriteLine($"Value of {property.Name} : {propertyValue}");
                }
            }

        }
    }

}