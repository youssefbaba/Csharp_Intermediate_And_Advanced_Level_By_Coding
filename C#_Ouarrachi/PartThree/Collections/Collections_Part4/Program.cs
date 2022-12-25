namespace Collections_Part4
{
    public class Program
    {
        /*
         - Generic Collection : is a collection that is capable of storing specified type of values.
         - dynamic keyword identifies data type at run-time
         - var keyword identifies data type at compile-time
            


         */
        static void Main(string[] args)
        {
            Generics1 obj = new Generics1();
            Console.WriteLine(obj.Compare(10, 20));         // => Console.WriteLine(obj.Compare<int>(10, 20)); 
            Console.WriteLine(obj.Compare(10, 10));
            Console.WriteLine(obj.Compare(10.5f, 10.6f));   // => Console.WriteLine(obj.Compare<float>(10.5f, 10.6f));
            Console.WriteLine(obj.Compare(20.5f, 20.5f));
            Console.WriteLine(obj.Compare(true, false));    // => Console.WriteLine(obj.Compare<bool>(true, false));
            Console.WriteLine(obj.Compare("Hello", "World")); // => Console.WriteLine(obj.Compare<string>("Hello", "World"));
            //Console.WriteLine(obj.Compare("Hello", 10)); // Not type safe if we use  Compare(object par1, object par2) method 
            //Console.WriteLine(obj.Compare(true, 10.5));  // Not type safe if we use Compare(object par1, object par2) method 
            //Console.WriteLine(obj.Compare(15, 18)); // Boxing and Unboxing if we use Compare(object par1, object par2) method which is kills the performance of the application
            //Console.WriteLine(obj.Compare(12.5, 23.1)); // Boxing and Unboxing if we use Compare(object par1, object par2) method which is kills the performance of the application

            Console.WriteLine(obj.Compare(12.5f , 20.8));  // => Console.WriteLine(obj.Compare<float>(12.5f, 20.8));
            Console.WriteLine(obj.Compare(12.5f , (float)12.5)); // => Console.WriteLine(obj.Compare<float>(12.5f, 12.5));
            //Console.WriteLine(obj.Compare<string>("Hello" , 12)); // Error : cannot convert int to string
            //Console.WriteLine(obj.Compare<int>("Hello" , 12));  // Error : cannot convert string to int
        }
    }
}