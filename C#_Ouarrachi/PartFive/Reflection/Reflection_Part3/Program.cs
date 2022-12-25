using System.Reflection;

namespace Reflection_Part3
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
            //Type type = Type.GetType("Reflection_Part3.Test");      // First way
            Type type = typeof(Test);     // Second Way
            //Type type = new Test().GetType();       // Third way
            Console.WriteLine($"Full Name Assembly : {type.Assembly.FullName}");
            Console.WriteLine($"Qualified Name Assembly : {type.AssemblyQualifiedName}");
            Console.WriteLine($"Namespace : {type.Namespace}");
            Console.WriteLine($"Full Name : {type.FullName}");
            Console.WriteLine($"Name : {type.Name}");

            Console.WriteLine();

            Console.WriteLine($"Members of Test class : ");
            MemberInfo[] members = type.GetMembers();
            foreach (MemberInfo member in members)
            {
                //Console.WriteLine(member);
                Console.WriteLine($"{member.MemberType} {member.Name}");
            }

            Console.WriteLine();

            Console.WriteLine("Fields of Test class : ");
            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
            {
                //Console.WriteLine($"{field}");
                Console.WriteLine($"{field.FieldType.Name} {field.Name}");
            }

            Console.WriteLine();

            Console.WriteLine($"Properties of Test class : ");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                //Console.WriteLine($"{property}");
                Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
            }

            Console.WriteLine();

            Console.WriteLine($"Methods of Test class : ");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                //Console.WriteLine($"{method}");
                Console.WriteLine($"{method.ReturnType.Name} {method.Name}");
                ParameterInfo[] parameters = method.GetParameters();
                foreach (ParameterInfo parameter in parameters)
                {
                    //Console.WriteLine($"  {parameter}");
                    Console.WriteLine($"  {parameter.ParameterType.Name} {parameter.Name}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Constructors of Test class : ");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine($"{constructor}");
            }


            Console.WriteLine("TestField field of Test class");
            FieldInfo field1 = type.GetField("TestField");
            Console.WriteLine($"{field1.FieldType.Name} {field1.Name}");

            Console.WriteLine();

            Console.WriteLine("TestProp property of Test class");
            PropertyInfo property1 = type.GetProperty("TestProp");
            Console.WriteLine($"{property1.PropertyType.Name} {property1.Name}");

            Console.WriteLine();

            Console.WriteLine("Test2 method of Test class");
            MethodInfo method1 = type.GetMethod("Test2");
            Console.WriteLine($"{method1.ReturnType.Name} {method1.Name}");

            Console.WriteLine();

            Console.WriteLine("Test constructor of Test class");
            ConstructorInfo constructor1 = type.GetConstructor(new Type[] { typeof(string) });
            Console.WriteLine(constructor1);

            Console.WriteLine();

            // To create an instance of Test class by using parameterless constructor :
            Test testInstance1 = (Test)Activator.CreateInstance(type);
            // To get the value of TestField field
            string str = (string)field1.GetValue(testInstance1);
            Console.WriteLine($"The value of TestField field = {str}");
            field1.SetValue(testInstance1, "NewTestString");            // To set the value of TestField field 
            string str1 = (string)field1.GetValue(testInstance1);
            Console.WriteLine($"The new value of TestField field = {str1}");

            Console.WriteLine();

            // To create an instance of Test class by using parameterized constructor :
            Test testInsatnce2 = (Test)Activator.CreateInstance(type, new object[] { "TestFieldString" });
            string str2 = (string)field1.GetValue(testInsatnce2);
            Console.WriteLine($"The value of TestField field = {str2}");
            field1.SetValue(testInsatnce2, "NewTestFieldString");       // To set the value of TestField field 
            string str3 = (string)field1.GetValue(testInsatnce2);
            Console.WriteLine($"The new value of TestField field = {str3}");

            Console.WriteLine();

            int number = (int)property1.GetValue(testInstance1);
            Console.WriteLine($"The value of TestProp property = {number}");
            property1.SetValue(testInstance1, 10);
            int number1 = (int)property1.GetValue(testInstance1);
            Console.WriteLine($"The new value of TestProp property = {number1}");

            Console.WriteLine();

            int number2 = (int)property1.GetValue(testInsatnce2);
            Console.WriteLine($"The value of TestProp property = {number2}");
            property1.SetValue(testInsatnce2, 20);
            int number3 = (int)property1.GetValue(testInsatnce2);
            Console.WriteLine($"The new value of TestProp property = {number3}");

            Console.WriteLine();

            PropertyInfo[] properties2 = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in properties2)
            {
                //Console.WriteLine($"{prop.PropertyType.Name} {prop.Name}");
                int value = (int)prop.GetValue(testInstance1);
                Console.WriteLine($"The value of {prop.Name} = {value}");
                prop.SetValue(testInstance1, 20);
                int value1 = (int)prop.GetValue(testInstance1);
                Console.WriteLine($"The new value of {prop.Name} = {value1}");
            }

            Console.WriteLine();

            // to invoke methods :
            MethodInfo test1Method = type.GetMethod("Test1");
            test1Method.Invoke(testInstance1, null);
            MethodInfo test2Method = type.GetMethod("Test2");
            int amount = (int)test2Method.Invoke(testInstance1, null);
            Console.WriteLine(amount);
            MethodInfo test3Method = type.GetMethod("Test3");
            test3Method.Invoke(testInstance1, new object[] { "Hello Youssef" });

            Console.WriteLine();
        }
    }
}