namespace Generics
{
    // Generic Class
    public class Utilities<T> where T : IComparable , new()
    {
        // Methods
        public double MaxNumber(double number1, double number2)
        {
            return (number1 >= number2) ? number1 : number2;
        }


        /*
 
        // Generic Method
        public T MaxNumber<T>(T number1 , T number2) where T : IComparable   // by default complier considers T as an object
        {
            return (number1.CompareTo(number2) >= 0) ? number1 : number2;
        }

        */

        public T MaxNumber(T number1, T number2)
        {
            return (number1.CompareTo(number2) >= 0) ? number1 : number2;
        }

        public void DoSomething(T value)
        {
            T obj = new T();
            // Some statements here ...
        }
    }
}