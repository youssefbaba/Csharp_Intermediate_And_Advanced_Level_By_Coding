namespace Generics_Part1
{

    /*
     
     - where T : IComparable  : where T : interface = T should be implement that interface .
     - where T : Product : where T : class = T is a class or any of its subclasses .
     - where T : struct  = T should be a value type .
     - where T : class  = T should be a reference type .
     - where T : new()  = T is an object that has a default constructor .
     
     */
    public class Test<T> where T : IComparable , new()   // Generic Class
    {
        public T Max(T number1, T number2)  // Non-Generic method inside Non-Generic class
        {
            return (number1.CompareTo(number2) > 0) ? number1 : number2;
        }
        public void DoSomething(T value)
        {
            var obj = new T();
            // Some logic here ...
        }
    }
}