namespace Func__Action_Predicate_Delegates
{
    //public delegate double DelegateOne(int number1, float number2, double number3);
    //public delegate void DelegateTwo(int number1, float number2, double number3);
    //public delegate bool DelegateThree(string str);

    public class GenericDelegatesOne
    {
        /*
         - Pre-defined Generic Delegate : 
            - Func<>
            - Action<>
            - Predicate<>
         
         */


        public static double AddNumbersOne(int number1, float number2, double number3)
        {
            return number1 + number2 + number3;
        }
        public static void AddNumbersTwo(int number1, float number2, double number3)
        {
            Console.WriteLine(number1 + number2 + number3);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length < 5)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            //DelegateOne obj1 = AddNumbersOne;
            Func<int, float, double, double> obj1 = AddNumbersOne;
            double result1 = obj1.Invoke(10 , 15.5f ,20.2);
            Console.WriteLine(result1);


            //DelegateTwo obj2 = AddNumbersTwo;
            Action<int, float, double> obj2 = AddNumbersTwo;
            obj2.Invoke(10, 15.5f, 20.2);


            //DelegateThree obj3 = CheckLength;
            //Func<string, bool> obj3 = CheckLength;
            Predicate<string> obj3 = CheckLength;
            bool result2 = obj3.Invoke("Hello World");
            Console.WriteLine(result2);

           
        }
    }
}