using IronPython.Hosting;
using IronPython.Runtime.Exceptions;
using Microsoft.Scripting.Hosting;
using Newtonsoft.Json;
using System.Dynamic;

namespace Dynamic_Keyword_Part4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";
            Console.WriteLine(text.ToUpper());
            //text = 10;      // Compile-time error , because connot implicitly convert int to string


            dynamic name = "David";
            Console.WriteLine($"Type = {name.GetType().Name}  Value = {name}");
            name = 20;      // Because dynamic type can take any type without issue
            Console.WriteLine($"Type = {name.GetType().Name}  Value = {name}");


            ScriptRuntime pythonRuntime = Python.CreateRuntime();
            dynamic pythonFile = pythonRuntime.UseFile("Test.py");
            pythonFile.SayHelloToPython();
            

            dynamic obj = new ExpandoObject();
            obj.Name = "Marks";
            obj.Age = 30;
            Console.WriteLine($"Name = {obj.Name}  Age = {obj.Age}");


            Json1();
        }

        static void Json1()
        {
            string data = File.ReadAllText(@"sample.json");
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(data);
            foreach (var item in obj)
            {
                var name = item.Name;
                var value = item.Value;
                Console.WriteLine($"{name} {value}");
                if (name == "prog")
                {
                    item.Value.Add("Java");
                }
            }
            string str = JsonConvert.SerializeObject(obj);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
        }
    }
}