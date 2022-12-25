using System.Security;

namespace Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              - In C# a Value Type cannot have a null value
             
            */

            // Nullable<DateTime> date1 = null;
            DateTime? date1 = null;     // Nullable Value Type


            // Members of Nullable Type :
            DateTime? date2 = null;
            Console.WriteLine($"GetValueOrDefault() : {date2.GetValueOrDefault()}");
            Console.WriteLine($"HasValue : {date2.HasValue}");
            try
            {
                Console.WriteLine($"Value : {date2.Value}");
            }
            catch (InvalidOperationException exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            DateTime? date3 = new DateTime(2014, 12, 28);
            Console.WriteLine($"GetValueOrDefault() : {date3.GetValueOrDefault()}");
            Console.WriteLine($"HasValue : {date3.HasValue}");
            try
            {
                Console.WriteLine($"Value : {date3.Value}");
            }
            catch (InvalidOperationException exp)
            {
                Console.WriteLine(exp.Message);
            }


            Console.WriteLine();
            Console.WriteLine();


            DateTime? date4 = null;
            DateTime date5 = date4.GetValueOrDefault();
            Console.WriteLine(date5);
            DateTime? date6 = new DateTime(2014, 10, 19);   // From non-nullable value type to nullable value type => Implicit Casting
            DateTime date7 = date6.GetValueOrDefault();
            Console.WriteLine(date7);


            Console.WriteLine();
            Console.WriteLine();



            // Null Coalescing Operator
            DateTime? date8 = null;
            DateTime date9 = (date8 != null) ? date8.GetValueOrDefault() : DateTime.Now;  // Ternary Operator
            DateTime date10 = date8 ?? DateTime.Now.AddDays(1);
            Console.WriteLine(date9);
            Console.WriteLine(date10);



        }
    }
}