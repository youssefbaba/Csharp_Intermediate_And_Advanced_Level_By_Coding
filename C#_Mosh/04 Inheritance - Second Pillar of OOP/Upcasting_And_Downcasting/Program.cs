using System.Collections;
using System.Diagnostics;

namespace Upcasting_And_Downcasting
{
    public class Program
    {
        static void Main(string[] args)
        {


            /*
             
             - BaseClass ---- Conversion to ---- DerivedClass : DownCasting => Explicit Conversion and it can be throw an InvalidCastException
             - DerivedClass ---- Conversion to ---- BaseClass : UpCasting => Implicit Conversion
             - is operator returns true if an object can be cast to a specific type , otherwise false
             - as operator attempts to cast an object to a specific type , and return null if it fails
             
             
             */

            Text text = new Text();
            Shape shape = text;     // UpCasting => Implicit Conversion from Text type to Shape type
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);


            StreamReader streamReaderOne = new StreamReader(new FileStream(@"C:\Users\Youssef Baba\Desktop\My_Computer\log.txt", FileMode.Open));     // UpCasting (Implicit conversion from FileStream to Stream)
            StreamReader streamReaderTwo = new StreamReader(new MemoryStream());     // UpCasting (Implicit conversion from MemoryStream to Stream)


            ArrayList arrayList= new ArrayList();
            arrayList.Add(100);         // UpCasting (Implicit conversion from int to object)
            arrayList.Add("Hello");     // UpCasting (Implicit conversion from string to object)  
            arrayList.Add(new Text());  // UpCasting (Implicit conversion from Text type to object)



            Shape shape1 = new Text();
            Console.WriteLine($"The type of shape1 at compile time = {shape1.GetType().Name}");     // Text
            Console.WriteLine($"The type of shape1 at run time = {GetRunTimeType(shape1)}");        // Shape
            ((Text)shape1).FontSize = 18;       // DownCasting => (Explicit conversion from Shape type to Text type)
            Console.WriteLine($"FontSize of text = {((Text)shape1).FontSize}");     // DownCasting => (Explicit conversion from Shape type to Text type)
        }
        public static string GetRunTimeType<T>(T value)
        {
            return typeof(T).Name;
        }

    }
}