using System.Data;

namespace Method_Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - Signature of a Method
                 - Name of method
                 - Number of parameters , Order of marameters , Type of parameters , Kind of parameters (ref , out , params)
            */

            /*
             - Overloading : having a method with the same name but different signatures
             - The signatures of the method does not include the return type and the params modifier , so it is not possible to overload method just based on return type or params modifier
            */


            UseOverloadMethod();
            UseParamsModifier();

            UseOutModifier();

        }

        private static void UseOutModifier()
        {
            //int number = int.Parse("abc");
            //Console.WriteLine(number);

            //try
            //{
            //    int number = int.Parse("abc");
            //    Console.WriteLine(number);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Conversion failed.");
            //}

            int number;
            bool resultConversion = int.TryParse("abc", out number);
            if (resultConversion)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        private static void UseParamsModifier()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine($"The result = {calculator.Add(new int[] { 1, 2, 3 })}");
            Console.WriteLine($"The result = {calculator.Add(new int[] { 1, 2, 3, 4, 5 })}");
            Console.WriteLine($"The result = {calculator.Add(1, 2, 3)}");
            Console.WriteLine($"The result = {calculator.Add(1, 2, 3, 4, 5)}");
        }

        private static void UseOverloadMethod()
        {
            try
            {
                Point point = new Point(10, 20);
                //point.Move(new Point(40,60));
                point.Move(null);
                Console.WriteLine($"Point is at ({point.X} , {point.Y})");


                point.Move(100, 200);
                Console.WriteLine($"Point is at ({point.X} , {point.Y})");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}