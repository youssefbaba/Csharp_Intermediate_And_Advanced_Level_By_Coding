using System.Collections;

namespace Boxing_And_Unboxing
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - The Object class is the base class of all classes in .Net
             - Boxing is the process of converting a value type instance to an object reference
             */

            Text text = new Text();
            Shape shape = text;     // UpCasting (Implicit Conversion from Text type to Shape type)
            object obj = text;      // UpCasting (Implicit Conversion from Text type to object type)


            int amount = 10;
            object obj1 = amount;   // Boxing => conversion from value type to an object reference
            //object obj1 = 10;   // Boxing => conversion from value type to an object reference
            int value = (int)obj1;  // Unboxing => conversion from an object reference that is already boxed to a compatible value type
            Console.WriteLine(value);


            // ArrayList it's not typesafe
            ArrayList arrayList= new ArrayList();
            arrayList.Add(100);     // Boxing => conversion from value type to an object reference
            arrayList.Add("Hello"); // UpCasting => Implicit Conversion from string to object
            arrayList.Add(DateTime.Today.ToShortDateString());  // Boxing => conversion from value type to an object reference

            //int number = (int)arrayList[1];  // Throwing InvalidCastException
            int number = (int)arrayList[0];     // Unboxing
            Console.WriteLine(number);


            // a better way is to use a Generic List instide of arrayList => because it is typesafe and no headache of Casting and Boxing/Unboxing and also they dercease the performance of the application
            List<int> listnumbers = new List<int>(); // All elements must be of type int
            listnumbers.Add(100);
            listnumbers.Add(200);
            listnumbers.Add(300);

            List<string> listnames= new List<string>(); // All elements must be of type string
            listnames.Add("John Doe");
            listnames.Add("David Alaba");
            listnames.Add("Marks Huge");

        }
    }
}