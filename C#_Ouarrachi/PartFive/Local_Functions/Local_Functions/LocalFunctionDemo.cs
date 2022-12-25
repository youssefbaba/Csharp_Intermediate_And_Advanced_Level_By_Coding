using System.Runtime.CompilerServices;

namespace Local_Functions
{
    public class LocalFunctionDemo
    {
        /*
         - Anonymous method doesn't support :
            - Params
            - ref | out variables
            - Generics
         
         */

        /*
        private void AddNumbers(int number1, int number2)
        {
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }
        */
        static void Main(string[] args)
        {
            /*
            LocalFunctionDemo obj = new LocalFunctionDemo();    
            obj.AddNumbers(100, 20);
            obj.AddNumbers(10, 20);
            */

            // Local Function :
            void AddNumbers1(int number1, int number2)
            {
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            }
            AddNumbers1(10, 15);


            // Using anonymous method :
            Action<int, int> obj = delegate (int number1, int number2)
            {
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            };
            obj.Invoke(14, 16);


            void AddNumbers2(int number1, int number2, ref int number3, ref int number4)
            {
                number3 = number1 + number2;
                number4 = number1 * number2;
            }

            int addResult = 0;
            int mulResult = 0;
            AddNumbers2(110, 20, ref addResult, ref mulResult);
            Console.WriteLine($"110 + 20 = {addResult} & 110 * 20 = {mulResult}");


            /*
            // Compile-time Error because wa connot use ref keyword in anonymous method : 
            Action<int, int, ref int, ref int> obj1 = delegate (int number1, int number2, ref int number3, ref int number4)
            {
                number3 = number1 + number2;
                number4 = number1 * number2;
            };
            */


            void AddNumbers3(int number1, int number2, out int number3, out int number4)
            {
                number3 = number1 + number2;
                number4 = number1 * number2;
            }
            //int addResult1;
            //int mulResult1;
            AddNumbers3(10, 200, out int addResult1, out int mulResult1);
            Console.WriteLine($"10 + 200 = {addResult1} & 10 * 200 = {mulResult1}");


            /*
            // Compile-time Error because wa connot use ref keyword in anonymous method : 
            Action < int, int, out int, out int> obj2 = delegate (int number1, int number2, out int number3, out int number4)
            {
                number3 = number1 + number2;
                number4 = number1 * number2;
            };
            */


            void AddNumbers4(params int[]numbers)
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                Console.WriteLine($"Sum of given number is : {sum}");
            }
            AddNumbers4(10, 20, 30, 40);


            /*
            // Compile-time Error because wa connot use ref keyword in anonymous method : 
            Action <params int[]> obj2 = delegate (params int[]  numbers)
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                Console.WriteLine($"Sum of given number is : {sum}");
            };
            */


            void AddNumbers5<T>(T number1 , T number2)
            {
                dynamic dynamicValue1 = number1;
                dynamic dynamicValue2 = number2;
                Console.WriteLine($"{dynamicValue1} + {dynamicValue2} = {dynamicValue1 + dynamicValue2}");
            }
            AddNumbers5(10, 25);
            AddNumbers5(10.45, 25.369);
            AddNumbers5("Hello ", "World");

        }
    }
}