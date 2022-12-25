namespace Generics_Whats_And_Whys
{
    public class Utilities<T> where T : IComparable<T> , new()
    {

        /*
  
         - where T : IComparable (Interface) => T implemente this interface
         - where T : Product (Class)  => T is a Product or any of its children
         - where T : struct  => T is should be a value type
         - where T : class  => T is should be a reference type
         - where T : new()  => T is should be an object that has a default constructor
         
         */
        /*
        // Normal way
        public int Max(int value1 , int value2)
        {
            return (value1 >= value2) ? value1 : value2 ;
        }
        */


        /*
        // Generic version
        public T Max<T>(T value1 , T value2) where T : IComparable<T>
        {
            return (value1.CompareTo(value2) >= 0) ? value1 : value2;
        }
        */
        // Generic version : Generic Method and Generic Class
        public T Max(T value1, T value2)
        {
            return (value1.CompareTo(value2) >= 0) ? value1 : value2;
        }

        public void DoSomething(T value)
        {
            T obj = new T();
        }
    }
}
