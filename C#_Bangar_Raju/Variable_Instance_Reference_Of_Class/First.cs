namespace Variable_Instance_Reference_Of_Class
{
    internal class First
    {
        // Fields
        int _value = 100; // Instance field
        static void Main(string[] args)
        {
            First f1; // f1 is Variable of class
            First f2 = new First(); // f2 is Instance of variable
            First f3 = new First(); // f3 is Instance of variable
            Console.WriteLine($"{f2._value} : {f3._value}"); // 100 : 100
            f2._value = 200;
            Console.WriteLine($"{f2._value} : {f3._value}"); // 200 : 100
            f3._value = 300;
            Console.WriteLine($"{f2._value} : {f3._value}"); // 200 : 300

            First f4 = new First();
            f4._value = 1000;
            First f5 = f4; // f5 is Reference of the  class (is pointer to f4)
            Console.WriteLine($"{f4._value} : {f5._value}"); // 1000 : 1000
            f4._value = 2000;
            Console.WriteLine($"{f4._value} : {f5._value}"); // 2000 : 2000
            f5._value = 3000;
            Console.WriteLine($"{f4._value} : {f5._value}"); // 3000 : 3000


        }
    }
}